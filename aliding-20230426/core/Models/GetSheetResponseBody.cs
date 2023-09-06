// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetSheetResponseBody : TeaModel {
        [NameInMap("columnCount")]
        [Validation(Required=false)]
        public long? ColumnCount { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("lastNonEmptyColumn")]
        [Validation(Required=false)]
        public long? LastNonEmptyColumn { get; set; }

        [NameInMap("lastNonEmptyRow")]
        [Validation(Required=false)]
        public long? LastNonEmptyRow { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("rowCount")]
        [Validation(Required=false)]
        public long? RowCount { get; set; }

        [NameInMap("visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
