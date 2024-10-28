// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class CreateTemplateRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyApp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4.1.4.1-v1.0</para>
        /// </summary>
        [NameInMap("AppRevision")]
        [Validation(Required=false)]
        public string AppRevision { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GFjZT93cy1mMDE4OTgxNGU1ZTkK</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

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
        public List<CreateTemplateRequestInputsExpression> InputsExpression { get; set; }
        public class CreateTemplateRequestInputsExpression : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test help</para>
            /// </summary>
            [NameInMap("Help")]
            [Validation(Required=false)]
            public string Help { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
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
            /// <para>File</para>
            /// </summary>
            [NameInMap("VariableType")]
            [Validation(Required=false)]
            public string VariableType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket/file1.fastq</para>
            /// </summary>
            [NameInMap("VariableValue")]
            [Validation(Required=false)]
            public string VariableValue { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;key1&quot;: &quot;value1&quot;}</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public string Labels { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OutputsExpression")]
        [Validation(Required=false)]
        public List<CreateTemplateRequestOutputsExpression> OutputsExpression { get; set; }
        public class CreateTemplateRequestOutputsExpression : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test help</para>
            /// </summary>
            [NameInMap("Help")]
            [Validation(Required=false)]
            public string Help { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
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
            /// <para>bam</para>
            /// </summary>
            [NameInMap("VariableName")]
            [Validation(Required=false)]
            public string VariableName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>File</para>
            /// </summary>
            [NameInMap("VariableType")]
            [Validation(Required=false)]
            public string VariableType { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket/file.bam</para>
            /// </summary>
            [NameInMap("VariableValue")]
            [Validation(Required=false)]
            public string VariableValue { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ProduceVersion</para>
        /// </summary>
        [NameInMap("RevisionTag")]
        [Validation(Required=false)]
        public string RevisionTag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TestEntity</para>
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
