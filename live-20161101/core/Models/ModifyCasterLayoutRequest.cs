// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyCasterLayoutRequest : TeaModel {
        /// <summary>
        /// <para>The audio information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AudioLayer")]
        [Validation(Required=false)]
        public List<ModifyCasterLayoutRequestAudioLayer> AudioLayer { get; set; }
        public class ModifyCasterLayoutRequestAudioLayer : TeaModel {
            /// <summary>
            /// <para>The fixed delay for the audio. This can be used for subtitle synchronization. Unit: milliseconds. Default value: <b>0</b>. Valid values: <b>0 to 5000</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("FixedDelayDuration")]
            [Validation(Required=false)]
            public int? FixedDelayDuration { get; set; }

            /// <summary>
            /// <para>The audio channels that can be used as volume input. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>leftChannel</b>: left channel.</description></item>
            /// <item><description><b>rightChannel</b>: right channel.</description></item>
            /// <item><description><b>all</b> (default): both channels.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("ValidChannel")]
            [Validation(Required=false)]
            public string ValidChannel { get; set; }

            /// <summary>
            /// <para>The normalized height ratio of the Layer element. The width of the element is proportionally scaled based on this height. </para>
            /// <para>Default value: <b>0</b>, which indicates that the element is displayed at its original size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VolumeRate")]
            [Validation(Required=false)]
            public float? VolumeRate { get; set; }

        }

        /// <summary>
        /// <para>The location ID (LocationId) of the video resource element.</para>
        /// <para>For the LocationId, see <a href="https://help.aliyun.com/document_detail/2848020.html">Add a video source</a>. The elements correspond to the VideoLayers elements in order.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RV02</para>
        /// </summary>
        [NameInMap("BlendList")]
        [Validation(Required=false)]
        public List<string> BlendList { get; set; }

        /// <summary>
        /// <para>The production studio ID.</para>
        /// <list type="bullet">
        /// <item><description><para>If you created the production studio by calling the <a href="https://help.aliyun.com/document_detail/2848009.html">CreateCaster operation</a>, check the CasterId parameter returned by the CreateCaster operation.</para>
        /// </description></item>
        /// <item><description><para>If you created the production studio in the ApsaraVideo Live console, go to <b>ApsaraVideo Live console</b> &gt; <b>Production Studio</b> &gt; <b>Cloud Production Studio</b> to view the ID.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The production studio name in the production studio list on the Cloud Production Studio page of the ApsaraVideo Live console is the production studio ID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LIVEPRODUCER_POST-cn-0pp1czt****</para>
        /// </summary>
        [NameInMap("CasterId")]
        [Validation(Required=false)]
        public string CasterId { get; set; }

        /// <summary>
        /// <para>The layout ID. If you added the production studio layout by calling the <a href="https://help.aliyun.com/document_detail/2848025.html">AddCasterLayout operation</a>, check the LayoutId parameter returned by the AddCasterLayout operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21926b36-7dd2-4fde-ae25-51b5bc8e****</para>
        /// </summary>
        [NameInMap("LayoutId")]
        [Validation(Required=false)]
        public string LayoutId { get; set; }

        /// <summary>
        /// <para>The location ID (LocationId) of the audio resource element.</para>
        /// <para>For the LocationId, see <a href="https://help.aliyun.com/document_detail/2848020.html">Add a video source</a>. The elements correspond to the AudioLayers elements in order.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RV02</para>
        /// </summary>
        [NameInMap("MixList")]
        [Validation(Required=false)]
        public List<string> MixList { get; set; }

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
        /// <para>The video information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("VideoLayer")]
        [Validation(Required=false)]
        public List<ModifyCasterLayoutRequestVideoLayer> VideoLayer { get; set; }
        public class ModifyCasterLayoutRequestVideoLayer : TeaModel {
            /// <summary>
            /// <para>The element fill mode. </para>
            /// <list type="bullet">
            /// <item><description><b>none</b> (default): no fill. The Layer settings are configured with the image as the target.</description></item>
            /// <item><description><b>fit</b>: adaptive. The Layer settings are configured with the fill area (box) as the target. The image is scaled based on the original aspect ratio and centered within the fill area (box) using a long-edge alignment method. If the aspect ratio of the fill area does not match the image, the short edges are not filled (the lower Layer image is displayed. If no lower Layer is configured, the default black background is displayed).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>fit</para>
            /// </summary>
            [NameInMap("FillMode")]
            [Validation(Required=false)]
            public string FillMode { get; set; }

            /// <summary>
            /// <para>The fixed delay for the video. This can be used for subtitle synchronization. Unit: milliseconds. Default value: <b>0</b>. Valid values: <b>0 to 5000</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5000</para>
            /// </summary>
            [NameInMap("FixedDelayDuration")]
            [Validation(Required=false)]
            public int? FixedDelayDuration { get; set; }

            /// <summary>
            /// <para>The normalized height ratio of the Layer element. </para>
            /// <list type="bullet">
            /// <item><description>If the no-fill mode is used, the width of the element is proportionally scaled based on this height. Default value: <b>0</b>, which indicates that the image is displayed at its original size.</description></item>
            /// <item><description>If the adaptive mode is used, this field is required and must be greater than <b>0</b>. It specifies the normalized height ratio of the fill area (box).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("HeightNormalized")]
            [Validation(Required=false)]
            public float? HeightNormalized { get; set; }

            /// <summary>
            /// <para>The normalized position values <c>[x,y]</c> of the Layer element. Default value: <c>[0,0]</c>.</para>
            /// <remarks>
            /// <para>Note: The x and y values must be normalized.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0.3</para>
            /// </summary>
            [NameInMap("PositionNormalized")]
            [Validation(Required=false)]
            public List<float?> PositionNormalized { get; set; }

            /// <summary>
            /// <para>The reference coordinate for the position of the element. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>topLeft</b> (default): top-left.</description></item>
            /// <item><description><b>topRight</b>: top-right.</description></item>
            /// <item><description><b>bottomLeft</b>: bottom-left.</description></item>
            /// <item><description><b>bottomRight</b>: bottom-right.</description></item>
            /// <item><description><b>center</b>: center.</description></item>
            /// <item><description><b>topCenter</b>: top-center.</description></item>
            /// <item><description><b>bottomCenter</b>: bottom-center.</description></item>
            /// <item><description><b>leftCenter</b>: left-center.</description></item>
            /// <item><description><b>rightCenter</b>: right-center.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>topLeft</para>
            /// </summary>
            [NameInMap("PositionRefer")]
            [Validation(Required=false)]
            public string PositionRefer { get; set; }

            /// <summary>
            /// <para>The normalized width ratio of the Layer element. </para>
            /// <list type="bullet">
            /// <item><description>If the no-fill mode is used, the height of the element is proportionally scaled based on this width. Default value: <b>0</b>, which indicates that the image is displayed at its original size.</description></item>
            /// <item><description>If the adaptive mode is used, this field is required and must be greater than <b>0</b>. It specifies the normalized width ratio of the fill area (box).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("WidthNormalized")]
            [Validation(Required=false)]
            public float? WidthNormalized { get; set; }

        }

    }

}
