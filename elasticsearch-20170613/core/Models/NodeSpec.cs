// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class NodeSpec : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("disk")]
        [Validation(Required=false)]
        public int? Disk { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("diskEncryption")]
        [Validation(Required=false)]
        public bool? DiskEncryption { get; set; }

        [NameInMap("diskPreference")]
        [Validation(Required=false)]
        public string DiskPreference { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cloud_ssd</para>
        /// </summary>
        [NameInMap("diskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PL1</para>
        /// </summary>
        [NameInMap("performanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
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
