// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDisksRequest : TeaModel {
        /// <summary>
        /// <para>The disk category.</para>
        /// <list type="bullet">
        /// <item><description>cloud_efficiency: ultra cloud disk</description></item>
        /// <item><description>cloud_ssd: all-flash cloud disk</description></item>
        /// <item><description>local_hdd: local HDD</description></item>
        /// <item><description>local_ssd: local SSD</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>local_ssd</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The billing type.</para>
        /// <list type="bullet">
        /// <item><description>prepay: subscription</description></item>
        /// <item><description>postpay: pay-as-you-go</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>prepay</para>
        /// </summary>
        [NameInMap("DiskChargeType")]
        [Validation(Required=false)]
        public string DiskChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the cloud disk.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-5soak1gqa507lyfzvz0xo****</para>
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// <para>The disk IDs.</para>
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
        /// <para>The disk purchase method.</para>
        /// <list type="bullet">
        /// <item><description>ServiceDisk: disk created by an edge service</description></item>
        /// <item><description>ResoureDisk: purchased with an instance</description></item>
        /// <item><description>PostPayDisk: purchased separately</description></item>
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
        /// <para>The list of edge zones.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cn-suzhou-telecom&quot;,&quot;cn-chengdu-telecom&quot;]</para>
        /// </summary>
        [NameInMap("EnsRegionIds")]
        [Validation(Required=false)]
        public string EnsRegionIds { get; set; }

        /// <summary>
        /// <para>The instance to which the cloud disk is mounted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-5t77rb0yoz79m28ku60sx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The sorting parameter. Format example: {&quot;EnsRegionId&quot;:&quot;desc&quot;}. By default, results are sorted by edge zone ID in descending order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;DiskNameSort&quot;:&quot;desc&quot;,&quot;EnsRegionIdSort&quot;:&quot;asc&quot; }</para>
        /// </summary>
        [NameInMap("OrderByParams")]
        [Validation(Required=false)]
        public string OrderByParams { get; set; }

        /// <summary>
        /// <para>The page number of the query list. Minimum value: <b>1</b>.</para>
        /// <para>Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paged query. Maximum value: <b>50</b>.</para>
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
        /// <para>The disk status.</para>
        /// <list type="bullet">
        /// <item><description>In-use: in use</description></item>
        /// <item><description>Available: to be mounted</description></item>
        /// <item><description>Attaching: being mounted</description></item>
        /// <item><description>Detaching: being unmounted</description></item>
        /// <item><description>Creating: being created</description></item>
        /// <item><description>ReIniting: being reset</description></item>
        /// <item><description>Deleting: being released</description></item>
        /// <item><description>Deleted: released</description></item>
        /// <item><description>Expiring: about to expire</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The disk property.</para>
        /// <list type="bullet">
        /// <item><description>system: system cloud disk</description></item>
        /// <item><description>data: data cloud disk</description></item>
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
