// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class BatchAddFeishuUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D8749D65-E80A-433C-AF1B-CE9C180FF3B4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the user group members are added. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: The user group members are added.</para>
        /// </description></item>
        /// <item><description><para>false: The user group members fail to be added.</para>
        /// </description></item>
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
            /// <para>The number of failures.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("FailCount")]
            [Validation(Required=false)]
            public int? FailCount { get; set; }

            /// <summary>
            /// <para>The details of the failures.</para>
            /// </summary>
            [NameInMap("FailResults")]
            [Validation(Required=false)]
            public List<BatchAddFeishuUsersResponseBodyResultFailResults> FailResults { get; set; }
            public class BatchAddFeishuUsersResponseBodyResultFailResults : TeaModel {
                /// <summary>
                /// <para>The causes of the errors.</para>
                /// </summary>
                [NameInMap("FailInfos")]
                [Validation(Required=false)]
                public List<BatchAddFeishuUsersResponseBodyResultFailResultsFailInfos> FailInfos { get; set; }
                public class BatchAddFeishuUsersResponseBodyResultFailResultsFailInfos : TeaModel {
                    /// <summary>
                    /// <para>The error code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACCOUNT_EXIST</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The description of the error code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("CodeDesc")]
                    [Validation(Required=false)]
                    public string CodeDesc { get; set; }

                    /// <summary>
                    /// <para>The invalid input value.</para>
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
            /// <para>The number of successes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OkCount")]
            [Validation(Required=false)]
            public int? OkCount { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
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
