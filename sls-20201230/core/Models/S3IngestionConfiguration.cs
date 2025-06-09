// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class S3IngestionConfiguration : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>myLogstore</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        [NameInMap("source")]
        [Validation(Required=false)]
        public S3IngestionConfigurationSource Source { get; set; }

    }

}
