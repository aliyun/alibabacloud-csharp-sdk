// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ResetDesktopsRequest : TeaModel {
        /// <summary>
        /// <para>The shared cloud computer ID.</para>
        /// <list type="bullet">
        /// <item><description>If DesktopId is specified, DesktopGroupId is ignored.</description></item>
        /// <item><description>If DesktopId is empty, the system retrieves the DesktopId of all cloud computers within the shared cloud computer based on DesktopGroupId.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dg-07if7qsxoxkb6****</para>
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// <para>The shared cloud computer IDs.</para>
        /// </summary>
        [NameInMap("DesktopGroupIds")]
        [Validation(Required=false)]
        public List<string> DesktopGroupIds { get; set; }

        /// <summary>
        /// <para>The cloud computer IDs. You can specify 1 to 100 IDs.</para>
        /// </summary>
        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// <para>The image ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>m-4zfb6zj728hhr****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The timestamp of the last retry. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1699960800000</para>
        /// </summary>
        [NameInMap("LastRetryTime")]
        [Validation(Required=false)]
        public long? LastRetryTime { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// <remarks>
        /// <para>This parameter takes effect only for resetting shared cloud computers. If this parameter is left empty, all cloud computers of all billing methods within the shared cloud computer are reset.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The region ID. Call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The reset scope. You can configure this parameter to specify whether to reset the image or the cloud computer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("ResetScope")]
        [Validation(Required=false)]
        public string ResetScope { get; set; }

        /// <summary>
        /// <para>The reset type, which determines whether to reset and the scope of cloud disks to reset.</para>
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
