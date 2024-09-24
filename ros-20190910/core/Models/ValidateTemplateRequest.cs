// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ValidateTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.</para>
        /// <para>The token can be up to 64 characters in length, and can contain letters, digits, hyphens (-), and underscores (_).</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/134212.html">Ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The region ID of the template. You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP web server or in an Object Storage Service (OSS) bucket, such as oss://ros/template/demo or oss://ros/template/demo?RegionId=cn-hangzhou. The template body can be up to 524,288 bytes in length.</para>
        /// <remarks>
        /// <para>If you do not specify the region ID of the OSS bucket, the value of RegionId is used.</para>
        /// </remarks>
        /// <para>You can specify one of TemplateBody and TemplateURL, but not both of them. The URL can be up to 1,024 bytes in length.\</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros/template/demo</para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// <para>The options that are used to control the generation of information about the stack update. You can specify up to two options.</para>
        /// </summary>
        [NameInMap("UpdateInfoOptions")]
        [Validation(Required=false)]
        public List<string> UpdateInfoOptions { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable additional validation for the template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>None (default): does not enable additional validation.</description></item>
        /// <item><description>EnableTerraformValidation: runs the <c>terraform validate</c> command in the Terraform CLI to enable additional validation for a Terraform template.</description></item>
        /// <item><description>EnableFastTerraformValidation: runs a command that is similar to the <c>terraform validate</c> command in the Terraform CLI to enable additional validation for a Terraform template.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Compared with the EnableTerraformValidation method, the EnableFastTerraformValidation method validates a template at a faster speed but a lower integrity level.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("ValidationOption")]
        [Validation(Required=false)]
        public string ValidationOption { get; set; }

    }

}
