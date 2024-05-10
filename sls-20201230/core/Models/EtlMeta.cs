// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class EtlMeta : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("enable")]
        [Validation(Required=false)]
        public bool? Enable { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("etlMetaKey")]
        [Validation(Required=false)]
        public string EtlMetaKey { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("etlMetaName")]
        [Validation(Required=false)]
        public string EtlMetaName { get; set; }

        [NameInMap("etlMetaTag")]
        [Validation(Required=false)]
        public string EtlMetaTag { get; set; }

        [NameInMap("etlMetaValue")]
        [Validation(Required=false)]
        public string EtlMetaValue { get; set; }

    }

}
