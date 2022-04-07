// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class CSVInput : TeaModel {
        /// <summary>
        /// description
        /// </summary>
        [NameInMap("AllowQuotedRecordDelimiter")]
        [Validation(Required=false)]
        public bool? AllowQuotedRecordDelimiter { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("CommentCharacter")]
        [Validation(Required=false)]
        public string CommentCharacter { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("FieldDelimiter")]
        [Validation(Required=false)]
        public string FieldDelimiter { get; set; }

        [NameInMap("FileHeaderInfo")]
        [Validation(Required=false)]
        public string FileHeaderInfo { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("QuoteCharacter")]
        [Validation(Required=false)]
        public string QuoteCharacter { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("Range")]
        [Validation(Required=false)]
        public string Range { get; set; }

        /// <summary>
        /// description
        /// </summary>
        [NameInMap("RecordDelimiter")]
        [Validation(Required=false)]
        public string RecordDelimiter { get; set; }

    }

}
