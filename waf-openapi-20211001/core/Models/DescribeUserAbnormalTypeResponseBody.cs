// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeUserAbnormalTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The types and statistics of risks.</para>
        /// </summary>
        [NameInMap("Abnormal")]
        [Validation(Required=false)]
        public List<DescribeUserAbnormalTypeResponseBodyAbnormal> Abnormal { get; set; }
        public class DescribeUserAbnormalTypeResponseBodyAbnormal : TeaModel {
            /// <summary>
            /// <para>The code of the risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Risk_InternalWeakPasswd</para>
            /// </summary>
            [NameInMap("AbnormalCode")]
            [Validation(Required=false)]
            public string AbnormalCode { get; set; }

            /// <summary>
            /// <para>The number of risks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("AbnormalCount")]
            [Validation(Required=false)]
            public long? AbnormalCount { get; set; }

            /// <summary>
            /// <para>The parent type of the risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RiskType_Account</para>
            /// </summary>
            [NameInMap("AbnormalParentType")]
            [Validation(Required=false)]
            public string AbnormalParentType { get; set; }

            /// <summary>
            /// <para>The type of the risk.</para>
            /// <remarks>
            /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2859155.html">DescribeApisecRules</a> operation to query the supported types of risks.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>LackOfSpeedLimit</para>
            /// </summary>
            [NameInMap("AbnormalType")]
            [Validation(Required=false)]
            public string AbnormalType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3E1CB966-1407-5988-9432-7***D784</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
