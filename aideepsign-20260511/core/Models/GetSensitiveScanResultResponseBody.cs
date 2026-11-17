// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIDeepSign20260511.Models
{
    public class GetSensitiveScanResultResponseBody : TeaModel {
        /// <summary>
        /// <para>The business error code. If the request is successful, &quot;OK&quot; is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code. If the request is successful, 200 is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The additional information. If the request is successful, &quot;success&quot; is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1B2C3D4-E5F6-7890-ABCD-EF1234567890</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The scan results. This parameter is returned only when the task status is <c>completed</c>.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetSensitiveScanResultResponseBodyResult Result { get; set; }
        public class GetSensitiveScanResultResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The scan object name.</para>
            /// </summary>
            [NameInMap("OssObjectDetail")]
            [Validation(Required=false)]
            public GetSensitiveScanResultResponseBodyResultOssObjectDetail OssObjectDetail { get; set; }
            public class GetSensitiveScanResultResponseBodyResultOssObjectDetail : TeaModel {
                /// <summary>
                /// <para><b>The name of the bucket to which the object belongs.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>aideepsign-bucket</para>
                /// </summary>
                [NameInMap("BucketName")]
                [Validation(Required=false)]
                public string BucketName { get; set; }

                /// <summary>
                /// <para><b>The sensitive data category name.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>Personal information</para>
                /// </summary>
                [NameInMap("CategoryName")]
                [Validation(Required=false)]
                public string CategoryName { get; set; }

                /// <summary>
                /// <para><b>The name of the scanned object.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>abc12345.jpg</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para><b>The overall risk level name.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>S2</para>
                /// </summary>
                [NameInMap("RiskLevelName")]
                [Validation(Required=false)]
                public string RiskLevelName { get; set; }

                /// <summary>
                /// <para>The list of matched sensitive data rules.</para>
                /// </summary>
                [NameInMap("RuleList")]
                [Validation(Required=false)]
                public List<GetSensitiveScanResultResponseBodyResultOssObjectDetailRuleList> RuleList { get; set; }
                public class GetSensitiveScanResultResponseBodyResultOssObjectDetailRuleList : TeaModel {
                    /// <summary>
                    /// <para>The category name of the rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Personal information</para>
                    /// </summary>
                    [NameInMap("CategoryName")]
                    [Validation(Required=false)]
                    public string CategoryName { get; set; }

                    /// <summary>
                    /// <para>The number of hits.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public int? Count { get; set; }

                    /// <summary>
                    /// <para>The risk level name of the rule.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>S2</para>
                    /// </summary>
                    [NameInMap("RiskLevelName")]
                    [Validation(Required=false)]
                    public string RiskLevelName { get; set; }

                    /// <summary>
                    /// <para>The rule name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ID card number</para>
                    /// </summary>
                    [NameInMap("RuleName")]
                    [Validation(Required=false)]
                    public string RuleName { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The task status. Valid values: <c>running</c> (running), <c>completed</c> (completed), and <c>terminated</c> (terminated or failed).</para>
        /// 
        /// <b>Example:</b>
        /// <para>completed</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
