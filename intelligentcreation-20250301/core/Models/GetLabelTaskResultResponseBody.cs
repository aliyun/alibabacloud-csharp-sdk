// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IntelligentCreation20250301.Models
{
    public class GetLabelTaskResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ABCDEFGH-1234-5678-90AB-123456789ABC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://bucket.oss.cn-zhangjiakou.aliyuncs.com/key">http://bucket.oss.cn-zhangjiakou.aliyuncs.com/key</a></para>
        /// </summary>
        [NameInMap("ResultDataUrl")]
        [Validation(Required=false)]
        public string ResultDataUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>IN_PROGRESS</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("Tokens")]
        [Validation(Required=false)]
        public string Tokens { get; set; }

    }

}
