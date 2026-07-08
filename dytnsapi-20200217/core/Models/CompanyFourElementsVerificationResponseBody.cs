// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dytnsapi20200217.Models
{
    public class CompanyFourElementsVerificationResponseBody : TeaModel {
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
        /// <para>The structure.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CompanyFourElementsVerificationResponseBodyData Data { get; set; }
        public class CompanyFourElementsVerificationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The enterprise details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;enterpriseStatus&quot;: &quot;在营（开业）&quot;, 
            /// &quot;openTime&quot;: &quot;2023-05-25/2053-05-24&quot; }</para>
            /// </summary>
            [NameInMap("DetailInfo")]
            [Validation(Required=false)]
            public CompanyFourElementsVerificationResponseBodyDataDetailInfo DetailInfo { get; set; }
            public class CompanyFourElementsVerificationResponseBodyDataDetailInfo : TeaModel {
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
            /// <para>The fields that failed verification.</para>
            /// </summary>
            [NameInMap("InconsistentData")]
            [Validation(Required=false)]
            public List<string> InconsistentData { get; set; }

            /// <summary>
            /// <para>The verification result code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: Verification passed.</description></item>
            /// <item><description>1: Verification passed, but the enterprise is not operating normally.</description></item>
            /// <item><description>2: The legal person and enterprise information are inconsistent.</description></item>
            /// <item><description>3: The enterprise four-element verification failed.</description></item>
            /// <item><description>4: The enterprise was not found.</description></item>
            /// <item><description>5: The legal person was not found in the database.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public long? ReasonCode { get; set; }

            /// <summary>
            /// <para>The verification result. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The information is consistent and the enterprise is operating normally.</description></item>
            /// <item><description>false: Verification failed.</description></item>
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
        /// <para>The description of the returned status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The common parameter. The ID returned for each request is unique and can be used to troubleshoot and locate issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CC3BB6D2-2FDF-4321-9DCE-B38165CE4C47</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
