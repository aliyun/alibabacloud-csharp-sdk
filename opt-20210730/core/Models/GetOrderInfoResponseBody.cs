// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Opt20210730.Models
{
    public class GetOrderInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;licenseKey&quot;:&quot;eems7ri3b1u5nui*****&quot;,&quot;currentConcurrency&quot;:2,&quot;instanceId&quot;:&quot;opt_mplicense_public_cn-****&quot;,&quot;totalDays&quot;:124,&quot;currentDays&quot;:103}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetOrderInfoResponseBodyData> Data { get; set; }
        public class GetOrderInfoResponseBodyData : TeaModel {
            [NameInMap("bizType")]
            [Validation(Required=false)]
            public string BizType { get; set; }

            [NameInMap("currentConcurrency")]
            [Validation(Required=false)]
            public int? CurrentConcurrency { get; set; }

            [NameInMap("currentDays")]
            [Validation(Required=false)]
            public int? CurrentDays { get; set; }

            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("isReleased")]
            [Validation(Required=false)]
            public bool? IsReleased { get; set; }

            [NameInMap("licenseKey")]
            [Validation(Required=false)]
            public string LicenseKey { get; set; }

            [NameInMap("remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("totalDays")]
            [Validation(Required=false)]
            public int? TotalDays { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5D6653C5-CA2B-14EC-9CF0-50AA0FF49C31</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
