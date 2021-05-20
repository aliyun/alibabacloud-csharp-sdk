// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class UpdateMetaTableRequest : TeaModel {
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public int? EnvType { get; set; }

        [NameInMap("TableGuid")]
        [Validation(Required=false)]
        public string TableGuid { get; set; }

        [NameInMap("NewOwnerId")]
        [Validation(Required=false)]
        public string NewOwnerId { get; set; }

        [NameInMap("AddedLabels")]
        [Validation(Required=false)]
        public string AddedLabels { get; set; }

        [NameInMap("RemovedLabels")]
        [Validation(Required=false)]
        public string RemovedLabels { get; set; }

        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public int? Visibility { get; set; }

        [NameInMap("Caption")]
        [Validation(Required=false)]
        public string Caption { get; set; }

    }

}
