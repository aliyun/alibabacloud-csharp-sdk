// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class LineageColumn : TeaModel {
        [NameInMap("columnName")]
        [Validation(Required=false)]
        public string ColumnName { get; set; }

        [NameInMap("columnNativeType")]
        [Validation(Required=false)]
        public string ColumnNativeType { get; set; }

        [NameInMap("columnType")]
        [Validation(Required=false)]
        public string ColumnType { get; set; }

        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("modifiedAt")]
        [Validation(Required=false)]
        public long? ModifiedAt { get; set; }

        [NameInMap("modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        [NameInMap("nullable")]
        [Validation(Required=false)]
        public bool? Nullable { get; set; }

    }

}
