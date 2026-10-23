// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class SearchNodeConfiguration : TeaModel {
        /// <summary>
        /// <para>The number of nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <para>The cloud disk size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("disk")]
        [Validation(Required=false)]
        public int? Disk { get; set; }

        /// <summary>
        /// <para>The cloud disk type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("diskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        /// <summary>
        /// <para>The cloud disk performance level (PL).</para>
        /// 
        /// <b>Example:</b>
        /// <para>PL0</para>
        /// </summary>
        [NameInMap("performanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// <para>The node specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>elasticsearch.turbo1.ci.xlarge</para>
        /// </summary>
        [NameInMap("spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
