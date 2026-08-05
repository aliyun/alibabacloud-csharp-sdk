// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ModifyLiveAIStudioShrinkRequest : TeaModel {
        /// <summary>
        /// <para>VOD resource ID of the background material, obtained from the VOD console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d0eb493192c771efba644531858c0102</para>
        /// </summary>
        [NameInMap("BackgroundResourceId")]
        [Validation(Required=false)]
        public string BackgroundResourceId { get; set; }

        /// <summary>
        /// <para>Resource access URL of the background material.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxx.com/2.mp4">https://xxx.com/2.mp4</a></para>
        /// </summary>
        [NameInMap("BackgroundResourceUrl")]
        [Validation(Required=false)]
        public string BackgroundResourceUrl { get; set; }

        /// <summary>
        /// <para>Background material type:</para>
        /// <list type="bullet">
        /// <item><description>VOD: Video on demand</description></item>
        /// <item><description>PIC: Image</description></item>
        /// <item><description>LIVE: Live stream</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>VOD</para>
        /// </summary>
        [NameInMap("BackgroundType")]
        [Validation(Required=false)]
        public string BackgroundType { get; set; }

        /// <summary>
        /// <para>Custom description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>custom</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Preview screen height, unit: px.</para>
        /// <para>The preview screen width x height only supports the following specifications:</para>
        /// <list type="bullet">
        /// <item><description>Landscape Smooth 360P 640x360</description></item>
        /// <item><description>Portrait Smooth 360P 360x640</description></item>
        /// <item><description>Landscape Standard Definition 480P 854x480</description></item>
        /// <item><description>Portrait Standard Definition 480P 480x854</description></item>
        /// <item><description>Landscape HD 720P 1280x720</description></item>
        /// <item><description>Portrait HD 720P 720x1280</description></item>
        /// <item><description>Landscape Full HD 1080P 1920x1080</description></item>
        /// <item><description>Portrait Full HD 1080P 1080x1920</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1080</para>
        /// </summary>
        [NameInMap("Height")]
        [Validation(Required=false)]
        public int? Height { get; set; }

        /// <summary>
        /// <para>Layout position information of the source stream after matting.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("MattingLayout")]
        [Validation(Required=false)]
        public string MattingLayoutShrink { get; set; }

        /// <summary>
        /// <para>Matting type:</para>
        /// <list type="bullet">
        /// <item><description>green: Green screen matting</description></item>
        /// <item><description>blue: Blue screen matting</description></item>
        /// <item><description>complex: Real-scene matting</description></item>
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
        /// <para>Layout position information of the multimedia material.</para>
        /// </summary>
        [NameInMap("MediaLayout")]
        [Validation(Required=false)]
        public string MediaLayoutShrink { get; set; }

        /// <summary>
        /// <para>VOD resource ID of the multimedia material, obtained from the VOD console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d0eb493192c771efba644531858c01102</para>
        /// </summary>
        [NameInMap("MediaResourceId")]
        [Validation(Required=false)]
        public string MediaResourceId { get; set; }

        /// <summary>
        /// <para>Resource access URL of the multimedia material. Either this or the resource ID should be provided.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xxx.com/1.mp4">https://xxx.com/1.mp4</a></para>
        /// </summary>
        [NameInMap("MediaResourceUrl")]
        [Validation(Required=false)]
        public string MediaResourceUrl { get; set; }

        /// <summary>
        /// <para>Multimedia material type:</para>
        /// <list type="bullet">
        /// <item><description>VOD: Video on demand</description></item>
        /// <item><description>PIC: Image</description></item>
        /// <item><description>LIVE: Live stream</description></item>
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
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Virtual studio template name, same as the StudioName parameter in the create API.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stu02</para>
        /// </summary>
        [NameInMap("StudioName")]
        [Validation(Required=false)]
        public string StudioName { get; set; }

        /// <summary>
        /// <para>Preview screen width, unit: px.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1920</para>
        /// </summary>
        [NameInMap("Width")]
        [Validation(Required=false)]
        public int? Width { get; set; }

    }

}
