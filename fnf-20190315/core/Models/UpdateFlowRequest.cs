// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class UpdateFlowRequest : TeaModel {
        /// <summary>
        /// <para>The definition of the workflow. The definition must comply with the flow definition language (FDL) syntax. Considering compatibility, the system supports the two workflow definition specifications.</para>
        /// <remarks>
        /// <para> In the preceding workflow definition example, Name:my_flow_name is the workflow name, which must be consistent with the input parameter Name</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>version: v1.0\ntype: flow\nname: test\nsteps:\n  - type: pass\n    name: mypass</para>
        /// </summary>
        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        /// <summary>
        /// <para>The description of the flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test definition</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Environment")]
        [Validation(Required=false)]
        public UpdateFlowRequestEnvironment Environment { get; set; }
        public class UpdateFlowRequestEnvironment : TeaModel {
            [NameInMap("Variables")]
            [Validation(Required=false)]
            public List<UpdateFlowRequestEnvironmentVariables> Variables { get; set; }
            public class UpdateFlowRequestEnvironmentVariables : TeaModel {
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
        /// <para>The name of the workflow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flow</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud resource name (ARN) of the authorized role on which the execution of the flow relies. During the execution of the flow, the flow execution engine assumes the role to call API operations of relevant services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::${accountID}:${role}</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The type of the flow. Valid value: <b>FDL</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FDL</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
