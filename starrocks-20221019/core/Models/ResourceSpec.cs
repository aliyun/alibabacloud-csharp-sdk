// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Starrocks20221019.Models
{
    public class ResourceSpec : TeaModel {
        /// <summary>
        /// <para>The number of CUs. A compute unit (CU) is the basic metering unit of a service. 1 CU = 1 CPU core + 4 GiB of memory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("cu")]
        [Validation(Required=false)]
        public int? Cu { get; set; }

        /// <summary>
        /// <para>The number of disk blocks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("diskNumber")]
        [Validation(Required=false)]
        public int? DiskNumber { get; set; }

        /// <summary>
        /// <para>Local SSD Instance Specification for the node group. This parameter is applicable only when the node group is based on ECS instances and the SpecType is set to \&quot;Local SSD / Large-capacity Storage\&quot;</para>
        /// 
        /// <b>Example:</b>
        /// <para>local_ssd_4_4xlarge</para>
        /// </summary>
        [NameInMap("localStorageInstanceType")]
        [Validation(Required=false)]
        public string LocalStorageInstanceType { get; set; }

        /// <summary>
        /// <para>The number of nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("nodeNumber")]
        [Validation(Required=false)]
        public int? NodeNumber { get; set; }

        /// <summary>
        /// <para>The type of the node group. The following types are included:</para>
        /// <list type="bullet">
        /// <item><description>standard, Standard Edition, ECS + cloud disk.</description></item>
        /// <item><description>localSSD , local SSD.</description></item>
        /// <item><description>bigData, which stores large specifications.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("specType")]
        [Validation(Required=false)]
        public string SpecType { get; set; }

        /// <summary>
        /// <para>The performance level of the disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PL0: A single disk can achieve up to 10,000 random read/write IOPS.</description></item>
        /// <item><description>PL1: A single disk can achieve up to 50,000 random read/write IOPS.</description></item>
        /// <item><description>PL2: A single disk can achieve up to 100,000 random read/write IOPS.</description></item>
        /// <item><description>PL3: A single disk can achieve up to 1 million random read/write IOPS.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pl1</para>
        /// </summary>
        [NameInMap("storagePerformanceLevel")]
        [Validation(Required=false)]
        public string StoragePerformanceLevel { get; set; }

        /// <summary>
        /// <para>The storage size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("storageSize")]
        [Validation(Required=false)]
        public int? StorageSize { get; set; }

    }

}
