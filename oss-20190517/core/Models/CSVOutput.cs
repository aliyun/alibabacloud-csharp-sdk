// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class CSVOutput : TeaModel {
        /// <summary>
        /// description
        /// </summary>
        [NameInMap("FieldDelimiter")]
        [Validation(Required=false)]
        public string FieldDelimiter { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("RecordDelimiter")]
        [Validation(Required=false)]
        public string RecordDelimiter { get; set; }

    }

}
