// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class ListTemplatesResponseBody : TeaModel {
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Templates")]
        [Validation(Required=false)]
        public List<ListTemplatesResponseBodyTemplates> Templates { get; set; }
        public class ListTemplatesResponseBodyTemplates : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("AppRevision")]
            [Validation(Required=false)]
            public string AppRevision { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("InputsExpression")]
            [Validation(Required=false)]
            public List<ListTemplatesResponseBodyTemplatesInputsExpression> InputsExpression { get; set; }
            public class ListTemplatesResponseBodyTemplatesInputsExpression : TeaModel {
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

            [NameInMap("LastModifiedTime")]
            [Validation(Required=false)]
            public string LastModifiedTime { get; set; }

            [NameInMap("OutputsExpression")]
            [Validation(Required=false)]
            public List<ListTemplatesResponseBodyTemplatesOutputsExpression> OutputsExpression { get; set; }
            public class ListTemplatesResponseBodyTemplatesOutputsExpression : TeaModel {
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

            [NameInMap("RevisionTag")]
            [Validation(Required=false)]
            public string RevisionTag { get; set; }

            [NameInMap("RootEntity")]
            [Validation(Required=false)]
            public string RootEntity { get; set; }

            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            [NameInMap("Workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
