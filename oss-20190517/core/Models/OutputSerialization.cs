// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class OutputSerialization : TeaModel {
        [NameInMap("CSV")]
        [Validation(Required=false)]
        public CSVOutput Csv { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("EnablePayloadCrc")]
        [Validation(Required=false)]
        public bool? EnablePayloadCrc { get; set; }

        [NameInMap("JSON")]
        [Validation(Required=false)]
        public JSONOutput Json { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("KeepAllColumns")]
        [Validation(Required=false)]
        public bool? KeepAllColumns { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("OutputHeader")]
        [Validation(Required=false)]
        public bool? OutputHeader { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("OutputRawData")]
        [Validation(Required=false)]
        public bool? OutputRawData { get; set; }

    }

}
