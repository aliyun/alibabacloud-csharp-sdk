// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class NodeSpec : TeaModel {
        [NameInMap("disk")]
        [Validation(Required=false)]
        public int? Disk { get; set; }

        [NameInMap("diskEncryption")]
        [Validation(Required=false)]
        public bool? DiskEncryption { get; set; }

        [NameInMap("diskPreference")]
        [Validation(Required=false)]
        public string DiskPreference { get; set; }

        [NameInMap("diskType")]
        [Validation(Required=false)]
        public string DiskType { get; set; }

        [NameInMap("performanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
