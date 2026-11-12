// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDisksRequest : TeaModel {
        /// <summary>
        /// <para>The category of the cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud_efficiency: Ultra cloud disk.</description></item>
        /// <item><description>cloud_ssd: All-flash cloud disk.</description></item>
        /// <item><description>local_hdd: Local HDD.</description></item>
        /// <item><description>local_ssd: Local SSD.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>local_ssd</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>prepay: Subscription.</description></item>
        /// <item><description>postpay: Pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>prepay</para>
        /// </summary>
        [NameInMap("DiskChargeType")]
        [Validation(Required=false)]
        public string DiskChargeType { get; set; }

        /// <summary>
        /// <para>The cloud disk ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-5soak1gqa507lyfzvz0xo****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>The IDs of the cloud disks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;d-wz99njena32z90ki****\&quot;]</para>
        /// </summary>
        [NameInMap("DiskIds")]
        [Validation(Required=false)]
        public string DiskIds { get; set; }

        /// <summary>
        /// <para>The name of the cloud disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DiskName</para>
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// <para>The purchase method of the cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ServiceDisk: Created by Edge Node Service.</description></item>
        /// <item><description>ResoureDisk: Purchased with an instance.</description></item>
        /// <item><description>PostPayDisk: Purchased separately.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPayDisk</para>
        /// </summary>
        [NameInMap("DiskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>The ID of the ENS edge zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-kunming-telecom</para>
        /// </summary>
        [NameInMap("EnsRegionId")]
        [Validation(Required=false)]
        public string EnsRegionId { get; set; }

        /// <summary>
        /// <para>The list of edge zone IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cn-suzhou-telecom&quot;,&quot;cn-chengdu-telecom&quot;]</para>
        /// </summary>
        [NameInMap("EnsRegionIds")]
        [Validation(Required=false)]
        public string EnsRegionIds { get; set; }

        /// <summary>
        /// <para>The ID of the instance to which the cloud disk is attached.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-5t77rb0yoz79m28ku60sx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The sorting parameter. Format example: {&quot;EnsRegionId&quot;:&quot;desc&quot;}. By default, the results are sorted in descending order of edge zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;DiskNameSort&quot;:&quot;desc&quot;,&quot;EnsRegionIdSort&quot;:&quot;asc&quot; }</para>
        /// </summary>
        [NameInMap("OrderByParams")]
        [Validation(Required=false)]
        public string OrderByParams { get; set; }

        /// <summary>
        /// <para>The page number of the query list. The minimum value is <b>1</b>.</para>
        /// <para>Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: <b>50</b>.</para>
        /// <para>Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The snapshot ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-897654321****</para>
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// <para>The status of the cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>In-use: In use.</description></item>
        /// <item><description>Available: Unattached.</description></item>
        /// <item><description>Attaching: Attaching.</description></item>
        /// <item><description>Detaching: Detaching.</description></item>
        /// <item><description>Creating: Creating.</description></item>
        /// <item><description>ReIniting: Reinitializing.</description></item>
        /// <item><description>Deleting: Releasing.</description></item>
        /// <item><description>Deleted: Released.</description></item>
        /// <item><description>Expiring: Expiring.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The type of the cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>system: System cloud disk.</description></item>
        /// <item><description>data: Data cloud disk.</description></item>
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
