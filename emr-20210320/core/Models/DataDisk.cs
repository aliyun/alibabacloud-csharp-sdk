// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class DataDisk : TeaModel {
        /// <summary>
        /// <para>The disk type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>cloud_efficiency</c>: Ultra Disk.</para>
        /// </description></item>
        /// <item><description><para><c>cloud_ssd</c>: Standard SSD.</para>
        /// </description></item>
        /// <item><description><para><c>cloud_essd</c>: ESSD.</para>
        /// </description></item>
        /// <item><description><para><c>cloud</c>: Basic Disk.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The number of data disks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The performance level of an ESSD. This parameter applies only when the <c>Category</c> parameter is set to <c>cloud_essd</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PL0: A maximum of 10,000 random read/write IOPS per disk.</para>
        /// </description></item>
        /// <item><description><para>PL1: A maximum of 50,000 random read/write IOPS per disk.</para>
        /// </description></item>
        /// <item><description><para>PL2: A maximum of 100,000 random read/write IOPS per disk.</para>
        /// </description></item>
        /// <item><description><para>PL3: A maximum of 1,000,000 random read/write IOPS per disk.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: PL1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// <para>The size of each data disk, in GB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
