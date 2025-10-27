// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class ListFlowsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of flows.</para>
        /// </summary>
        [NameInMap("Flows")]
        [Validation(Required=false)]
        public List<ListFlowsResponseBodyFlows> Flows { get; set; }
        public class ListFlowsResponseBodyFlows : TeaModel {
            /// <summary>
            /// <para>The time when the flow was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-01T01:01:01.001Z</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The definition of the flow. The definition must comply with the Flow Definition Language (FDL) syntax.</para>
            /// 
            /// <b>Example:</b>
            /// <para>version: v1.0\ntype: flow\nname: test\nsteps:\n - type: pass\n name: mypass</para>
            /// </summary>
            [NameInMap("Definition")]
            [Validation(Required=false)]
            public string Definition { get; set; }

            /// <summary>
            /// <para>The description of the flow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test flow</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Environment")]
            [Validation(Required=false)]
            public ListFlowsResponseBodyFlowsEnvironment Environment { get; set; }
            public class ListFlowsResponseBodyFlowsEnvironment : TeaModel {
                [NameInMap("Variables")]
                [Validation(Required=false)]
                public List<ListFlowsResponseBodyFlowsEnvironmentVariables> Variables { get; set; }
                public class ListFlowsResponseBodyFlowsEnvironmentVariables : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>description</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>key</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>value</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The execution mode or the enumeration type. Valid values: Express and Standard. A value of Standard indicates an empty string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("ExecutionMode")]
            [Validation(Required=false)]
            public string ExecutionMode { get; set; }

            /// <summary>
            /// <para>The unique ID of the flow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e589e092-e2c0-4dee-b306-3574ddf5****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The time when the flow was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-01-01T01:01:01.001Z</para>
            /// </summary>
            [NameInMap("LastModifiedTime")]
            [Validation(Required=false)]
            public string LastModifiedTime { get; set; }

            /// <summary>
            /// <para>The name of the flow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>flow</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud resource name (ARN) of the specified Resource Access Management (RAM) role that Serverless Workflow assumes to invoke resources when the flow is executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:ram::${accountID}:${role}</para>
            /// </summary>
            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// <para>The type of the flow.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FDL</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The start key for the next query. This parameter is not returned if all results have been returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flow_nextxxx</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testRequestId</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
