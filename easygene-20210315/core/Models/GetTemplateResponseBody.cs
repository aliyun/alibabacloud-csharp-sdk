// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EasyGene20210315.Models
{
    public class GetTemplateResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>MyApp</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AppRevision")]
        [Validation(Required=false)]
        public string AppRevision { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-06-10T13:30:20.414557061Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test template</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>easygene.cn-beijing.aliyuncs.com</para>
        /// </summary>
        [NameInMap("HostId")]
        [Validation(Required=false)]
        public string HostId { get; set; }

        [NameInMap("InputsExpression")]
        [Validation(Required=false)]
        public List<GetTemplateResponseBodyInputsExpression> InputsExpression { get; set; }
        public class GetTemplateResponseBodyInputsExpression : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test help</para>
            /// </summary>
            [NameInMap("Help")]
            [Validation(Required=false)]
            public string Help { get; set; }

            /// <summary>
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
            public long? StepOrder { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Task1</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("VariableName")]
            [Validation(Required=false)]
            public string VariableName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>File</para>
            /// </summary>
            [NameInMap("VariableType")]
            [Validation(Required=false)]
            public string VariableType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss://bucket/file1.fastq</para>
            /// </summary>
            [NameInMap("VariableValue")]
            [Validation(Required=false)]
            public string VariableValue { get; set; }

        }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public Dictionary<string, string> Labels { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-06-10T13:30:20.405878292Z</para>
        /// </summary>
        [NameInMap("LastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        [NameInMap("OutputsExpression")]
        [Validation(Required=false)]
        public List<GetTemplateResponseBodyOutputsExpression> OutputsExpression { get; set; }
        public class GetTemplateResponseBodyOutputsExpression : TeaModel {
            [NameInMap("Help")]
            [Validation(Required=false)]
            public string Help { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
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
            public long? StepOrder { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>jobname</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>fastq1</para>
            /// </summary>
            [NameInMap("VariableName")]
            [Validation(Required=false)]
            public string VariableName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("VariableType")]
            [Validation(Required=false)]
            public string VariableType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>abc_1.fastq.gz</para>
            /// </summary>
            [NameInMap("VariableValue")]
            [Validation(Required=false)]
            public string VariableValue { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DA980AD0-158F-44F3-847D-5EAB96C0EB6B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>produceVersion</para>
        /// </summary>
        [NameInMap("RevisionTag")]
        [Validation(Required=false)]
        public string RevisionTag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-entity</para>
        /// </summary>
        [NameInMap("RootEntity")]
        [Validation(Required=false)]
        public string RootEntity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EasyGene</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-template</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-workspace</para>
        /// </summary>
        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
