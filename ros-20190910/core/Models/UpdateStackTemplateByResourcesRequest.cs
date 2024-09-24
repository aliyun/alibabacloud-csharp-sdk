// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class UpdateStackTemplateByResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that it is unique among different requests.</para>
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
        /// <para>Specifies whether to only preview the corrected template in this request. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: returns the content of the corrected template and does not correct the template. After Resource Orchestration Service (ROS) compares the corrected template with the original template, ROS determines whether to execute the correction.</description></item>
        /// <item><description>false: corrects the template to eliminate drift.</description></item>
        /// </list>
        /// <remarks>
        /// <para> We recommend that you set the DryRun parameter to true to preview the corrected template. If the template content meets expectations, set the DryRun parameter to false to execute the correction.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The logical ID of resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Vpc</para>
        /// </summary>
        [NameInMap("LogicalResourceId")]
        [Validation(Required=false)]
        public List<string> LogicalResourceId { get; set; }

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
        /// <para>The ID of the stack.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4a6c9851-3b0f-4f5f-b4ca-a14bf691****</para>
        /// </summary>
        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        /// <summary>
        /// <para>The format of the returned template. Default value: JSON. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>JSON</description></item>
        /// <item><description>YAML</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>JSON</para>
        /// </summary>
        [NameInMap("TemplateFormat")]
        [Validation(Required=false)]
        public string TemplateFormat { get; set; }

    }

}
