/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ContactCenterAI20240603.Models
{
    public class RunCompletionRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
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
                /// This parameter is required.
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            [NameInMap("SessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<RunCompletionRequestFields> Fields { get; set; }
        public class RunCompletionRequestFields : TeaModel {
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
                /// This parameter is required.
                /// </summary>
                [NameInMap("EnumValue")]
                [Validation(Required=false)]
                public string EnumValue { get; set; }

            }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

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
                /// This parameter is required.
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

        [NameInMap("Stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TemplateIds")]
        [Validation(Required=false)]
        public List<long?> TemplateIds { get; set; }

    }

}
