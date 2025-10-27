// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class CreateFlowResponseBody : TeaModel {
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
        /// <para>Considering compatibility, the system supports two flow definition specifications.</para>
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
        public CreateFlowResponseBodyEnvironment Environment { get; set; }
        public class CreateFlowResponseBodyEnvironment : TeaModel {
            [NameInMap("Variables")]
            [Validation(Required=false)]
            public List<CreateFlowResponseBodyEnvironmentVariables> Variables { get; set; }
            public class CreateFlowResponseBodyEnvironmentVariables : TeaModel {
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
        /// <para>The execution mode. Valid values: Express and Standard. Considering compatibility, an empty string is equivalent to the Standard execution mode.</para>
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
        /// <para>e589e092-e2c0-4dee-b306-3574ddfdddf5****</para>
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
        /// <para>The request ID. Each time an <c>HTTP status code</c> is returned, Serverless Workflow returns a value for the parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testRequestID</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud resource name (ARN) of the authorized role on which the execution of the flow relies. During the execution of the flow, CloudFlow assumes the role to call API operations of relevant services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram:${region}:${accountID}:${role}</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The type of the flow.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description><para>FDL</para>
        /// <!-- -->
        /// 
        /// <!-- -->
        /// 
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FDL</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
