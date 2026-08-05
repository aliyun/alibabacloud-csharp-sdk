// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class CreateLiveAIStudioShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The video-on-demand resource ID of the background material. Obtain this value from the ApsaraVideo VOD console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d0eb493192c771efba644531858c0102</para>
        /// </summary>
        [NameInMap("BackgroundResourceId")]
        [Validation(Required=false)]
        public string BackgroundResourceId { get; set; }

        /// <summary>
        /// <para>The access URL of the background material. Specify either this parameter or the resource ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxx.com/1.mp4">https://xxx.com/1.mp4</a></para>
        /// </summary>
        [NameInMap("BackgroundResourceUrl")]
        [Validation(Required=false)]
        public string BackgroundResourceUrl { get; set; }

        /// <summary>
        /// <para>The type of the background material. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>VOD: video-on-demand video.</description></item>
        /// <item><description>PIC: image.</description></item>
        /// <item><description>LIVE: live stream.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VOD</para>
        /// </summary>
        [NameInMap("BackgroundType")]
        [Validation(Required=false)]
        public string BackgroundType { get; set; }

        /// <summary>
        /// <para>The custom description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>template 1080</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The height of the preview screen. Unit: px.</para>
        /// <para>The width × height of the preview screen supports only the following specifications:</para>
        /// <list type="bullet">
        /// <item><description>Landscape low definition 360P: 640 × 360</description></item>
        /// <item><description>Portrait low definition 360P: 360 × 640</description></item>
        /// <item><description>Landscape standard definition 480P: 854 × 480</description></item>
        /// <item><description>Portrait standard definition 480P: 480 × 854</description></item>
        /// <item><description>Landscape high definition 720P: 1280 × 720</description></item>
        /// <item><description>Portrait high definition 720P: 720 × 1280</description></item>
        /// <item><description>Landscape ultra-high definition 1080P: 1920 × 1080</description></item>
        /// <item><description>Portrait ultra-high definition 1080P: 1080 × 1920.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1080</para>
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        /// <summary>
        /// <para>The layout position information of the source stream after image matting.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MattingLayout")]
        [Validation(Required=false)]
        public string MattingLayoutShrink { get; set; }

        /// <summary>
        /// <para>The image matting type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>green: green screen matting.</description></item>
        /// <item><description>blue: blue screen matting.</description></item>
        /// <item><description>complex: real-scene matting.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>complex</para>
        /// </summary>
        [NameInMap("MattingType")]
        [Validation(Required=false)]
        public string MattingType { get; set; }

        /// <summary>
        /// <para>The layout position information of the multimedia material.</para>
        /// </summary>
        [NameInMap("MediaLayout")]
        [Validation(Required=false)]
        public string MediaLayoutShrink { get; set; }

        /// <summary>
        /// <para>The video-on-demand resource ID of the multimedia material. Obtain this value from the ApsaraVideo VOD console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d0eb493192c771efba644531858c0102</para>
        /// </summary>
        [NameInMap("MediaResourceId")]
        [Validation(Required=false)]
        public string MediaResourceId { get; set; }

        /// <summary>
        /// <para>The access URL of the multimedia material. Specify either this parameter or the resource ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxx.com/2.mp4">https://xxx.com/2.mp4</a></para>
        /// </summary>
        [NameInMap("MediaResourceUrl")]
        [Validation(Required=false)]
        public string MediaResourceUrl { get; set; }

        /// <summary>
        /// <para>The type of the multimedia material. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>VOD: video-on-demand video.</description></item>
        /// <item><description>PIC: image.</description></item>
        /// <item><description>LIVE: live stream.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VOD</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

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
        /// <para>The name of the virtual studio template. The name must be unique.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stu02</para>
        /// </summary>
        [NameInMap("StudioName")]
        [Validation(Required=false)]
        public string StudioName { get; set; }

        /// <summary>
        /// <para>The width of the preview screen. Unit: px.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1920</para>
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

    }

}
