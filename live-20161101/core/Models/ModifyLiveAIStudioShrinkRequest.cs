// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyLiveAIStudioShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the background material in ApsaraVideo VOD. You can obtain the ID from the ApsaraVideo VOD console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d0eb493192c771efba644531858c0102</para>
        /// </summary>
        [NameInMap("BackgroundResourceId")]
        [Validation(Required=false)]
        public string BackgroundResourceId { get; set; }

        /// <summary>
        /// <para>The URL of the background material.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxx.com/2.mp4">https://xxx.com/2.mp4</a></para>
        /// </summary>
        [NameInMap("BackgroundResourceUrl")]
        [Validation(Required=false)]
        public string BackgroundResourceUrl { get; set; }

        /// <summary>
        /// <para>The type of the background material. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>VOD: a video in ApsaraVideo VOD</description></item>
        /// <item><description>PIC: an image</description></item>
        /// <item><description>LIVE: a live stream</description></item>
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
        /// <para>custom</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The preview height. Unit: pixels.</para>
        /// <para>The following preview specifications (width × height) are supported:</para>
        /// <list type="bullet">
        /// <item><description>Landscape low definition 360p (640×360)</description></item>
        /// <item><description>Portrait low definition 360p (360×640)</description></item>
        /// <item><description>Landscape standard definition 480p (854×480)</description></item>
        /// <item><description>Portrait standard definition 480p (480×854)</description></item>
        /// <item><description>Landscape high definition 720p (1280×720)</description></item>
        /// <item><description>Portrait high definition 720p (720×1280)</description></item>
        /// <item><description>Landscape ultra-high definition 1080p (1920×1080)</description></item>
        /// <item><description>Portrait ultra-high definition 1080p (1080×1920)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1080</para>
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        /// <summary>
        /// <para>The layout information of the chroma-keyed material.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MattingLayout")]
        [Validation(Required=false)]
        public string MattingLayoutShrink { get; set; }

        /// <summary>
        /// <para>The type of chroma key. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>green: green-screen chroma key</description></item>
        /// <item><description>blue: blue-screen chroma key</description></item>
        /// <item><description>complex: background replacement</description></item>
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
        /// <para>The layout information of the multimedia material.</para>
        /// </summary>
        [NameInMap("MediaLayout")]
        [Validation(Required=false)]
        public string MediaLayoutShrink { get; set; }

        /// <summary>
        /// <para>The ID of the multimedia material in ApsaraVideo VOD. You can obtain the ID from the ApsaraVideo VOD console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d0eb493192c771efba644531858c01102</para>
        /// </summary>
        [NameInMap("MediaResourceId")]
        [Validation(Required=false)]
        public string MediaResourceId { get; set; }

        /// <summary>
        /// <para>The URL of the multimedia material. Specify either this parameter or the MediaResourceId parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxx.com/1.mp4">https://xxx.com/1.mp4</a></para>
        /// </summary>
        [NameInMap("MediaResourceUrl")]
        [Validation(Required=false)]
        public string MediaResourceUrl { get; set; }

        /// <summary>
        /// <para>The type of the multimedia material. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>VOD: a video in ApsaraVideo VOD</description></item>
        /// <item><description>PIC: an image</description></item>
        /// <item><description>LIVE: a live stream</description></item>
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

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the virtual studio template. The name is the same as the value of the StudioName parameter that was specified when you called the CreateLiveAIStudio operation to create the virtual studio template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stu02</para>
        /// </summary>
        [NameInMap("StudioName")]
        [Validation(Required=false)]
        public string StudioName { get; set; }

        /// <summary>
        /// <para>The preview width. Unit: pixels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1920</para>
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

    }

}
