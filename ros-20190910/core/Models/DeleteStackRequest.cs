// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class DeleteStackRequest : TeaModel {
        /// <summary>
        /// <para>Stack deletion options.</para>
        /// </summary>
        [NameInMap("DeleteOptions")]
        [Validation(Required=false)]
        public List<string> DeleteOptions { get; set; }

        /// <summary>
        /// <para>Maximum number of concurrent resource operations.</para>
        /// <para>Default: empty. Accepts an integer &gt;= 0.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>A value greater than 0 is used as-is. A value of 0 or empty imposes no limit on ROS stacks. For Terraform stacks, the Terraform default (typically 10) applies.</para>
        /// </description></item>
        /// <item><description><para>This value persists on the stack and affects subsequent operations such as updates.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Parallelism")]
        [Validation(Required=false)]
        public long? Parallelism { get; set; }

        /// <summary>
        /// <para>The RAM role name. ROS assumes this role to create the stack and call Alibaba Cloud service APIs.<br> Even if you have stack operation permissions but lack RAM role permissions, ROS still assumes the role. Ensure the role follows the least-privilege principle.<br> If empty, ROS cannot assume the existing RAM role associated with the stack. To have ROS assume a role, specify this parameter. If no RAM role is available, ROS uses a temporary credential from your account credentials.<br> Maximum length: 64 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-role</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The region ID of the stack. Call <a href="https://help.aliyun.com/document_detail/131035.html">DescribeRegions</a> to query available regions.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Whether to retain all resources in the stack.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true</para>
        /// </description></item>
        /// <item><description><para>false (default)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RetainAllResources")]
        [Validation(Required=false)]
        public bool? RetainAllResources { get; set; }

        /// <summary>
        /// <para>Resources to retain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WebServer</para>
        /// </summary>
        [NameInMap("RetainResources")]
        [Validation(Required=false)]
        public List<string> RetainResources { get; set; }

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

    }

}
