// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ContactCenterAI20240603.Models
{
    public class CreateTaskRequest : TeaModel {
        [NameInMap("dialogue")]
        [Validation(Required=false)]
        public CreateTaskRequestDialogue Dialogue { get; set; }
        public class CreateTaskRequestDialogue : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("sentences")]
            [Validation(Required=false)]
            public List<CreateTaskRequestDialogueSentences> Sentences { get; set; }
            public class CreateTaskRequestDialogueSentences : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>session-01</para>
            /// </summary>
            [NameInMap("sessionId")]
            [Validation(Required=false)]
            public string SessionId { get; set; }

        }

        [NameInMap("examples")]
        [Validation(Required=false)]
        public CreateTaskRequestExamples Examples { get; set; }
        public class CreateTaskRequestExamples : TeaModel {
            [NameInMap("output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("sentences")]
            [Validation(Required=false)]
            public List<CreateTaskRequestExamplesSentences> Sentences { get; set; }
            public class CreateTaskRequestExamplesSentences : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("role")]
                [Validation(Required=false)]
                public string Role { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

        }

        [NameInMap("fields")]
        [Validation(Required=false)]
        public List<CreateTaskRequestFields> Fields { get; set; }
        public class CreateTaskRequestFields : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>phoneNumber</para>
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("enumValues")]
            [Validation(Required=false)]
            public List<CreateTaskRequestFieldsEnumValues> EnumValues { get; set; }
            public class CreateTaskRequestFieldsEnumValues : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("enumValue")]
                [Validation(Required=false)]
                public string EnumValue { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tyxmTurbo</para>
        /// </summary>
        [NameInMap("modelCode")]
        [Validation(Required=false)]
        public string ModelCode { get; set; }

        [NameInMap("resultTypes")]
        [Validation(Required=false)]
        public List<string> ResultTypes { get; set; }

        [NameInMap("serviceInspection")]
        [Validation(Required=false)]
        public CreateTaskRequestServiceInspection ServiceInspection { get; set; }
        public class CreateTaskRequestServiceInspection : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("inspectionContents")]
            [Validation(Required=false)]
            public List<CreateTaskRequestServiceInspectionInspectionContents> InspectionContents { get; set; }
            public class CreateTaskRequestServiceInspectionInspectionContents : TeaModel {
                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

            }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("inspectionIntroduction")]
            [Validation(Required=false)]
            public string InspectionIntroduction { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("sceneIntroduction")]
            [Validation(Required=false)]
            public string SceneIntroduction { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        [NameInMap("templateIds")]
        [Validation(Required=false)]
        public List<string> TemplateIds { get; set; }

        [NameInMap("transcription")]
        [Validation(Required=false)]
        public CreateTaskRequestTranscription Transcription { get; set; }
        public class CreateTaskRequestTranscription : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("autoSplit")]
            [Validation(Required=false)]
            public int? AutoSplit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("clientChannel")]
            [Validation(Required=false)]
            public int? ClientChannel { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sss.mp3</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("serviceChannel")]
            [Validation(Required=false)]
            public int? ServiceChannel { get; set; }

            [NameInMap("serviceChannelKeywords")]
            [Validation(Required=false)]
            public List<string> ServiceChannelKeywords { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://1111.com/sss.mp3">http://1111.com/sss.mp3</a></para>
            /// </summary>
            [NameInMap("voiceFileUrl")]
            [Validation(Required=false)]
            public string VoiceFileUrl { get; set; }

        }

    }

}
