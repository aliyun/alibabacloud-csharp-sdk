// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GetStackGroupRequest : TeaModel {
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
        /// <para>The ID of the stack group.</para>
        /// <remarks>
        /// <para>You must specify only one of the StackGroupName and StackGroupId parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>fd0ddef9-9540-4b42-a464-94f77835****</para>
        /// </summary>
        [NameInMap("StackGroupId")]
        [Validation(Required=false)]
        public string StackGroupId { get; set; }

        /// <summary>
        /// <para>The name of the stack group. The name must be unique within a region. The name can be up to 255 characters in length, and must start with a digit or a letter. It can contain digits, letters, hyphens (-), and underscores (_).</para>
        /// <remarks>
        /// <para>You must specify only one of the StackGroupName and StackGroupId parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MyStackGroup</para>
        /// </summary>
        [NameInMap("StackGroupName")]
        [Validation(Required=false)]
        public string StackGroupName { get; set; }

    }

}
