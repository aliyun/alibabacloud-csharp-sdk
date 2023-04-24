// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateDataExportOrderRequest : TeaModel {
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
        public CreateDataExportOrderRequestPluginParam PluginParam { get; set; }
        public class CreateDataExportOrderRequestPluginParam : TeaModel {
            [NameInMap("AffectRows")]
            [Validation(Required=false)]
            public long? AffectRows { get; set; }

            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            [NameInMap("DbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            [NameInMap("ExeSQL")]
            [Validation(Required=false)]
            public string ExeSQL { get; set; }

            [NameInMap("IgnoreAffectRows")]
            [Validation(Required=false)]
            public bool? IgnoreAffectRows { get; set; }

            [NameInMap("IgnoreAffectRowsReason")]
            [Validation(Required=false)]
            public string IgnoreAffectRowsReason { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            [NameInMap("Logic")]
            [Validation(Required=false)]
            public bool? Logic { get; set; }

            [NameInMap("Watermark")]
            [Validation(Required=false)]
            public CreateDataExportOrderRequestPluginParamWatermark Watermark { get; set; }
            public class CreateDataExportOrderRequestPluginParamWatermark : TeaModel {
                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                [NameInMap("DataWatermark")]
                [Validation(Required=false)]
                public string DataWatermark { get; set; }

                [NameInMap("FileWatermark")]
                [Validation(Required=false)]
                public string FileWatermark { get; set; }

                [NameInMap("Keys")]
                [Validation(Required=false)]
                public List<string> Keys { get; set; }

                [NameInMap("WatermarkTypes")]
                [Validation(Required=false)]
                public List<string> WatermarkTypes { get; set; }

            }

        }

        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<long?> RelatedUserList { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
