// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class CompanyTwoElementsVerificationResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the access denial.</para>
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
        /// <para>The struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CompanyTwoElementsVerificationResponseBodyData Data { get; set; }
        public class CompanyTwoElementsVerificationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Enterprise details.</para>
            /// <remarks>
            /// <para>This field is not returned for public institutions or civil groups.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;enterpriseStatus&quot;: &quot;在营（开业）&quot;,
            ///       &quot;openTime&quot;: &quot;2023-05-25/2053-05-24&quot;
            /// }</para>
            /// </summary>
            [NameInMap("DetailInfo")]
            [Validation(Required=false)]
            public CompanyTwoElementsVerificationResponseBodyDataDetailInfo DetailInfo { get; set; }
            public class CompanyTwoElementsVerificationResponseBodyDataDetailInfo : TeaModel {
                /// <summary>
                /// <para>The operating status of the enterprise.</para>
                /// 
                /// <b>Example:</b>
                /// <para>在营（开业）</para>
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
            /// <para>The fields that are inconsistent in the verification.</para>
            /// </summary>
            [NameInMap("InconsistentData")]
            [Validation(Required=false)]
            public List<string> InconsistentData { get; set; }

            /// <summary>
            /// <para>The verification result code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Verification consistent</description></item>
            /// <item><description>1: Verification consistent, the enterprise is not in normal operation</description></item>
            /// <item><description>3: The two enterprise elements failed verification</description></item>
            /// <item><description>4: No such enterprise found</description></item>
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
            /// <item><description>true: The information is verified to be consistent, and the enterprise is operating normally.</description></item>
            /// <item><description>false: The verification failed.</description></item>
            /// </list>
            /// <remarks>
            /// <para>The operating status verification is not supported for public institutions or civil groups. Only the consistency between the enterprise name and the enterprise certificate number is verified.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
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
