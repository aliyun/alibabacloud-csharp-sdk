// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class DeleteMediaInfosRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to delete the physical file of the media asset.</para>
        /// <para>If the media asset is stored in your own OSS bucket, you must authorize the service role AliyunICEDefaultRole in advance. For more information&lt;props=&quot;china&quot;&gt;, see <a href="https://help.aliyun.com/zh/ims/user-guide/record?spm=a2c4g.11186623.0.i8#0737d9c437bmn">Authorize IMS to delete recording files in OSS</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletePhysicalFiles")]
        [Validation(Required=false)]
        public bool? DeletePhysicalFiles { get; set; }

        /// <summary>
        /// <para>The URL of the media asset that you want to delete. The file corresponding to the URL must be registered with IMS. Separate multiple URLs with commas (,). The following two formats are supported:</para>
        /// <ol>
        /// <item><description>http(s)://example-bucket.oss-cn-shanghai.aliyuncs.com/example.mp4?</description></item>
        /// <item><description>OSS://example-bucket/example.mp4?\
        /// In this format, it is considered by default that the region of the OSS bucket in which the media asset resides is the same as the region in which IMS is activated.</description></item>
        /// </ol>
        /// </summary>
        [NameInMap("InputURLs")]
        [Validation(Required=false)]
        public string InputURLs { get; set; }

        /// <summary>
        /// <para>The ID of the media asset that you want to delete from Intelligent Media Services (IMS).</para>
        /// <list type="bullet">
        /// <item><description>Separate multiple IDs with commas (,).</description></item>
        /// </list>
        /// <para>If you leave MediaIds empty, you must specify InputURLs.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b>,<b><b>15d4a4b0448391508f2cb486</b></b></para>
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

    }

}
