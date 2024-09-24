// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CancelUpdateStackRequest : TeaModel {
        /// <summary>
        /// <para>The method to cancel the update operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Quick: cancels the update of a stack as soon as possible.</description></item>
        /// <item><description>Safe: cancels the update of a stack as safely as possible.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Safe</para>
        /// </summary>
        [NameInMap("CancelType")]
        [Validation(Required=false)]
        public string CancelType { get; set; }

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

    }

}
