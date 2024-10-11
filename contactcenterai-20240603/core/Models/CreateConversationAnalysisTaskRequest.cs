// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ContactCenterAI20240603.Models
{
    public class CreateConversationAnalysisTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("autoSplit")]
        [Validation(Required=false)]
        public int? AutoSplit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("clientChannel")]
        [Validation(Required=false)]
        public int? ClientChannel { get; set; }

        [NameInMap("examples")]
        [Validation(Required=false)]
        public CreateConversationAnalysisTaskRequestExamples Examples { get; set; }
        public class CreateConversationAnalysisTaskRequestExamples : TeaModel {
            [NameInMap("output")]
            [Validation(Required=false)]
            public string Output { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("sentences")]
            [Validation(Required=false)]
            public List<CreateConversationAnalysisTaskRequestExamplesSentences> Sentences { get; set; }
            public class CreateConversationAnalysisTaskRequestExamplesSentences : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>chat-01</para>
                /// </summary>
                [NameInMap("chatId")]
                [Validation(Required=false)]
                public string ChatId { get; set; }

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
        public List<CreateConversationAnalysisTaskRequestFields> Fields { get; set; }
        public class CreateConversationAnalysisTaskRequestFields : TeaModel {
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
            public List<CreateConversationAnalysisTaskRequestFieldsEnumValues> EnumValues { get; set; }
            public class CreateConversationAnalysisTaskRequestFieldsEnumValues : TeaModel {
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
        /// <para>audio.mp3</para>
        /// </summary>
        [NameInMap("fileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

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

        [NameInMap("sceneName")]
        [Validation(Required=false)]
        public string SceneName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("serviceChannel")]
        [Validation(Required=false)]
        public int? ServiceChannel { get; set; }

        [NameInMap("serviceChannelKeywords")]
        [Validation(Required=false)]
        public List<string> ServiceChannelKeywords { get; set; }

        [NameInMap("serviceInspection")]
        [Validation(Required=false)]
        public CreateConversationAnalysisTaskRequestServiceInspection ServiceInspection { get; set; }
        public class CreateConversationAnalysisTaskRequestServiceInspection : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("inspectionContents")]
            [Validation(Required=false)]
            public List<CreateConversationAnalysisTaskRequestServiceInspectionInspectionContents> InspectionContents { get; set; }
            public class CreateConversationAnalysisTaskRequestServiceInspectionInspectionContents : TeaModel {
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

        [NameInMap("templateIds")]
        [Validation(Required=false)]
        public List<string> TemplateIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://a.b.com/inner.mp3">http://a.b.com/inner.mp3</a></para>
        /// </summary>
        [NameInMap("voiceFileUrl")]
        [Validation(Required=false)]
        public string VoiceFileUrl { get; set; }

    }

}
