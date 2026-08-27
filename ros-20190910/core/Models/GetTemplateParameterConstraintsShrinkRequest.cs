// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateParameterConstraintsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>A client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can be up to 64 characters in length, and can contain letters, digits, hyphens (-), and underscores (_). For more information, refer to <a href="https://help.aliyun.com/document_detail/134212.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The parameters that are defined in the template.</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public List<GetTemplateParameterConstraintsShrinkRequestParameters> Parameters { get; set; }
        public class GetTemplateParameterConstraintsShrinkRequestParameters : TeaModel {
            /// <summary>
            /// <para>The name of the parameter that is defined in the template.</para>
            /// <remarks>
            /// <para>The Parameters parameter is optional. If you specify Parameters, you must specify ParameterKey.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ZoneInfo</para>
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// <para>The value of the parameter that is defined in the template.</para>
            /// <remarks>
            /// <para>The Parameters parameter is optional. If you specify Parameters, you must specify ParameterValue.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-h</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// <para>The list of parameters to be queried.</para>
        /// </summary>
        [NameInMap("ParametersKeyFilter")]
        [Validation(Required=false)]
        public string ParametersKeyFilterShrink { get; set; }

        /// <summary>
        /// <para>The dependency of the parameters.</para>
        /// </summary>
        [NameInMap("ParametersOrder")]
        [Validation(Required=false)]
        public string ParametersOrderShrink { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the stack.</para>
        /// <para>If you specify this parameter, the parameter constraints for an upgrade or downgrade scenario are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c754d2a4-28f1-46df-b557-9586173a****</para>
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// <para>The structure of the template body. The template body must be 1 to 524,288 bytes in length. If the length of the template body exceeds the upper limit, we recommended to use the HTTP POST + Body Param method to pass the parameter in the request body to avoid request failures caused by an excessively long URL.</para>
        /// <remarks>
        /// <para>You can specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, and TemplateScratchId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///   &quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;,
        ///   &quot;Parameters&quot;: {
        ///     &quot;ZoneInfo&quot;: {
        ///       &quot;Type&quot;: &quot;String&quot;
        ///     },
        ///     &quot;InstanceType&quot;: {
        ///       &quot;Type&quot;: &quot;String&quot;
        ///     }
        ///   },
        ///   &quot;Resources&quot;: {
        ///     &quot;ECS&quot;: {
        ///       &quot;Type&quot;: &quot;ALIYUN::ECS::Instance&quot;,
        ///       &quot;Properties&quot;: {
        ///         &quot;ZoneId&quot;: {
        ///           &quot;Ref&quot;: &quot;ZoneInfo&quot;
        ///         },
        ///         &quot;InstanceType&quot;: {
        ///           &quot;Ref&quot;: &quot;InstanceType&quot;
        ///         }
        ///       }
        ///     }
        ///   }
        /// }</para>
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The ID of the template. This parameter applies to shared templates and private templates.</para>
        /// <remarks>
        /// <para>You can specify only one of the TemplateBody, TemplateURL, and TemplateId parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5ecd1e10-b0e9-4389-a565-e4c15efc****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an Alibaba Cloud OSS bucket, such as oss\://ros/template/demo or oss\://ros/template/demo?RegionId=cn-hangzhou. The template must be 1 to 524,288 bytes in length. If the OSS region is not specified, the default is the same as the RegionId parameter.</para>
        /// <remarks>
        /// <para>You can specify only one of the TemplateBody, TemplateURL, and TemplateId parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros-template/demo</para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// <para>The version of the template. If you do not specify this parameter, the latest version is used.</para>
        /// <remarks>
        /// <para>TemplateVersion is valid only when TemplateId is specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
