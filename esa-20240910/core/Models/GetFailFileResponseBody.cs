// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetFailFileResponseBody : TeaModel {
        /// <summary>
        /// <para>The download link for the failed task file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://<b><b>.oss-cn-shenzhen.aliyuncs.com/fail-1593805857882113?Expires=1708659191&amp;OSSAccessKeyId=</b></b><b><b><b>&amp;Signature=</b></b></b>****</para>
        /// </summary>
        [NameInMap("DownloadLink")]
        [Validation(Required=false)]
        public string DownloadLink { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
