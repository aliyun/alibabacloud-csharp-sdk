// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ResetDesktopsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud computer pool. If you specify the <c>DesktopId</c> parameter, ignore the <c>DesktopGroupId</c> parameter. If you do not specify the <c>DesktopId</c> parameter, specify the <c>DesktopGroupId</c> parameter in the call to request all IDs of the cloud computers in the specified pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dg-07if7qsxoxkb6****</para>
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of the cloud computer pools.</para>
        /// </summary>
        [NameInMap("DesktopGroupIds")]
        [Validation(Required=false)]
        public List<string> DesktopGroupIds { get; set; }

        /// <summary>
        /// <para>The IDs of the cloud computers. You can specify the IDs of 1 to 100 cloud computers.</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// <para>The ID of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-4zfb6zj728hhr****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// <remarks>
        /// <para>This parameter is available only when you reset cloud computer pools. If you leave this parameter empty, all cloud computers in the specified cloud computer pool are reset, regardless of how the cloud computers are billed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/436773.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The reset scope. You can configure this parameter to reset the image or cloud computer.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ALL (default): resets the image and cloud computer.</description></item>
        /// <item><description>IMAGE: resets only the image.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("ResetScope")]
        [Validation(Required=false)]
        public string ResetScope { get; set; }

        /// <summary>
        /// <para>The disk reset type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: does not reset disks.</description></item>
        /// <item><description>1: resets only the system disk.</description></item>
        /// <item><description>2: resets only the user disk.</description></item>
        /// <item><description>3: resets the system disk and the user disk.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ResetType")]
        [Validation(Required=false)]
        public string ResetType { get; set; }

    }

}
