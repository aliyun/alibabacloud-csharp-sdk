// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDisksRequest : TeaModel {
        /// <summary>
        /// <para>The category of the disk.</para>
        /// <list type="bullet">
        /// <item><description>cloud_efficiency: ultra disk.</description></item>
        /// <item><description>cloud_ssd: all-flash disk.</description></item>
        /// <item><description>local_hdd: local HDD.</description></item>
        /// <item><description>local_ssd: local SSD.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>local_ssd</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The billing method.</para>
        /// <list type="bullet">
        /// <item><description>prePay: subscription.</description></item>
        /// <item><description>postpay: pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>prepay</para>
        /// </summary>
        [NameInMap("DiskChargeType")]
        [Validation(Required=false)]
        public string DiskChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-5soak1gqa507lyfzvz0xo****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>The ID of the disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;d-wz99njena32z90ki****\&quot;]</para>
        /// </summary>
        [NameInMap("DiskIds")]
        [Validation(Required=false)]
        public string DiskIds { get; set; }

        /// <summary>
        /// <para>The name of the disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DiskName</para>
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// <para>The purchase method of the disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ServiceDisk: The disk is purchased when ENS is activated.</description></item>
        /// <item><description>ResoureDisk: The disk is purchased when the instance is created.</description></item>
        /// <item><description>PostPayDisk: The disk is separately purchased.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPayDisk</para>
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>The ID of the edge node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-kunming-telecom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The node information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cn-suzhou-telecom&quot;,&quot;cn-chengdu-telecom&quot;]</para>
        /// </summary>
        [NameInMap("EnsRegionIds")]
        [Validation(Required=false)]
        public string EnsRegionIds { get; set; }

        /// <summary>
        /// <para>The ID of the instance to which the disk is attached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-5t77rb0yoz79m28ku60sx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The order in which you want to sort the returned data. Example: {&quot;EnsRegionId&quot;:&quot;desc&quot;}. By default, the nodes are sorted by IDs in descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;DiskNameSort&quot;:&quot;desc&quot;,&quot;EnsRegionIdSort&quot;:&quot;asc&quot; }</para>
        /// </summary>
        [NameInMap("OrderByParams")]
        [Validation(Required=false)]
        public string OrderByParams { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Pages start from page <b>1</b>.</para>
        /// <para>Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: <b>50</b>.</para>
        /// <para>Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the snapshot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-897654321****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The status of the disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>In-use: The disk is in use.</description></item>
        /// <item><description>Available: The disk can be attached.</description></item>
        /// <item><description>Attaching: The disk is being attached.</description></item>
        /// <item><description>Detaching: The disk is being detached.</description></item>
        /// <item><description>Creating: The disk is being created.</description></item>
        /// <item><description>ReIniting: The disk is being reset.</description></item>
        /// <item><description>Deleting: The disk is being released.</description></item>
        /// <item><description>Deleted: The disk is released.</description></item>
        /// <item><description>Expiring: The disk is about to expire.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The type of the disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>system: system disk.</description></item>
        /// <item><description>data: data disk.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>system</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
