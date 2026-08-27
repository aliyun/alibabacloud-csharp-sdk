// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ValidateTemplateRequest : TeaModel {
        /// <summary>
        /// <para>A client token that is used to ensure the idempotence of the request. The client generates the value, which must be unique.</para>
        /// <para>The token can be up to 64 characters in length and can contain letters, digits, hyphens (-), and underscores (_).</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/134212.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The region ID of the stack template. You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent list of Alibaba Cloud regions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The structure of the template body. The template body can be 1 to 524,288 bytes in length.<br>If the template body is long, use a POST request and place the parameter in the request body. This prevents a request failure caused by an excessively long URL.<br>You can specify either TemplateBody or TemplateURL, but not both.<br><br></para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ROSTemplateFormatVersion&quot;:&quot;2015-09-01&quot;}</para>
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The location of the file that contains the template body. The URL must point to a template that is located on an HTTP web server or in an Alibaba Cloud OSS bucket, such as oss\://ros/template/demo or oss\://ros/template/demo?RegionId=cn-hangzhou. The template can be up to 524,288 bytes in size.</para>
        /// <remarks>
        /// <para>If you do not specify the region of the OSS bucket, the value of the RegionId parameter is used.</para>
        /// </remarks>
        /// <para>You can specify either TemplateBody or TemplateURL, but not both.<br>The URL can be up to 1,024 bytes in length.<br></para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros/template/demo</para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// <para>The list of options for the update information. The list can contain up to two options.</para>
        /// </summary>
        [NameInMap("UpdateInfoOptions")]
        [Validation(Required=false)]
        public List<string> UpdateInfoOptions { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable additional validation for the template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>None (default): No additional validation is enabled.</para>
        /// </description></item>
        /// <item><description><para>EnableTerraformValidation: For a Terraform template, the <c>terraform validate</c> command of the Terraform command-line interface (CLI) is used to enable additional validation.</para>
        /// </description></item>
        /// <item><description><para>EnableFastTerraformValidation: For a Terraform template, a command that is similar to the <c>terraform validate</c> command of the Terraform CLI is used to enable additional validation.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Compared with EnableTerraformValidation, EnableFastTerraformValidation is faster but less comprehensive.</para>
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
