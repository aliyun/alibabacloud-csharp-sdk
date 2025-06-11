// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class TableKnowledgeInfo : TeaModel {
        [NameInMap("AssetDescription")]
        [Validation(Required=false)]
        public string AssetDescription { get; set; }

        [NameInMap("AssetModifiedGmt")]
        [Validation(Required=false)]
        public string AssetModifiedGmt { get; set; }

        [NameInMap("ColumnList")]
        [Validation(Required=false)]
        public List<ColumnKnowledgeInfo> ColumnList { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
