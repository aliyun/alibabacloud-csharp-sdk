// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class UpdateTemplateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>This is a test template</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InputsExpression")]
        [Validation(Required=false)]
        public List<UpdateTemplateRequestInputsExpression> InputsExpression { get; set; }
        public class UpdateTemplateRequestInputsExpression : TeaModel {
            [NameInMap("Help")]
            [Validation(Required=false)]
            public string Help { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("StepOrder")]
            [Validation(Required=false)]
            public int? StepOrder { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Task1</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fastq1</para>
            /// </summary>
            [NameInMap("VariableName")]
            [Validation(Required=false)]
            public string VariableName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>String</para>
            /// </summary>
            [NameInMap("VariableType")]
            [Validation(Required=false)]
            public string VariableType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>read_1.fastq.gz</para>
            /// </summary>
            [NameInMap("VariableValue")]
            [Validation(Required=false)]
            public string VariableValue { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;key&quot;: &quot;value&quot;}</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OutputsExpression")]
        [Validation(Required=false)]
        public List<UpdateTemplateRequestOutputsExpression> OutputsExpression { get; set; }
        public class UpdateTemplateRequestOutputsExpression : TeaModel {
            [NameInMap("Help")]
            [Validation(Required=false)]
            public string Help { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            [NameInMap("StepOrder")]
            [Validation(Required=false)]
            public int? StepOrder { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Task1</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Bam</para>
            /// </summary>
            [NameInMap("VariableName")]
            [Validation(Required=false)]
            public string VariableName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>String</para>
            /// </summary>
            [NameInMap("VariableType")]
            [Validation(Required=false)]
            public string VariableType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>out.bam</para>
            /// </summary>
            [NameInMap("VariableValue")]
            [Validation(Required=false)]
            public string VariableValue { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-entity</para>
        /// </summary>
        [NameInMap("RootEntity")]
        [Validation(Required=false)]
        public string RootEntity { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-template</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-workspace</para>
        /// </summary>
        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
