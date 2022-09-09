// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateResourceExportTaskRequest : TeaModel {
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("excludeRules")]
        [Validation(Required=false)]
        public List<CreateResourceExportTaskRequestExcludeRules> ExcludeRules { get; set; }
        public class CreateResourceExportTaskRequestExcludeRules : TeaModel {
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        [NameInMap("exportToModule")]
        [Validation(Required=false)]
        public CreateResourceExportTaskRequestExportToModule ExportToModule { get; set; }
        public class CreateResourceExportTaskRequestExportToModule : TeaModel {
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("sourcePath")]
            [Validation(Required=false)]
            public string SourcePath { get; set; }

            [NameInMap("statePath")]
            [Validation(Required=false)]
            public string StatePath { get; set; }

        }

        [NameInMap("includeRules")]
        [Validation(Required=false)]
        public List<CreateResourceExportTaskRequestIncludeRules> IncludeRules { get; set; }
        public class CreateResourceExportTaskRequestIncludeRules : TeaModel {
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ramRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        [NameInMap("terraformVersion")]
        [Validation(Required=false)]
        public string TerraformVersion { get; set; }

        [NameInMap("triggerStrategy")]
        [Validation(Required=false)]
        public string TriggerStrategy { get; set; }

        [NameInMap("variables")]
        [Validation(Required=false)]
        public List<CreateResourceExportTaskRequestVariables> Variables { get; set; }
        public class CreateResourceExportTaskRequestVariables : TeaModel {
            [NameInMap("properties")]
            [Validation(Required=false)]
            public List<string> Properties { get; set; }

            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
