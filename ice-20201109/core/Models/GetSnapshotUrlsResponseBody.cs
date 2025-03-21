// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetSnapshotUrlsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of snapshot URLs.</para>
        /// </summary>
        [NameInMap("SnapshotUrls")]
        [Validation(Required=false)]
        public List<string> SnapshotUrls { get; set; }

        /// <summary>
        /// <para>The total number of snapshots.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

        /// <summary>
        /// <para>The URL of the WebVTT file.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://test-bucket.oss-cn-shanghai.aliyuncs.com/ouoput.vtt">http://test-bucket.oss-cn-shanghai.aliyuncs.com/ouoput.vtt</a></para>
        /// </summary>
        [NameInMap("WebVTTUrl")]
        [Validation(Required=false)]
        public string WebVTTUrl { get; set; }

    }

}
