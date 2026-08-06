// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class DownloadSkillVersionViaOssResponseBody : TeaModel {
        /// <summary>
        /// <para>The OSS URL for downloading the skill.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://sample-bucket.oss-region.aliyuncs.com/xxxxxx">https://sample-bucket.oss-region.aliyuncs.com/xxxxxx</a></para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9E87E66-9EF0-5C10-A5E6-924020A0C9B7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
