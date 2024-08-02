// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class IngestProcessorConfiguration : TeaModel {
        [NameInMap("parseFail")]
        [Validation(Required=false)]
        public string ParseFail { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("spl")]
        [Validation(Required=false)]
        public string Spl { get; set; }

    }

}
