// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackOperationRisksRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can be up to 64 characters in length, and can contain letters, digits, hyphens (-), and underscores (_). For more information, see <a href="https://help.aliyun.com/document_detail/134212.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The type of the operation of which you want to detect risks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DeleteStack: detects high risks that may arise in resources when you delete a stack.</description></item>
        /// <item><description>CreateStack: detects the missing permissions when you fail to create a stack.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DeleteStack</para>
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        /// <summary>
        /// <para>The name of the RAM role.</para>
        /// <list type="bullet">
        /// <item><description>If you specify a RAM role, ROS creates stacks based on the permissions that are granted to the RAM role and uses the credentials of the RAM role to call the API operations of Alibaba Cloud services.</description></item>
        /// <item><description>If you do not specify a RAM role, ROS creates stacks based on the permissions of your Alibaba Cloud account.</description></item>
        /// </list>
        /// <para>The name of the RAM role can be up to 64 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-role</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The region ID of the stack. You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to retain all resources in the stack. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only if you set OperationType to DeleteStack.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RetainAllResources")]
        [Validation(Required=false)]
        public bool? RetainAllResources { get; set; }

        /// <summary>
        /// <para>The list of resources to retain.</para>
        /// <remarks>
        /// <para>This parameter takes effect only if you set OperationType to DeleteStack.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>WebServer</para>
        /// </summary>
        [NameInMap("RetainResources")]
        [Validation(Required=false)]
        public List<string> RetainResources { get; set; }

        /// <summary>
        /// <para>The ID of the stack.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</para>
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The ID of the template. This parameter applies to shared and private templates.</para>
        /// <remarks>
        /// <para>You must specify one of TemplateBody, TemplateURL, TemplateId, and TemplateScratchId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5ecd1e10-b0e9-4389-a565-e4c15efc****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an Object Storage Service (OSS) bucket, such as oss://ros/stack-policy/demo and oss://ros/stack-policy/demo?RegionId=cn-hangzhou. The template body can be up to 524,288 bytes in length. If you do not specify RegionId in the URL, the region ID of the stack is used.</para>
        /// <remarks>
        /// <para>You must specify one of TemplateBody, TemplateURL, TemplateId, and TemplateScratchId.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros-template/demo</para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// <para>The version of the template.</para>
        /// <remarks>
        /// <para>This parameter takes effect only if you specify TemplateId.</para>
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
