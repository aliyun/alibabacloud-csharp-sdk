// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDisksResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned service code. 0 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The information about the disks.</para>
        /// </summary>
        [NameInMap("Disks")]
        [Validation(Required=false)]
        public DescribeDisksResponseBodyDisks Disks { get; set; }
        public class DescribeDisksResponseBodyDisks : TeaModel {
            [NameInMap("Disks")]
            [Validation(Required=false)]
            public List<DescribeDisksResponseBodyDisksDisks> Disks { get; set; }
            public class DescribeDisksResponseBodyDisksDisks : TeaModel {
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
                /// <para>The time when the disk was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-11-11T14:34:55+08:00</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("DeleteWithInstance")]
                [Validation(Required=false)]
                public bool? DeleteWithInstance { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The billing method of the cloud disk or local disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>prepaid</b>: subscription.</description></item>
                /// <item><description><b>postpaid</b>: pay-as-you-go.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>prepaid</para>
                /// </summary>
                [NameInMap("DiskChargeType")]
                [Validation(Required=false)]
                public string DiskChargeType { get; set; }

                /// <summary>
                /// <para>The ID of the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d-5svum1dx1w4a4spr54lgr****</para>
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                /// <summary>
                /// <para>The name of the disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fvt-ecs-5cf0****</para>
                /// </summary>
                [NameInMap("DiskName")]
                [Validation(Required=false)]
                public string DiskName { get; set; }

                /// <summary>
                /// <para>Indicates whether the cloud disk is encrypted. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>False</para>
                /// </summary>
                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public bool? Encrypted { get; set; }

                /// <summary>
                /// <para>The ID of the Key Management Service (KMS) key that is used for the cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>05467897a-4262-4802-b8cb-00d3fb40****</para>
                /// </summary>
                [NameInMap("EncryptedKeyId")]
                [Validation(Required=false)]
                public string EncryptedKeyId { get; set; }

                /// <summary>
                /// <para>The ID of the edge node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-guangzhou-10</para>
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-5t77rb0yoz79m28ku60sx****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Edge Prod Environment Streaming Machine -1063</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>Indicates whether the cloud disk or local disk is removable. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>true: The disk is removable. A removable disk can independently exist and can be attached to or detached from an instance within the same zone.</description></item>
                /// <item><description>false: The disk is not removable. A disk that is not removable cannot independently exist or be attached to or detached from an instance within the same zone.</description></item>
                /// </list>
                /// <para>If disks are of the following categories or types, the <b>Portable</b> value is <b>false</b> and the disks have the same lifecycle as their attached instances:</para>
                /// <list type="bullet">
                /// <item><description>Local HDDs</description></item>
                /// <item><description>Local SSDs</description></item>
                /// <item><description>Data disks that use the subscription billing method</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Portable")]
                [Validation(Required=false)]
                public bool? Portable { get; set; }

                /// <summary>
                /// <para>The serial number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("SerialId")]
                [Validation(Required=false)]
                public string SerialId { get; set; }

                /// <summary>
                /// <para>The size of the disk. Unit: MiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <para>The ID of the snapshot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>s-bp67acfmxazb4p****</para>
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
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The type of the cloud disk or local disk. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: system disk.</description></item>
                /// <item><description>2: data disk.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Maximum value: <b>50</b>. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BA984</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of returned pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
