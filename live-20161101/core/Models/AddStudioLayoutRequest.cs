// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddStudioLayoutRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the background resource. The value is a JSON string. For more information, see <b>BgImageConfig</b>.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is required only when you set LayoutType to studio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;Id&quot;:&quot;k12kj31****&quot;, &quot;MaterialId&quot;:&quot;f080575eb5f4427684fc0715159a****&quot; }</para>
        /// </summary>
        [NameInMap("BgImageConfig")]
        [Validation(Required=false)]
        public string BgImageConfig { get; set; }

        /// <summary>
        /// <para>The ID of the production studio.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>Create a virtual production studio in advance. You can create a production studio in the console or by calling the <a href="https://help.aliyun.com/document_detail/69338.html">CreateCaster</a> API operation. The production studio must be a virtual production studio.</para>
        /// <list type="bullet">
        /// <item><description><para>If you call the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> API operation to create a production studio, use the returned CasterId value.</para>
        /// </description></item>
        /// <item><description><para>If you create a production studio in the ApsaraVideo Live console, go to the <b>ApsaraVideo Live console</b> &gt; <b>Production Studio</b> &gt; <b>Cloud Production Studio</b> page. The name of the production studio in the list is its ID.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The name of the production studio in the list on the Cloud Production Studio page is the production studio ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a2b8e671-2fe5-4642-a2ec-bf93880e****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>The configuration of the common layout. The value is a JSON string. For more information, see <b>CommonConfig</b>.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is required only when you set LayoutType to common.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ChannelId&quot;:&quot;RV01&quot; }</para>
        /// </summary>
        [NameInMap("CommonConfig")]
        [Validation(Required=false)]
        public string CommonConfig { get; set; }

        /// <summary>
        /// <para>The layer order settings. The value is a JSON string. For more information, see <b>LayerOrderConfig</b>. You can sort background materials and multimedia materials. Chroma keying layers are not supported. The earlier a material appears in the list, the lower its layer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ 	{ 	&quot;Type&quot;:&quot;media&quot;, 	&quot;Id&quot;:&quot;k12kj31****&quot; 	}, 	{ 	&quot;Type&quot;:&quot;media&quot;, 	&quot;Id&quot;:&quot;k12kj31****&quot; 	} ]</para>
        /// </summary>
        [NameInMap("LayerOrderConfigList")]
        [Validation(Required=false)]
        public string LayerOrderConfigList { get; set; }

        /// <summary>
        /// <para>The name of the studio layout.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test layout</para>
        /// </summary>
        [NameInMap("LayoutName")]
        [Validation(Required=false)]
        public string LayoutName { get; set; }

        /// <summary>
        /// <para>The type of the studio layout. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>common</b>: A common layout. If you set LayoutType to common, you must also specify CommonConfig.</para>
        /// </description></item>
        /// <item><description><para><b>studio</b>: A studio layout. If you set LayoutType to studio, you must also specify BgImageConfig and ScreenInputConfigList. The MediaInputConfigList parameter is optional.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>studio</para>
        /// </summary>
        [NameInMap("LayoutType")]
        [Validation(Required=false)]
        public string LayoutType { get; set; }

        /// <summary>
        /// <para>The settings for the multimedia input resource. The value is a JSON string. For more information, see <b>MediaInputConfig</b>.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is valid and optional only when you set LayoutType to studio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ 	{ 	&quot;Id&quot;:&quot;k12kj31****&quot;, 	&quot;Index&quot;:&quot;1&quot;, 	&quot;ChannelId&quot;:&quot;RV01&quot;, 	&quot;FillMode&quot;:&quot;none&quot;, 	&quot;PositionRefer&quot;:&quot;topLeft&quot;, 	&quot;WidthNormalized&quot;:&quot;0.4&quot;, 	&quot;HeightNormalized&quot;:&quot;0.4&quot;, 	&quot;PositionNormalized&quot;:&quot;[0.1, 0.2]&quot; 	},   { 	&quot;Id&quot;:&quot;k12kj31****&quot;, 	&quot;Index&quot;:&quot;2&quot;, 	&quot;ImageMaterialId&quot;:&quot;lkajsdfsa8fd89asd8****&quot;, 	&quot;FillMode&quot;:&quot;none&quot;, 	&quot;PositionRefer&quot;:&quot;topLeft&quot;, 	&quot;WidthNormalized&quot;:&quot;0.6&quot;, 	&quot;HeightNormalized&quot;:&quot;0.4&quot;, 	&quot;PositionNormalized&quot;:&quot;[0.1, 0.2]&quot; 	} ]</para>
        /// </summary>
        [NameInMap("MediaInputConfigList")]
        [Validation(Required=false)]
        public string MediaInputConfigList { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The settings for the chroma keying input. The value is a JSON string. For more information, see <b>ScreenInputConfig</b>.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>This parameter is required only when you set LayoutType to studio.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ 	{ 	&quot;Index&quot;:&quot;1&quot;, 	&quot;ChannelId&quot;:&quot;RV01&quot;, 	&quot;Color&quot;:&quot;green&quot;, 	&quot;PositionX&quot;:&quot;0.1&quot;, 	&quot;PositionY&quot;:&quot;0.2&quot;, 	&quot;HeightNormalized&quot;:&quot;0.4&quot; 	} ]</para>
        /// </summary>
        [NameInMap("ScreenInputConfigList")]
        [Validation(Required=false)]
        public string ScreenInputConfigList { get; set; }

    }

}
