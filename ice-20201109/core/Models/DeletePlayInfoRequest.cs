// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeletePlayInfoRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to delete the physical file of the media stream.</para>
        /// <para>If the media asset is stored in your own Object Storage Service (OSS) bucket, you must authorize the service role AliyunICEDefaultRole in advance. &lt;props=&quot;china&quot;&gt;For more information, see <a href="https://help.aliyun.com/document_detail/449331.html#p-ko2-wc7-iad">Authorize IMS to delete recording files in OSS</a>.</para>
        /// <para>You can delete only the physical files of transcoded streams, but not the physical files of source files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletePhysicalFiles")]
        [Validation(Required=false)]
        public bool? DeletePhysicalFiles { get; set; }

        /// <summary>
        /// <para>The URL of the media stream file that you want to delete. Separate multiple URLs with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://ice-test001.oss-cn-shanghai.aliyuncs.com/%E6%8E%A5%E5%8F%A3%E6%B5%8B%E8%AF%95/%E5%B0%8F%E7%8C%AA%E4%BD%A9%E5%A5%87640*360.mp4">https://ice-test001.oss-cn-shanghai.aliyuncs.com/%E6%8E%A5%E5%8F%A3%E6%B5%8B%E8%AF%95/%E5%B0%8F%E7%8C%AA%E4%BD%A9%E5%A5%87640*360.mp4</a></para>
        /// </summary>
        [NameInMap("FileURLs")]
        [Validation(Required=false)]
        public string FileURLs { get; set; }

        /// <summary>
        /// <para>The ID of the media asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d3518e0027d71ed80cd909598416303</para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

    }

}
