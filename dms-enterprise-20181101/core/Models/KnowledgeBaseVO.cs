// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class KnowledgeBaseVO : TeaModel {
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        [NameInMap("Confidence")]
        [Validation(Required=false)]
        public double? Confidence { get; set; }

        [NameInMap("DbId")]
        [Validation(Required=false)]
        public int? DbId { get; set; }

        [NameInMap("DbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public long? EntityId { get; set; }

        [NameInMap("Env")]
        [Validation(Required=false)]
        public string Env { get; set; }

        [NameInMap("Expr")]
        [Validation(Required=false)]
        public string Expr { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("IsDelete")]
        [Validation(Required=false)]
        public bool? IsDelete { get; set; }

        [NameInMap("KnowledgeId")]
        [Validation(Required=false)]
        public string KnowledgeId { get; set; }

        [NameInMap("KnowledgeType")]
        [Validation(Required=false)]
        public string KnowledgeType { get; set; }

        [NameInMap("LevelType")]
        [Validation(Required=false)]
        public string LevelType { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OldDescription")]
        [Validation(Required=false)]
        public string OldDescription { get; set; }

        [NameInMap("OldSummary")]
        [Validation(Required=false)]
        public string OldSummary { get; set; }

        [NameInMap("ParseDesc")]
        [Validation(Required=false)]
        public string ParseDesc { get; set; }

        [NameInMap("ReasoningLogic")]
        [Validation(Required=false)]
        public string ReasoningLogic { get; set; }

        [NameInMap("RelationType")]
        [Validation(Required=false)]
        public string RelationType { get; set; }

        [NameInMap("ShowType")]
        [Validation(Required=false)]
        public string ShowType { get; set; }

        [NameInMap("Summary")]
        [Validation(Required=false)]
        public string Summary { get; set; }

        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
