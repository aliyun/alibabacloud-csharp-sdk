// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class UpdateTemplateRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InputsExpression")]
        [Validation(Required=false)]
        public List<UpdateTemplateRequestInputsExpression> InputsExpression { get; set; }
        public class UpdateTemplateRequestInputsExpression : TeaModel {
            [NameInMap("Help")]
            [Validation(Required=false)]
            public string Help { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            [NameInMap("StepOrder")]
            [Validation(Required=false)]
            public int? StepOrder { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("VariableName")]
            [Validation(Required=false)]
            public string VariableName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("VariableType")]
            [Validation(Required=false)]
            public string VariableType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("VariableValue")]
            [Validation(Required=false)]
            public string VariableValue { get; set; }

        }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("OutputsExpression")]
        [Validation(Required=false)]
        public List<UpdateTemplateRequestOutputsExpression> OutputsExpression { get; set; }
        public class UpdateTemplateRequestOutputsExpression : TeaModel {
            [NameInMap("Help")]
            [Validation(Required=false)]
            public string Help { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            [NameInMap("StepOrder")]
            [Validation(Required=false)]
            public int? StepOrder { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("VariableName")]
            [Validation(Required=false)]
            public string VariableName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("VariableType")]
            [Validation(Required=false)]
            public string VariableType { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("VariableValue")]
            [Validation(Required=false)]
            public string VariableValue { get; set; }

        }

        [NameInMap("RootEntity")]
        [Validation(Required=false)]
        public string RootEntity { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
