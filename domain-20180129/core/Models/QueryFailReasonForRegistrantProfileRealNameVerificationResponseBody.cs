// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class QueryFailReasonForRegistrantProfileRealNameVerificationResponseBody : TeaModel {
        /// <summary>
        /// <para>The List of reasons why identity verification failed the Review.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryFailReasonForRegistrantProfileRealNameVerificationResponseBodyData> Data { get; set; }
        public class QueryFailReasonForRegistrantProfileRealNameVerificationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Review Date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-03-17 11:08:02</para>
            /// </summary>
            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            /// <summary>
            /// <para>The reason why identity verification failed the Review.</para>
            /// <para>For Solutions after identity verification fails the Review, see <a href="https://help.aliyun.com/document_detail/35885.html">Reasons for identity verification failure and Solutions</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>证件电子信息核验不合格</para>
            /// </summary>
            [NameInMap("FailReason")]
            [Validation(Required=false)]
            public string FailReason { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>548C407F-AEA2-4B5D-90DF-EC11EBB1D76F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
