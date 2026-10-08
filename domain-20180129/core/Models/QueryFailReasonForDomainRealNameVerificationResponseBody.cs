// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryFailReasonForDomainRealNameVerificationResponseBody : TeaModel {
        /// <summary>
        /// <para>List of reasons for identity verification failure.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryFailReasonForDomainRealNameVerificationResponseBodyData> Data { get; set; }
        public class QueryFailReasonForDomainRealNameVerificationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-03-17 11:08:02</para>
            /// </summary>
            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            /// <summary>
            /// <para>Review Status. Valid values:  </para>
            /// <list type="bullet">
            /// <item><description><b>NONAUDIT</b>: Not authenticated.  </description></item>
            /// <item><description><b>SUCCEED</b>: Succeeded.  </description></item>
            /// <item><description><b>FAILED</b>: Review failed.  </description></item>
            /// <item><description><b>AUDITING</b>: Under review.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCEED</para>
            /// </summary>
            [NameInMap("DomainNameVerificationStatus")]
            [Validation(Required=false)]
            public string DomainNameVerificationStatus { get; set; }

            /// <summary>
            /// <para>Reason for real-name verification failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>审核失败，所有者（中文）字段必须包含中文字符。</para>
            /// </summary>
            [NameInMap("FailReason")]
            [Validation(Required=false)]
            public string FailReason { get; set; }

        }

        /// <summary>
        /// <para>Unique request access token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1F1BA893-AD33-4248-8CB8-1657E3733052</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
