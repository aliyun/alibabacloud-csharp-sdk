// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateResourceExportTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a65451293e64979ba7a4b573950217fe</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("exportToModule")]
        [Validation(Required=false)]
        public CreateResourceExportTaskRequestExportToModule ExportToModule { get; set; }
        public class CreateResourceExportTaskRequestExportToModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>Registry</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>alibaba/security-group/alicloud</para>
            /// </summary>
            [NameInMap("sourcePath")]
            [Validation(Required=false)]
            public string SourcePath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/</para>
            /// </summary>
            [NameInMap("statePath")]
            [Validation(Required=false)]
            public string StatePath { get; set; }

        }

        [NameInMap("includeRules")]
        [Validation(Required=false)]
        public List<CreateResourceExportTaskRequestIncludeRules> IncludeRules { get; set; }
        public class CreateResourceExportTaskRequestIncludeRules : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ZoneId</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("values")]
            [Validation(Required=false)]
            public List<string> Values { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ramRole")]
        [Validation(Required=false)]
        public string RamRole { get; set; }

        [NameInMap("terraformProviderVersion")]
        [Validation(Required=false)]
        public string TerraformProviderVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1.2.6</para>
        /// </summary>
        [NameInMap("terraformVersion")]
        [Validation(Required=false)]
        public string TerraformVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Auto</para>
        /// </summary>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>AliCloud::VPC::VPC</para>
            /// </summary>
            [NameInMap("resourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

        }

    }

}
