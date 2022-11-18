// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class GetAppResponseBody : TeaModel {
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        [NameInMap("Configs")]
        [Validation(Required=false)]
        public List<GetAppResponseBodyConfigs> Configs { get; set; }
        public class GetAppResponseBodyConfigs : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("Definition")]
        [Validation(Required=false)]
        public string Definition { get; set; }

        [NameInMap("Dependencies")]
        [Validation(Required=false)]
        public List<GetAppResponseBodyDependencies> Dependencies { get; set; }
        public class GetAppResponseBodyDependencies : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

        }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Documentation")]
        [Validation(Required=false)]
        public string Documentation { get; set; }

        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public List<GetAppResponseBodyInputs> Inputs { get; set; }
        public class GetAppResponseBodyInputs : TeaModel {
            [NameInMap("Help")]
            [Validation(Required=false)]
            public string Help { get; set; }

            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            [NameInMap("StepOrder")]
            [Validation(Required=false)]
            public long? StepOrder { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("VariableName")]
            [Validation(Required=false)]
            public string VariableName { get; set; }

            [NameInMap("VariableType")]
            [Validation(Required=false)]
            public string VariableType { get; set; }

            [NameInMap("VariableValue")]
            [Validation(Required=false)]
            public string VariableValue { get; set; }

        }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> Labels { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("LanguageVersion")]
        [Validation(Required=false)]
        public string LanguageVersion { get; set; }

        [NameInMap("LastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public List<GetAppResponseBodyOutputs> Outputs { get; set; }
        public class GetAppResponseBodyOutputs : TeaModel {
            [NameInMap("Help")]
            [Validation(Required=false)]
            public string Help { get; set; }

            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            [NameInMap("StepOrder")]
            [Validation(Required=false)]
            public long? StepOrder { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("VariableName")]
            [Validation(Required=false)]
            public string VariableName { get; set; }

            [NameInMap("VariableType")]
            [Validation(Required=false)]
            public string VariableType { get; set; }

            [NameInMap("VariableValue")]
            [Validation(Required=false)]
            public string VariableValue { get; set; }

        }

        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Revision")]
        [Validation(Required=false)]
        public string Revision { get; set; }

        [NameInMap("RevisionComment")]
        [Validation(Required=false)]
        public string RevisionComment { get; set; }

        [NameInMap("Revisions")]
        [Validation(Required=false)]
        public List<GetAppResponseBodyRevisions> Revisions { get; set; }
        public class GetAppResponseBodyRevisions : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Revision")]
            [Validation(Required=false)]
            public string Revision { get; set; }

            [NameInMap("RevisionComment")]
            [Validation(Required=false)]
            public string RevisionComment { get; set; }

        }

        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("URL")]
        [Validation(Required=false)]
        public string URL { get; set; }

        [NameInMap("WorkflowName")]
        [Validation(Required=false)]
        public string WorkflowName { get; set; }

        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
