// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ColumnKnowledgeInfo : TeaModel {
        [NameInMap("AssetDescription")]
        [Validation(Required=false)]
        public string AssetDescription { get; set; }

        [NameInMap("AssetModifiedGmt")]
        [Validation(Required=false)]
        public string AssetModifiedGmt { get; set; }

        [NameInMap("ColumnName")]
        [Validation(Required=false)]
        public string ColumnName { get; set; }

        [NameInMap("ColumnType")]
        [Validation(Required=false)]
        public string ColumnType { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Position")]
        [Validation(Required=false)]
        public int? Position { get; set; }

    }

}
