// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class BatchAddFeishuUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D8749D65-E80A-433C-AF1B-CE9C180FF3B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Result of adding members to the user group. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>true: Addition successful</description></item>
        /// <item><description>false: Addition failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public BatchAddFeishuUsersResponseBodyResult Result { get; set; }
        public class BatchAddFeishuUsersResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Number of failed validations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public int? FailCount { get; set; }

            /// <summary>
            /// <para>Details of the failures.</para>
            /// </summary>
            [NameInMap("FailResults")]
            [Validation(Required=false)]
            public List<BatchAddFeishuUsersResponseBodyResultFailResults> FailResults { get; set; }
            public class BatchAddFeishuUsersResponseBodyResultFailResults : TeaModel {
                /// <summary>
                /// <para>Reasons for errors.</para>
                /// </summary>
                [NameInMap("FailInfos")]
                [Validation(Required=false)]
                public List<BatchAddFeishuUsersResponseBodyResultFailResultsFailInfos> FailInfos { get; set; }
                public class BatchAddFeishuUsersResponseBodyResultFailResultsFailInfos : TeaModel {
                    /// <summary>
                    /// <para>Error code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACCOUNT_EXIST</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>Description of the error code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TEST</para>
                    /// </summary>
                    [NameInMap("CodeDesc")]
                    [Validation(Required=false)]
                    public string CodeDesc { get; set; }

                    /// <summary>
                    /// <para>Incorrect input value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Input")]
                    [Validation(Required=false)]
                    public string Input { get; set; }

                }

            }

            /// <summary>
            /// <para>Count of successes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OkCount")]
            [Validation(Required=false)]
            public int? OkCount { get; set; }

        }

        /// <summary>
        /// <para>Whether the request was successful. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>true: Request successful</description></item>
        /// <item><description>false: Request failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
