// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class UpdateResourceExportTaskAttributeRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("configPath")]
        [Validation(Required=false)]
        public string ConfigPath { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("excludeRules")]
        [Validation(Required=false)]
        public List<UpdateResourceExportTaskAttributeRequestExcludeRules> ExcludeRules { get; set; }
        public class UpdateResourceExportTaskAttributeRequestExcludeRules : TeaModel {
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        [NameInMap("exportToModule")]
        [Validation(Required=false)]
        public UpdateResourceExportTaskAttributeRequestExportToModule ExportToModule { get; set; }
        public class UpdateResourceExportTaskAttributeRequestExportToModule : TeaModel {
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
        public List<UpdateResourceExportTaskAttributeRequestIncludeRules> IncludeRules { get; set; }
        public class UpdateResourceExportTaskAttributeRequestIncludeRules : TeaModel {
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ramRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        [NameInMap("terraformProviderVersion")]
        [Validation(Required=false)]
        public string TerraformProviderVersion { get; set; }

        [NameInMap("terraformVersion")]
        [Validation(Required=false)]
        public string TerraformVersion { get; set; }

        [NameInMap("triggerStrategy")]
        [Validation(Required=false)]
        public string TriggerStrategy { get; set; }

        [NameInMap("variables")]
        [Validation(Required=false)]
        public List<UpdateResourceExportTaskAttributeRequestVariables> Variables { get; set; }
        public class UpdateResourceExportTaskAttributeRequestVariables : TeaModel {
            [NameInMap("properties")]
            [Validation(Required=false)]
            public List<string> Properties { get; set; }

            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
