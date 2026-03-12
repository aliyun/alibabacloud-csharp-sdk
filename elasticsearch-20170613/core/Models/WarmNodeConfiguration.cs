// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class WarmNodeConfiguration : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("amount")]
        [Validation(Required=false)]
        public long? Amount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("disk")]
        [Validation(Required=false)]
        public long? Disk { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("diskEncryption")]
        [Validation(Required=false)]
        public bool? DiskEncryption { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cloud_efficiency</para>
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
