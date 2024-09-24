// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to return the Outputs parameter. The Outputs parameter specifies the outputs of the stack. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: returns the Outputs parameter.</description></item>
        /// <item><description>Disabled (default): does not return the Outputs parameter.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The Outputs parameter requires a long period of time to calculate. If you do not require the outputs of the stack, we recommend that you set OutputOption to Disabled to improve the response speed of the API operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Disabled</para>
        /// </summary>
        [NameInMap("OutputOption")]
        [Validation(Required=false)]
        public string OutputOption { get; set; }

        /// <summary>
        /// <para>The region ID of the stack group. You can call the <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The name of the stack group. The name must be unique within a region.\
        /// The name can be up to 255 characters in length, and can contain digits, letters, hyphens (-), and underscores (_). It must start with a digit or letter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyStackGroup</para>
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

        /// <summary>
        /// <para>The ID of the destination account to which the stack belongs.</para>
        /// <list type="bullet">
        /// <item><description>If the stack group is granted self-managed permissions, the stack belongs to an Alibaba Cloud account.</description></item>
        /// <item><description>If the stack group is granted service-managed permissions, the stack belongs to a member in a resource directory.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about the destination account, see <a href="https://help.aliyun.com/document_detail/154578.html">Overview</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>151266687691****</para>
        /// </summary>
        [NameInMap("StackInstanceAccountId")]
        [Validation(Required=false)]
        public string StackInstanceAccountId { get; set; }

        /// <summary>
        /// <para>The region ID of the stack.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("StackInstanceRegionId")]
        [Validation(Required=false)]
        public string StackInstanceRegionId { get; set; }

    }

}
