// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class MediaObject : TeaModel {
        /// <summary>
        /// <para>The identifier for the media file.</para>
        /// <list type="bullet">
        /// <item><description>If Type is set to OSS, the value is the URL of the media file. The following formats are supported: oss://... and https://...</description></item>
        /// <item><description>If Type is set to Media, the value is the ID of the media asset.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://bucket.loction.aliyuncs.com/path/to/video.mp4">http://bucket.loction.aliyuncs.com/path/to/video.mp4</a></para>
        /// </summary>
        [NameInMap("Media")]
        [Validation(Required=false)]
        public string Media { get; set; }

        /// <summary>
        /// <para>The type of media source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>OSS: an OSS object.</description></item>
        /// <item><description>Media: a media asset.</description></item>
        /// <item><description>ExternalURL: a publicly accessible external URL. This is not available for public use.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OSS</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
