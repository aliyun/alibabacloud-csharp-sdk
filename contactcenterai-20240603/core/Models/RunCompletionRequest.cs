// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ContactCenterAI20240603.Models
{
    public class RunCompletionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Dialogue")]
        [Validation(Required=false)]
        public RunCompletionRequestDialogue Dialogue { get; set; }
        public class RunCompletionRequestDialogue : TeaModel {
            [NameInMap("Sentences")]
            [Validation(Required=false)]
            public List<RunCompletionRequestDialogueSentences> Sentences { get; set; }
            public class RunCompletionRequestDialogueSentences : TeaModel {
                [NameInMap("ChatId")]
                [Validation(Required=false)]
                public string ChatId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>d25zc9c7004f8dad2b454d</para>
            /// </summary>
            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<RunCompletionRequestFields> Fields { get; set; }
        public class RunCompletionRequestFields : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>phoneNumber</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("EnumValues")]
            [Validation(Required=false)]
            public List<RunCompletionRequestFieldsEnumValues> EnumValues { get; set; }
            public class RunCompletionRequestFieldsEnumValues : TeaModel {
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("EnumValue")]
                [Validation(Required=false)]
                public string EnumValue { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ccai-14b</para>
        /// </summary>
        [NameInMap("ModelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        [NameInMap("ServiceInspection")]
        [Validation(Required=false)]
        public RunCompletionRequestServiceInspection ServiceInspection { get; set; }
        public class RunCompletionRequestServiceInspection : TeaModel {
            [NameInMap("InspectionContents")]
            [Validation(Required=false)]
            public List<RunCompletionRequestServiceInspectionInspectionContents> InspectionContents { get; set; }
            public class RunCompletionRequestServiceInspectionInspectionContents : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            [NameInMap("InspectionIntroduction")]
            [Validation(Required=false)]
            public string InspectionIntroduction { get; set; }

            [NameInMap("SceneIntroduction")]
            [Validation(Required=false)]
            public string SceneIntroduction { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TemplateIds")]
        [Validation(Required=false)]
        public List<long?> TemplateIds { get; set; }

        [NameInMap("variables")]
        [Validation(Required=false)]
        public List<RunCompletionRequestVariables> Variables { get; set; }
        public class RunCompletionRequestVariables : TeaModel {
            [NameInMap("variableCode")]
            [Validation(Required=false)]
            public string VariableCode { get; set; }

            [NameInMap("variableValue")]
            [Validation(Required=false)]
            public string VariableValue { get; set; }

        }

    }

}
