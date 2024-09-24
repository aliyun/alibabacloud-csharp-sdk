// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageEventOperationConditionResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
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
            /// <para>The alert type.</para>
            /// <list type="bullet">
            /// <item><description>Only <b>sensitiveFile</b> may be returned.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sensitiveFile</para>
            /// </summary>
            [NameInMap("EventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>The operations.</para>
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
                    /// <para>The keyword of the condition. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>MD5</b></description></item>
                    /// <item><description><b>PATH</b></description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MD5</para>
                    /// </summary>
                    [NameInMap("ConditionKey")]
                    [Validation(Required=false)]
                    public string ConditionKey { get; set; }

                    /// <summary>
                    /// <para>The name of the condition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MD5</para>
                    /// </summary>
                    [NameInMap("ConditionName")]
                    [Validation(Required=false)]
                    public string ConditionName { get; set; }

                    /// <summary>
                    /// <para>The matching types.</para>
                    /// </summary>
                    [NameInMap("SupportedMisType")]
                    [Validation(Required=false)]
                    public List<string> SupportedMisType { get; set; }

                }

                /// <summary>
                /// <para>The operation code.</para>
                /// <list type="bullet">
                /// <item><description>Only <b>whitelist</b> may be returned, which indicates that the alert event is added to the whitelist.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>whitelist</para>
                /// </summary>
                [NameInMap("OperationCode")]
                [Validation(Required=false)]
                public string OperationCode { get; set; }

                /// <summary>
                /// <para>The name of the operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>whitelist</para>
                /// </summary>
                [NameInMap("OperationName")]
                [Validation(Required=false)]
                public string OperationName { get; set; }

            }

            /// <summary>
            /// <para>The application scopes of the rules.</para>
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
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
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
