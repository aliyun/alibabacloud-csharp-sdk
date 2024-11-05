// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class CompanyTwoElementsVerificationResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CompanyTwoElementsVerificationResponseBodyData Data { get; set; }
        public class CompanyTwoElementsVerificationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information about the enterprise.</para>
            /// </summary>
            [NameInMap("DetailInfo")]
            [Validation(Required=false)]
            public CompanyTwoElementsVerificationResponseBodyDataDetailInfo DetailInfo { get; set; }
            public class CompanyTwoElementsVerificationResponseBodyDataDetailInfo : TeaModel {
                /// <summary>
                /// <para>The business status of the enterprise.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("EnterpriseStatus")]
                [Validation(Required=false)]
                public string EnterpriseStatus { get; set; }

                /// <summary>
                /// <para>The business term of the enterprise.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-05-25/2053-05-24</para>
                /// </summary>
                [NameInMap("OpenTime")]
                [Validation(Required=false)]
                public string OpenTime { get; set; }

            }

            /// <summary>
            /// <para>The fields to be verified.</para>
            /// </summary>
            [NameInMap("InconsistentData")]
            [Validation(Required=false)]
            public List<string> InconsistentData { get; set; }

            /// <summary>
            /// <para>The code of the verification result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The two elements belong to the same enterprise.</description></item>
            /// <item><description>1: The two elements belong to the same enterprise, but the business status of the enterprise is abnormal.</description></item>
            /// <item><description>3: The two elements do not belong to the same enterprise.</description></item>
            /// <item><description>4: No information about the enterprise is found.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

            /// <summary>
            /// <para>The verification result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The two elements belong to the same enterprise and the business status of the enterprise is Active.</description></item>
            /// <item><description>false: The two elements do not belong to the same enterprise.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public string VerifyResult { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique request ID. It is a common parameter and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68A40250-50CD-034C-B728-0BD135850177</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
