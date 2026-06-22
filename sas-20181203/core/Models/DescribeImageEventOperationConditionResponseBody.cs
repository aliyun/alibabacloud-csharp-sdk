// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageEventOperationConditionResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code of the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeImageEventOperationConditionResponseBodyData Data { get; set; }
        public class DescribeImageEventOperationConditionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The alerting type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>sensitiveFile</b>: sensitive file.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sensitiveFile</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>The list of operations.</para>
            /// </summary>
            [NameInMap("Operations")]
            [Validation(Required=false)]
            public List<DescribeImageEventOperationConditionResponseBodyDataOperations> Operations { get; set; }
            public class DescribeImageEventOperationConditionResponseBodyDataOperations : TeaModel {
                /// <summary>
                /// <para>The rule conditions.</para>
                /// </summary>
                [NameInMap("Conditions")]
                [Validation(Required=false)]
                public List<DescribeImageEventOperationConditionResponseBodyDataOperationsConditions> Conditions { get; set; }
                public class DescribeImageEventOperationConditionResponseBodyDataOperationsConditions : TeaModel {
                    /// <summary>
                    /// <para>The condition key. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>MD5</b>: MD5.</description></item>
                    /// <item><description><b>PATH</b>: path.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MD5</para>
                    /// </summary>
                    [NameInMap("ConditionKey")]
                    [Validation(Required=false)]
                    public string ConditionKey { get; set; }

                    /// <summary>
                    /// <para>The condition name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MD5</para>
                    /// </summary>
                    [NameInMap("ConditionName")]
                    [Validation(Required=false)]
                    public string ConditionName { get; set; }

                    /// <summary>
                    /// <para>The match type.</para>
                    /// </summary>
                    [NameInMap("SupportedMisType")]
                    [Validation(Required=false)]
                    public List<string> SupportedMisType { get; set; }

                }

                /// <summary>
                /// <para>The operation code. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>whitelist</b>: whitelist.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>whitelist</para>
                /// </summary>
                [NameInMap("OperationCode")]
                [Validation(Required=false)]
                public string OperationCode { get; set; }

                /// <summary>
                /// <para>The operation name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>whitelist</para>
                /// </summary>
                [NameInMap("OperationName")]
                [Validation(Required=false)]
                public string OperationName { get; set; }

            }

            /// <summary>
            /// <para>The rule scope.</para>
            /// </summary>
            [NameInMap("Scenarios")]
            [Validation(Required=false)]
            public List<string> Scenarios { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ADE57832-9666-511C-9A80-B87DE2E8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The call was successful.</description></item>
        /// <item><description><b>false</b>: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
