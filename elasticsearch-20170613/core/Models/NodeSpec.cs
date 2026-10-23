// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class NodeSpec : TeaModel {
        /// <summary>
        /// <para>The disk size of the data node, in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("disk")]
        [Validation(Required=false)]
        public int? Disk { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable cloud disk encryption for the data node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("diskEncryption")]
        [Validation(Required=false)]
        public bool? DiskEncryption { get; set; }

        /// <summary>
        /// <para>The storage preference.</para>
        /// 
        /// <b>Example:</b>
        /// <para>high_availability</para>
        /// </summary>
        [NameInMap("diskPreference")]
        [Validation(Required=false)]
        public string DiskPreference { get; set; }

        /// <summary>
        /// <para>The storage type of the data node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cloud_ssd: standard SSD</description></item>
        /// <item><description>cloud_essd: ESSD</description></item>
        /// <item><description>cloud_efficiency: ultra disk</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("diskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>The performance level (PL) of the ESSD. This parameter is required when the disk type of the data node is ESSD. Valid values: PL1, PL2, and PL3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("performanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// <para>The specifications of the data node. For more information, see <a href="https://help.aliyun.com/document_detail/271718.html">Product specifications</a>.</para>
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
