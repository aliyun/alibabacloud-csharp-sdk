// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appflow20230904.Models
{
    public class CreateFlowRequest : TeaModel {
        /// <summary>
        /// <para>The description of the flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>在钉钉中使用OpenClaw(MoltBot、MoltBot)</para>
        /// </summary>
        [NameInMap("FlowDesc")]
        [Validation(Required=false)]
        public string FlowDesc { get; set; }

        /// <summary>
        /// <para>The ID of the flow. This parameter is required when you update a flow or create a new flow version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>flow-647da8e366a74d1cab6e</para>
        /// </summary>
        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

        /// <summary>
        /// <para>The name of the flow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>企业微信自建应用大模型自动回复</para>
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// <para>The content of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;FormatVersion&quot;: &quot;appflow-2025-07-01&quot;,
        ///   &quot;Nodes&quot;: [</para>
        /// <pre><c> ]
        /// </c></pre>
        /// <para>}</para>
        /// </summary>
        [NameInMap("FlowTemplate")]
        [Validation(Required=false)]
        public string FlowTemplate { get; set; }

        /// <summary>
        /// <para>The publication status of the flow: True for published, False for unpublished.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("LaunchStatus")]
        [Validation(Required=false)]
        public bool? LaunchStatus { get; set; }

        /// <summary>
        /// <para>The parameters for the template.</para>
        /// <para>You can specify up to 200 parameters.</para>
        /// <remarks>
        /// <para>This parameter is optional. If you use this parameter, you must specify both ParameterKey and ParameterValue for each entry.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<CreateFlowRequestParameters> Parameters { get; set; }
        public class CreateFlowRequestParameters : TeaModel {
            /// <summary>
            /// <para>The name of a parameter defined in the template. If no parameter name or value is specified, ROS uses the default value defined in the template.</para>
            /// <para>The maximum value of N is 200.<br>
            /// The name must be 1 to 128 characters in length, cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <remarks>
            /// <para>Parameters is optional. If you specify Parameters, you must specify both Parameters.N.ParameterKey and Parameters.N.ParameterValue.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>dingdingAuthId</para>
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// <para>The value for the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>uac-xxxxxxx</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// <para>The object tags to which the rule applies. You can specify multiple tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateFlowRequestTag> Tag { get; set; }
        public class CreateFlowRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can filter the cluster list by tag. You can specify up to 20 tag pairs. The number N in each tag pair must be unique and a consecutive integer starting from 1. The value corresponding to <c>Tag.N.Key</c> is <c>Tag.N.Value</c>.</para>
            /// <remarks>
            /// <para>The tag key can be up to 64 characters long and cannot start with <c>aliyun</c>, <c>acs:</c>, <c>http://</c>, or <c>https://</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>CreateBy</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The authentication content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zhangsan</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the template. Specify this parameter when you create a flow from a template in the Template Center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tl-715d93e708b546b7b464</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
