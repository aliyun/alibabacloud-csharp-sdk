// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetTemplateSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the change set.</para>
        /// <para>You can specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, StackId, ChangeSetId, and StackGroupName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1f6521a4-05af-4975-afe9-bc4b45ad****</para>
        /// </summary>
        [NameInMap("ChangeSetId")]
        [Validation(Required=false)]
        public string ChangeSetId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.\
        /// The token can be up to 64 characters in length, and can contain letters, digits, hyphens (-), and underscores (_).\
        /// For more information, see <a href="https://help.aliyun.com/document_detail/134212.html">Ensure idempotence</a>.</para>
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
        public List<GetTemplateSummaryRequestParameters> Parameters { get; set; }
        public class GetTemplateSummaryRequestParameters : TeaModel {
            /// <summary>
            /// <para>The name of parameter N that is defined in the template. If you do not specify the name and value of a parameter, Resource Orchestration Service (ROS) uses the default name and value that are defined in the template.</para>
            /// <para>Maximum value of N: 200.</para>
            /// <remarks>
            /// <para>The Parameters parameter is optional. If you specify Parameters, you must specify both Parameters.N.ParameterKey and Parameters.N.ParameterValue.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>InstanceId</para>
            /// </summary>
            [NameInMap("ParameterKey")]
            [Validation(Required=false)]
            public string ParameterKey { get; set; }

            /// <summary>
            /// <para>The value of parameter N that is defined in the template.</para>
            /// <para>Maximum value of N: 200.</para>
            /// <remarks>
            /// <para>The Parameters parameter is optional. If you specify Parameters, you must specify both Parameters.N.ParameterKey and Parameters.N.ParameterValue.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>i-rotp2e20whfrs2****</para>
            /// </summary>
            [NameInMap("ParameterValue")]
            [Validation(Required=false)]
            public string ParameterValue { get; set; }

        }

        /// <summary>
        /// <para>The region ID of the stack or stack group that uses the template. You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter takes effect only when one of the following parameters are specified: StackId, ChangeSetId, and StackGroupName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the stack group.</para>
        /// <para>You can specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, StackId, ChangeSetId, and StackGroupName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-stack-group</para>
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

        /// <summary>
        /// <para>The stack ID.</para>
        /// <para>You can specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, StackId, ChangeSetId, and StackGroupName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</para>
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// <para>The structure that contains the template body. The template body must be 1 to 524,288 bytes in length.\
        /// If the length of the template body exceeds the upper limit, we recommend that you add parameters to the HTTP POST request body to prevent request failures caused by excessively long URLs.\
        /// You can specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, StackId, ChangeSetId, and StackGroupName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ROSTemplateFormatVersion&quot;:&quot;2015-09-01&quot;}</para>
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The template ID. This parameter applies to shared and private templates.</para>
        /// <para>You can specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, StackId, ChangeSetId, and StackGroupName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5ecd1e10-b0e9-4389-a565-e4c15efc****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an Object Storage Service (OSS) bucket, such as oss://ros/template/demo or oss://ros/template/demo?RegionId=cn-hangzhou. The template body can be up to 524,288 bytes in length.</para>
        /// <remarks>
        /// <para>If you do not specify the region ID of the OSS bucket, the value of RegionId is used.</para>
        /// </remarks>
        /// <para>You can specify only one of the following parameters: TemplateBody, TemplateURL, TemplateId, StackId, ChangeSetId, and StackGroupName.</para>
        /// <para>The URL can be up to 1,024 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros/template/demo</para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// <para>The version of the template. This parameter takes effect when TemplateId is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
