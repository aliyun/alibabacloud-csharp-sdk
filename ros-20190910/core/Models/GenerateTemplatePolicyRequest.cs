// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GenerateTemplatePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The options that control how the template access policy is generated. This parameter is of the LIST type. You can specify whether to resolve template parameters and the permission scope of the generated policy: 
        /// <b>ResolveParameters</b> indicates that the policy is generated after conditions and resources are resolved based on the specified Parameters or parameter default values.</para>
        /// <para><b>IgnoreParameters</b> indicates that the policy is generated without resolving parameters, using the legacy logic.</para>
        /// <para><b>MandatoryPolicy</b> indicates that only the minimum permissions required for template execution are generated.</para>
        /// <para><b>FullPolicy</b> indicates that a full access policy is generated.</para>
        /// <para>ResolveParameters and IgnoreParameters are mutually exclusive. MandatoryPolicy and FullPolicy are mutually exclusive. MandatoryPolicy must be used together with ResolveParameters.</para>
        /// <para>If this parameter is not specified, ResolveParameters + FullPolicy is used by default when Parameters is specified. Otherwise, IgnoreParameters + FullPolicy is used by default.</para>
        /// </summary>
        [NameInMap("GenerateOptions")]
        [Validation(Required=false)]
        public List<string> GenerateOptions { get; set; }

        /// <summary>
        /// <para>The operation types for which policy information is generated.</para>
        /// </summary>
        [NameInMap("OperationTypes")]
        [Validation(Required=false)]
        public List<string> OperationTypes { get; set; }

        /// <summary>
        /// <para>The input parameters. The input parameters define the parameters that must be specified when you create a stack by using this template. These parameters specify the details of each stack creation, such as the username, password, and environment-specific ECS instance types.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<GenerateTemplatePolicyRequestParameters> Parameters { get; set; }
        public class GenerateTemplatePolicyRequestParameters : TeaModel {
            /// <summary>
            /// <para>The name of the parameter. If you do not specify the name and value of a parameter defined in the template, Resource Orchestration Service (ROS) uses the default value specified in the template.<br>Maximum value of N: 200.
            /// Example values:</para>
            /// <list type="bullet">
            /// <item><description><para>Parameters.1.ParameterKey: <c>Name</c>.</para>
            /// </description></item>
            /// <item><description><para>Parameters.2.ParameterKey: <c>Netmode</c>.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Parameters is optional. If you specify Parameters, you must specify both Parameters.N.ParameterKey and Parameters.N.ParameterValue.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Domain</para>
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// <para>The value of the parameter defined in the template. Maximum value of N: 200.  </para>
            /// <remarks>
            /// <para>Parameters is optional. If you specify Parameters, Parameters.N.ParameterValue is required.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>PostPaid</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// <para>The structure of the template body. The length is 1 to 524,288 bytes.
        /// If the length is large, we recommend that you use the HTTP POST method and include the parameter in the request body to avoid request failures caused by an excessively long URL.  </para>
        /// <para>You can specify only one of the following parameters: TemplateBody, TemplateURL, and TemplateId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ROSTemplateFormatVersion&quot;:&quot;2015-09-01&quot;}</para>
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The template ID. Shared templates and private templates are supported.<br>You can specify only one of the following parameters: TemplateBody, TemplateURL, and TemplateId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5ecd1e10-b0e9-4389-a565-e4c15efc****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The URL of the file that contains the template body. The URL must point to a template that is located on a web server (HTTP or HTTPS) or in an OSS bucket, such as oss://ros/template/demo or oss://ros/template/demo?RegionId=ap-southeast-1. The maximum size of the template is 524,288 bytes.</para>
        /// <remarks>
        /// <para>If the OSS region is not specified, the region specified by the RegionId parameter is used by default.</para>
        /// </remarks>
        /// <para>You can specify only one of the following parameters: TemplateBody, TemplateURL, and TemplateId.
        /// Maximum length: 1,024 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros/template/demo</para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// <para>The template version. This parameter takes effect only when TemplateId is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
