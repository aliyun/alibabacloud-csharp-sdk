// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class OSSIngestionConfiguration : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public OSSIngestionConfigurationSource Source { get; set; }

    }

}
