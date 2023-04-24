// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateDatabaseExportOrderRequest : TeaModel {
        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public long? ParentId { get; set; }

        [NameInMap("PluginParam")]
        [Validation(Required=false)]
        public CreateDatabaseExportOrderRequestPluginParam PluginParam { get; set; }
        public class CreateDatabaseExportOrderRequestPluginParam : TeaModel {
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            [NameInMap("Config")]
            [Validation(Required=false)]
            public CreateDatabaseExportOrderRequestPluginParamConfig Config { get; set; }
            public class CreateDatabaseExportOrderRequestPluginParamConfig : TeaModel {
                [NameInMap("DataOption")]
                [Validation(Required=false)]
                public List<string> DataOption { get; set; }

                [NameInMap("ExportContent")]
                [Validation(Required=false)]
                public string ExportContent { get; set; }

                [NameInMap("ExportTypes")]
                [Validation(Required=false)]
                public List<string> ExportTypes { get; set; }

                [NameInMap("SQLExtOption")]
                [Validation(Required=false)]
                public List<string> SQLExtOption { get; set; }

                [NameInMap("SelectedTables")]
                [Validation(Required=false)]
                public List<string> SelectedTables { get; set; }

                [NameInMap("Tables")]
                [Validation(Required=false)]
                public Dictionary<string, string> Tables { get; set; }

                [NameInMap("TargetOption")]
                [Validation(Required=false)]
                public string TargetOption { get; set; }

            }

            [NameInMap("DbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            [NameInMap("Logic")]
            [Validation(Required=false)]
            public bool? Logic { get; set; }

            [NameInMap("SearchName")]
            [Validation(Required=false)]
            public string SearchName { get; set; }

        }

        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<long?> RelatedUserList { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
