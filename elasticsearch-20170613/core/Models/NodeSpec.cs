// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class NodeSpec : TeaModel {
        /// <summary>
        /// <para>Storage space size of data nodes, in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("disk")]
        [Validation(Required=false)]
        public int? Disk { get; set; }

        /// <summary>
        /// <para>Whether to enable cloud disk encryption for data nodes:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled</description></item>
        /// <item><description>false: Disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("diskEncryption")]
        [Validation(Required=false)]
        public bool? DiskEncryption { get; set; }

        /// <summary>
        /// <para>Storage preference.</para>
        /// </summary>
        [NameInMap("diskPreference")]
        [Validation(Required=false)]
        public string DiskPreference { get; set; }

        /// <summary>
        /// <para>Storage type of data nodes. Supported values:</para>
        /// <list type="bullet">
        /// <item><description>cloud_ssd: SSD cloud disk</description></item>
        /// <item><description>cloud_essd: ESSD cloud disk</description></item>
        /// <item><description>cloud_efficiency: Ultra cloud disk</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("diskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>Performance level of ESSD cloud disks. Required when the disk type of data nodes is ESSD cloud disk. Supported values: PL1, PL2, PL3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("performanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// <para>Data node specification. Specification details can be viewed in <a href="https://help.aliyun.com/document_detail/271718.html">Product Specifications</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>elasticsearch.sn2ne.large</para>
        /// </summary>
        [NameInMap("spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
