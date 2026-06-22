// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class SystemDisk : TeaModel {
        /// <summary>
        /// <para>The type of the system disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>cloud_efficiency</c>: Ultra Disk.</para>
        /// </description></item>
        /// <item><description><para><c>cloud_ssd</c>: SSD Cloud Disk.</para>
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
        /// <para>Specifies the number of system disks on each node. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The performance level of the ESSD. This parameter is valid only when <c>Category</c> is set to <c>cloud_essd</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>PL0</c>: Up to 10,000 random read/write IOPS per disk.</para>
        /// </description></item>
        /// <item><description><para><c>PL1</c> (default): Up to 50,000 random read/write IOPS per disk.</para>
        /// </description></item>
        /// <item><description><para><c>PL2</c>: Up to 100,000 random read/write IOPS per disk.</para>
        /// </description></item>
        /// <item><description><para><c>PL3</c>: Up to 1,000,000 random read/write IOPS per disk.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// <para>The size of the system disk, in GB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
