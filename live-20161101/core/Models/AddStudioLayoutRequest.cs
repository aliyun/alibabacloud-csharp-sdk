// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddStudioLayoutRequest : TeaModel {
        /// <summary>
        /// <para>The background material configurations. The value is a JSON string. For more information, see <b>BgImageConfig</b>.</para>
        /// <remarks>
        /// <para> This parameter is required only if you set LayoutType to studio.</para>
        /// </remarks>
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
        /// <para> The production studio must be a virtual studio that you create in advance. You can use the ApsaraVideo Live console or call the CreateCaster operation to create a virtual studio.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>If the production studio was created by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster</a> operation, check the value of the response parameter CasterId to obtain the ID.</description></item>
        /// <item><description>If the production studio was created by using the ApsaraVideo Live console, obtain the ID on the <b>Production Studio Management</b> page. To go to the page, log on to the <b>ApsaraVideo Live console</b> and click <b>Production Studios</b> in the left-side navigation pane.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You can find the ID of the production studio in the Instance ID/Name column.</para>
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
        /// <para>The common layout configurations. The value is a JSON string. For more information, see <b>CommonConfig</b>.</para>
        /// <remarks>
        /// <para> This parameter is required only if you set LayoutType to common.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ChannelId&quot;:&quot;RV01&quot; }</para>
        /// </summary>
        [NameInMap("CommonConfig")]
        [Validation(Required=false)]
        public string CommonConfig { get; set; }

        /// <summary>
        /// <para>The layer sorting configurations. The value is a JSON string. For more information, see <b>layerOrderConfig</b>. You can sort layers of background and multimedia materials. The chroma key layer cannot be sorted. A layer that is in the front of the code is placed behind other layers in the layout.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ 	{ 	&quot;Type&quot;:&quot;media&quot;, 	&quot;Id&quot;:&quot;k12kj31****&quot; 	}, 	{ 	&quot;Type&quot;:&quot;media&quot;, 	&quot;Id&quot;:&quot;k12kj31****&quot; 	} ]</para>
        /// </summary>
        [NameInMap("LayerOrderConfigList")]
        [Validation(Required=false)]
        public string LayerOrderConfigList { get; set; }

        /// <summary>
        /// <para>The name of the layout.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test layout</para>
        /// </summary>
        [NameInMap("LayoutName")]
        [Validation(Required=false)]
        public string LayoutName { get; set; }

        /// <summary>
        /// <para>The type of the layout. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>common</b>: If you set this parameter to common, you must specify the CommonConfig parameter.</description></item>
        /// <item><description><b>studio</b>: If you set this parameter to studio, you must specify the BgImageConfig and ScreenInputConfigList parameters. The MediaInputConfigList parameter is optional.</description></item>
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
        /// <para>The multimedia input configurations. The value is a JSON string. For more information, see <b>MediaInputConfig</b>.</para>
        /// <remarks>
        /// <para> This parameter is optional and is valid only if you set LayoutType to studio.</para>
        /// </remarks>
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

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The input configurations for chroma key. The value is a JSON string. For more information, see <b>ScreenInputConfig</b>.</para>
        /// <remarks>
        /// <para> This parameter is required only if you set LayoutType to studio.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[ 	{ 	&quot;Index&quot;:&quot;1&quot;, 	&quot;ChannelId&quot;:&quot;RV01&quot;, 	&quot;Color&quot;:&quot;green&quot;, 	&quot;PositionX&quot;:&quot;0.1&quot;, 	&quot;PositionY&quot;:&quot;0.2&quot;, 	&quot;HeightNormalized&quot;:&quot;0.4&quot; 	} ]</para>
        /// </summary>
        [NameInMap("ScreenInputConfigList")]
        [Validation(Required=false)]
        public string ScreenInputConfigList { get; set; }

    }

}
