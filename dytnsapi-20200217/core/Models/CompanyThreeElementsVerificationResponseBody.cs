// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class CompanyThreeElementsVerificationResponseBody : TeaModel {
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
        /// <para>The request status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CompanyThreeElementsVerificationResponseBodyData Data { get; set; }
        public class CompanyThreeElementsVerificationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The company details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;enterpriseStatus&quot;: &quot;在营（开业）&quot;,
            ///       &quot;openTime&quot;: &quot;2023-05-25/2053-05-24&quot;
            /// }</para>
            /// </summary>
            [NameInMap("DetailInfo")]
            [Validation(Required=false)]
            public CompanyThreeElementsVerificationResponseBodyDataDetailInfo DetailInfo { get; set; }
            public class CompanyThreeElementsVerificationResponseBodyDataDetailInfo : TeaModel {
                /// <summary>
                /// <para>The operating status of the company.</para>
                /// 
                /// <b>Example:</b>
                /// <para>在营（开业）</para>
                /// </summary>
                [NameInMap("EnterpriseStatus")]
                [Validation(Required=false)]
                public string EnterpriseStatus { get; set; }

                /// <summary>
                /// <para>The business term of the company.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-05-25/2053-05-24</para>
                /// </summary>
                [NameInMap("OpenTime")]
                [Validation(Required=false)]
                public string OpenTime { get; set; }

            }

            /// <summary>
            /// <para>The fields whose verification results are inconsistent.</para>
            /// </summary>
            [NameInMap("InconsistentData")]
            [Validation(Required=false)]
            public List<string> InconsistentData { get; set; }

            /// <summary>
            /// <para>The verification result code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The verification is consistent.</description></item>
            /// <item><description>1: The verification is consistent, but the company is not operating normally.</description></item>
            /// <item><description>2: The person-company verification is inconsistent.</description></item>
            /// <item><description>3: The two-element company verification failed.</description></item>
            /// <item><description>4: The company is not found.</description></item>
            /// <item><description>5: The person does not exist in the database.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public long? ReasonCode { get; set; }

            /// <summary>
            /// <para>The verification result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The information is consistent and the company is operating normally.</description></item>
            /// <item><description>false: The verification failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("VerifyResult")]
            [Validation(Required=false)]
            public string VerifyResult { get; set; }

        }

        /// <summary>
        /// <para>The description of the returned status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The common parameter. Each request returns a unique ID, which can be used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>68A40250-50CD-034C-B728-0BD135850177</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
