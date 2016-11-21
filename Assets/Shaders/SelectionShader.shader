Shader "SelectionShader" 
{
    Properties 
    {
		_MainTex ("Base (RGB)", 2D) = "white" {}
		_Color ("color", Color) = (1, 0, 0, 1) 
	}
	SubShader 
	{
		Tags { "RenderType"="Transparent" }
		LOD 200
		
		CGPROGRAM
		#pragma surface surf Lambert

		sampler2D _MainTex;
		half4 _Color;

		struct Input 
		{
			float2 uv_MainTex;
		};

		void surf (Input IN, inout SurfaceOutput o) 
		{
			float nRange = .25f;// from 0f to 1f
			float nSpeed = .8f; // bigger values blink faster 
			half4 c = _Color;
			float f = ((nRange * .5f) + (nRange *  (1 + sin(nSpeed * _Time.w ) ) ) );
			c *= f;
			o.Albedo	= c.rgb;
			o.Alpha		= c.a;
		}
		ENDCG
	} 
	FallBack "Transparent/Diffuse"
}