// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListAnnotationMissionSessionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAnnotationMissionSessionResponseBodyData Data { get; set; }
        public class ListAnnotationMissionSessionResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>b3f2c931-5180-43ca-b4aa-2baee2d73c8b</para>
            /// </summary>
            [NameInMap("AnnotationMissionId")]
            [Validation(Required=false)]
            public string AnnotationMissionId { get; set; }

            [NameInMap("AnnotationMissionSessionList")]
            [Validation(Required=false)]
            public List<ListAnnotationMissionSessionResponseBodyDataAnnotationMissionSessionList> AnnotationMissionSessionList { get; set; }
            public class ListAnnotationMissionSessionResponseBodyDataAnnotationMissionSessionList : TeaModel {
                [NameInMap("AnnotationMissionChatList")]
                [Validation(Required=false)]
                public List<ListAnnotationMissionSessionResponseBodyDataAnnotationMissionSessionListAnnotationMissionChatList> AnnotationMissionChatList { get; set; }
                public class ListAnnotationMissionSessionResponseBodyDataAnnotationMissionSessionListAnnotationMissionChatList : TeaModel {
                    [NameInMap("AnnotationAsrResult")]
                    [Validation(Required=false)]
                    public string AnnotationAsrResult { get; set; }

                    [NameInMap("AnnotationMissionChatCustomizationDataInfoList")]
                    [Validation(Required=false)]
                    public List<ListAnnotationMissionSessionResponseBodyDataAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatCustomizationDataInfoList> AnnotationMissionChatCustomizationDataInfoList { get; set; }
                    public class ListAnnotationMissionSessionResponseBodyDataAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatCustomizationDataInfoList : TeaModel {
                        /// <summary>
                        /// <para>id</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionChatCustomizationDataInfoId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionChatCustomizationDataInfoId { get; set; }

                        /// <summary>
                        /// <para>chat id</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionChatId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionChatId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>2f03b24a-fda2-4501-90ba-0a9a59f8dd9d</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionId { get; set; }

                        [NameInMap("AnnotationMissionSessionId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionSessionId { get; set; }

                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Create")]
                        [Validation(Required=false)]
                        public bool? Create { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1682216045619</para>
                        /// </summary>
                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public long? CreateTime { get; set; }

                        [NameInMap("CustomizationDataDescription")]
                        [Validation(Required=false)]
                        public string CustomizationDataDescription { get; set; }

                        /// <summary>
                        /// <para>id</para>
                        /// </summary>
                        [NameInMap("CustomizationDataId")]
                        [Validation(Required=false)]
                        public string CustomizationDataId { get; set; }

                        [NameInMap("CustomizationDataName")]
                        [Validation(Required=false)]
                        public string CustomizationDataName { get; set; }

                        [NameInMap("CustomizationDataWeight")]
                        [Validation(Required=false)]
                        public int? CustomizationDataWeight { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Delete")]
                        [Validation(Required=false)]
                        public bool? Delete { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>d3fbfca8-4208-4d4b-a53a-c4dba5e43a66</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1679552585384</para>
                        /// </summary>
                        [NameInMap("ModifiedTime")]
                        [Validation(Required=false)]
                        public long? ModifiedTime { get; set; }

                    }

                    /// <summary>
                    /// <para>chat id</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>40669e52-c1c8-487f-9593-29749086bdc9</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionChatId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionChatId { get; set; }

                    [NameInMap("AnnotationMissionChatIntentUserSayInfoList")]
                    [Validation(Required=false)]
                    public List<ListAnnotationMissionSessionResponseBodyDataAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatIntentUserSayInfoList> AnnotationMissionChatIntentUserSayInfoList { get; set; }
                    public class ListAnnotationMissionSessionResponseBodyDataAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatIntentUserSayInfoList : TeaModel {
                        /// <summary>
                        /// <para>chat id</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionChatId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionChatId { get; set; }

                        /// <summary>
                        /// <para>id</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionChatIntentUserSayInfoId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionChatIntentUserSayInfoId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionSessionId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionSessionId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                        /// </summary>
                        [NameInMap("BotId")]
                        [Validation(Required=false)]
                        public string BotId { get; set; }

                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Create")]
                        [Validation(Required=false)]
                        public bool? Create { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1682216045619</para>
                        /// </summary>
                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public long? CreateTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Delete")]
                        [Validation(Required=false)]
                        public bool? Delete { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                        /// </summary>
                        [NameInMap("DialogId")]
                        [Validation(Required=false)]
                        public long? DialogId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                        /// </summary>
                        [NameInMap("IntentId")]
                        [Validation(Required=false)]
                        public long? IntentId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1682216045619</para>
                        /// </summary>
                        [NameInMap("ModifiedTime")]
                        [Validation(Required=false)]
                        public long? ModifiedTime { get; set; }

                    }

                    [NameInMap("AnnotationMissionChatTagInfoList")]
                    [Validation(Required=false)]
                    public List<ListAnnotationMissionSessionResponseBodyDataAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatTagInfoList> AnnotationMissionChatTagInfoList { get; set; }
                    public class ListAnnotationMissionSessionResponseBodyDataAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatTagInfoList : TeaModel {
                        /// <summary>
                        /// <para>chat id</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionChatId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionChatId { get; set; }

                        /// <summary>
                        /// <para>id</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionChatTagInfoId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionChatTagInfoId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>e7272cbb-a60d-4b41-b5c4-8863edc0b8f7</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionId { get; set; }

                        [NameInMap("AnnotationMissionSessionId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionSessionId { get; set; }

                        /// <summary>
                        /// <para>tag id</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionTagInfoId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionTagInfoId { get; set; }

                        [NameInMap("AnnotationMissionTagInfoName")]
                        [Validation(Required=false)]
                        public string AnnotationMissionTagInfoName { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Create")]
                        [Validation(Required=false)]
                        public bool? Create { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1686797050000</para>
                        /// </summary>
                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public long? CreateTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Delete")]
                        [Validation(Required=false)]
                        public bool? Delete { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>32be9d94-1346-4c4a-a4d0-ccd379f87013</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1679019660000</para>
                        /// </summary>
                        [NameInMap("ModifiedTime")]
                        [Validation(Required=false)]
                        public long? ModifiedTime { get; set; }

                    }

                    [NameInMap("AnnotationMissionChatVocabularyInfoList")]
                    [Validation(Required=false)]
                    public List<ListAnnotationMissionSessionResponseBodyDataAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatVocabularyInfoList> AnnotationMissionChatVocabularyInfoList { get; set; }
                    public class ListAnnotationMissionSessionResponseBodyDataAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatVocabularyInfoList : TeaModel {
                        /// <summary>
                        /// <para>chat id</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionChatId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionChatId { get; set; }

                        /// <summary>
                        /// <para>id</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionChatVocabularyInfoId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionChatVocabularyInfoId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>b3f2c931-5180-43ca-b4aa-2baee2d73c8b</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionSessionId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionSessionId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Create")]
                        [Validation(Required=false)]
                        public bool? Create { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1675218421941</para>
                        /// </summary>
                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public long? CreateTime { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Delete")]
                        [Validation(Required=false)]
                        public bool? Delete { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>818961ce-d9ba-4f88-89ca-2a04b24bdf01</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1676272557653</para>
                        /// </summary>
                        [NameInMap("ModifiedTime")]
                        [Validation(Required=false)]
                        public long? ModifiedTime { get; set; }

                        [NameInMap("Vocabulary")]
                        [Validation(Required=false)]
                        public string Vocabulary { get; set; }

                        [NameInMap("VocabularyDescription")]
                        [Validation(Required=false)]
                        public string VocabularyDescription { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                        /// </summary>
                        [NameInMap("VocabularyId")]
                        [Validation(Required=false)]
                        public string VocabularyId { get; set; }

                        [NameInMap("VocabularyName")]
                        [Validation(Required=false)]
                        public string VocabularyName { get; set; }

                        [NameInMap("VocabularyWeight")]
                        [Validation(Required=false)]
                        public int? VocabularyWeight { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>03f56192-fa8a-40dc-9558-39b357f0618f</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionId { get; set; }

                    [NameInMap("AnnotationMissionSessionId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionSessionId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("AnnotationStatus")]
                    [Validation(Required=false)]
                    public int? AnnotationStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>{\&quot;Answer\&quot;: u\&quot;\u53c2\u8003\u6587\u6863\uff1a<a href="https://help.aliyun.com/document_detail/215402.html%5C%5C">https://help.aliyun.com/document_detail/215402.html\\</a>&quot;, \&quot;QuestionId\&quot;: 371159, \&quot;Uuid\&quot;: \&quot;ac14000116781568127896224d0044\&quot;}</para>
                    /// </summary>
                    [NameInMap("Answer")]
                    [Validation(Required=false)]
                    public string Answer { get; set; }

                    [NameInMap("AsrAnnotationStatus")]
                    [Validation(Required=false)]
                    public int? AsrAnnotationStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1682216045619</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("IntentAnnotationStatus")]
                    [Validation(Required=false)]
                    public int? IntentAnnotationStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1571649300000</para>
                    /// </summary>
                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public long? ModifiedTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1682390676403</para>
                    /// </summary>
                    [NameInMap("OccurTime")]
                    [Validation(Required=false)]
                    public long? OccurTime { get; set; }

                    [NameInMap("OriginalAsrResult")]
                    [Validation(Required=false)]
                    public string OriginalAsrResult { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>380578077</para>
                    /// </summary>
                    [NameInMap("SequenceId")]
                    [Validation(Required=false)]
                    public string SequenceId { get; set; }

                    [NameInMap("SubStatus")]
                    [Validation(Required=false)]
                    public int? SubStatus { get; set; }

                    [NameInMap("TagAnnotationStatus")]
                    [Validation(Required=false)]
                    public int? TagAnnotationStatus { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TranslationError")]
                    [Validation(Required=false)]
                    public int? TranslationError { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>64ba5ac9-a4e1-4333-b03c-9d4a588c9f6c</para>
                /// </summary>
                [NameInMap("AnnotationMissionId")]
                [Validation(Required=false)]
                public string AnnotationMissionId { get; set; }

                /// <summary>
                /// <para>ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>64ba5ac9-a4e1-4333-b03c-9d4a588c9f6c</para>
                /// </summary>
                [NameInMap("AnnotationMissionSessionId")]
                [Validation(Required=false)]
                public string AnnotationMissionSessionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AnnotationStatus")]
                [Validation(Required=false)]
                public int? AnnotationStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1691117009000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DebugConversation")]
                [Validation(Required=false)]
                public bool? DebugConversation { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>a4274627-265f-4e14-b2d6-4ee7d4f8593e</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2f642da1-b00b-4dd6-ac7d-dcbeefd13ff3</para>
                /// </summary>
                [NameInMap("JobGroupId")]
                [Validation(Required=false)]
                public string JobGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>42da7cde-a5e8-45cc-b9d2-828711d95b30</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1677987898384</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public long? ModifiedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>408d6c4d-23e2-41f6-bbdd-f919a8297aa4</para>
                /// </summary>
                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>40669e52-c1c8-487f-9593-29749086bdc9</para>
                /// </summary>
                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>bp.java.nopowerContact</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bp.java.nopowerContact</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
