// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class KibanaNodeConfiguration : TeaModel {
        [NameInMap("amount")]
        [Validation(Required=false)]
        public long? Amount { get; set; }

        [NameInMap("disk")]
        [Validation(Required=false)]
        public long? Disk { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
