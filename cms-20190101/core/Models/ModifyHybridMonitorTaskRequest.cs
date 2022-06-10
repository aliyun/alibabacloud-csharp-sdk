// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class ModifyHybridMonitorTaskRequest : TeaModel {
        [NameInMap("AttachLabels")]
        [Validation(Required=false)]
        public List<ModifyHybridMonitorTaskRequestAttachLabels> AttachLabels { get; set; }
        public class ModifyHybridMonitorTaskRequestAttachLabels : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("CollectInterval")]
        [Validation(Required=false)]
        public string CollectInterval { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SLSProcessConfig")]
        [Validation(Required=false)]
        public ModifyHybridMonitorTaskRequestSLSProcessConfig SLSProcessConfig { get; set; }
        public class ModifyHybridMonitorTaskRequestSLSProcessConfig : TeaModel {
            [NameInMap("Express")]
            [Validation(Required=false)]
            public List<ModifyHybridMonitorTaskRequestSLSProcessConfigExpress> Express { get; set; }
            public class ModifyHybridMonitorTaskRequestSLSProcessConfigExpress : TeaModel {
                public string Alias { get; set; }
                public string Express { get; set; }
            }
            [NameInMap("Filter")]
            [Validation(Required=false)]
            public ModifyHybridMonitorTaskRequestSLSProcessConfigFilter Filter { get; set; }
            public class ModifyHybridMonitorTaskRequestSLSProcessConfigFilter : TeaModel {
                [NameInMap("Filters")]
                [Validation(Required=false)]
                public List<ModifyHybridMonitorTaskRequestSLSProcessConfigFilterFilters> Filters { get; set; }
                public class ModifyHybridMonitorTaskRequestSLSProcessConfigFilterFilters : TeaModel {
                    [NameInMap("Operator")]
                    [Validation(Required=false)]
                    public string Operator { get; set; }

                    [NameInMap("SLSKeyName")]
                    [Validation(Required=false)]
                    public string SLSKeyName { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Relation")]
                [Validation(Required=false)]
                public string Relation { get; set; }

            }
            [NameInMap("GroupBy")]
            [Validation(Required=false)]
            public List<ModifyHybridMonitorTaskRequestSLSProcessConfigGroupBy> GroupBy { get; set; }
            public class ModifyHybridMonitorTaskRequestSLSProcessConfigGroupBy : TeaModel {
                public string Alias { get; set; }
                public string SLSKeyName { get; set; }
            }
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public List<ModifyHybridMonitorTaskRequestSLSProcessConfigStatistics> Statistics { get; set; }
            public class ModifyHybridMonitorTaskRequestSLSProcessConfigStatistics : TeaModel {
                public string Alias { get; set; }
                public string Function { get; set; }
                public string Parameter1 { get; set; }
                public string Parameter2 { get; set; }
                public string SLSKeyName { get; set; }
            }
        };

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
