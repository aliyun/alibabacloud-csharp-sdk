// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListAnnotationMissionSessionResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code of the API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAnnotationMissionSessionResponseBodyData Data { get; set; }
        public class ListAnnotationMissionSessionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>b3f2c931-5180-43ca-b4aa-2baee2d73c8b</para>
            /// </summary>
            [NameInMap("AnnotationMissionId")]
            [Validation(Required=false)]
            public string AnnotationMissionId { get; set; }

            /// <summary>
            /// <para>The list of sessions.</para>
            /// </summary>
            [NameInMap("AnnotationMissionSessionList")]
            [Validation(Required=false)]
            public List<ListAnnotationMissionSessionResponseBodyDataAnnotationMissionSessionList> AnnotationMissionSessionList { get; set; }
            public class ListAnnotationMissionSessionResponseBodyDataAnnotationMissionSessionList : TeaModel {
                /// <summary>
                /// <para>The list of chats.</para>
                /// </summary>
                [NameInMap("AnnotationMissionChatList")]
                [Validation(Required=false)]
                public List<ListAnnotationMissionSessionResponseBodyDataAnnotationMissionSessionListAnnotationMissionChatList> AnnotationMissionChatList { get; set; }
                public class ListAnnotationMissionSessionResponseBodyDataAnnotationMissionSessionListAnnotationMissionChatList : TeaModel {
                    /// <summary>
                    /// <para>The result of manual ASR annotation, used to calculate character accuracy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[]</para>
                    /// </summary>
                    [NameInMap("AnnotationAsrResult")]
                    [Validation(Required=false)]
                    public string AnnotationAsrResult { get; set; }

                    /// <summary>
                    /// <para>The table of language model annotation information for the annotation task chat.</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionChatCustomizationDataInfoList")]
                    [Validation(Required=false)]
                    public List<ListAnnotationMissionSessionResponseBodyDataAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatCustomizationDataInfoList> AnnotationMissionChatCustomizationDataInfoList { get; set; }
                    public class ListAnnotationMissionSessionResponseBodyDataAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatCustomizationDataInfoList : TeaModel {
                        /// <summary>
                        /// <para>The ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>03f56192-fa8a-40dc-9558-39b357f0618f</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionChatCustomizationDataInfoId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionChatCustomizationDataInfoId { get; set; }

                        /// <summary>
                        /// <para>The chat ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>03f56192-fa8a-40dc-9558-39b357f0618f</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionChatId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionChatId { get; set; }

                        /// <summary>
                        /// <para>The task ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2f03b24a-fda2-4501-90ba-0a9a59f8dd9d</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionId { get; set; }

                        /// <summary>
                        /// <para>The session ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>03f56192-fa8a-40dc-9558-39b357f0618f</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionSessionId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionSessionId { get; set; }

                        /// <summary>
                        /// <para>The text of the voice annotation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>抱歉哈，可能给您造成困扰了，这边先不打扰您，祝您生活愉快，再见</para>
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the data is created.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Create")]
                        [Validation(Required=false)]
                        public bool? Create { get; set; }

                        /// <summary>
                        /// <para>The time when the information was created.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1682216045619</para>
                        /// </summary>
                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public long? CreateTime { get; set; }

                        /// <summary>
                        /// <para>The description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>默认数据</para>
                        /// </summary>
                        [NameInMap("CustomizationDataDescription")]
                        [Validation(Required=false)]
                        public string CustomizationDataDescription { get; set; }

                        /// <summary>
                        /// <para>The custom data ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>03f56192-fa8a-40dc-9558-39b357f0618f</para>
                        /// </summary>
                        [NameInMap("CustomizationDataId")]
                        [Validation(Required=false)]
                        public string CustomizationDataId { get; set; }

                        /// <summary>
                        /// <para>The name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>默认数据</para>
                        /// </summary>
                        [NameInMap("CustomizationDataName")]
                        [Validation(Required=false)]
                        public string CustomizationDataName { get; set; }

                        /// <summary>
                        /// <para>The weight of the language model data.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("CustomizationDataWeight")]
                        [Validation(Required=false)]
                        public int? CustomizationDataWeight { get; set; }

                        /// <summary>
                        /// <para>Indicates whether the data is deleted.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Delete")]
                        [Validation(Required=false)]
                        public bool? Delete { get; set; }

                        /// <summary>
                        /// <para>The instance ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>d3fbfca8-4208-4d4b-a53a-c4dba5e43a66</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>The time when the information was last modified.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1679552585384</para>
                        /// </summary>
                        [NameInMap("ModifiedTime")]
                        [Validation(Required=false)]
                        public long? ModifiedTime { get; set; }

                    }

                    /// <summary>
                    /// <para>The chat ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>40669e52-c1c8-487f-9593-29749086bdc9</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionChatId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionChatId { get; set; }

                    /// <summary>
                    /// <para>The list of chat intents.</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionChatIntentUserSayInfoList")]
                    [Validation(Required=false)]
                    public List<ListAnnotationMissionSessionResponseBodyDataAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatIntentUserSayInfoList> AnnotationMissionChatIntentUserSayInfoList { get; set; }
                    public class ListAnnotationMissionSessionResponseBodyDataAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatIntentUserSayInfoList : TeaModel {
                        /// <summary>
                        /// <para>The chat ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionChatId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionChatId { get; set; }

                        /// <summary>
                        /// <para>The ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>03f56192-fa8a-40dc-9558-39b357f0618f</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionChatIntentUserSayInfoId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionChatIntentUserSayInfoId { get; set; }

                        /// <summary>
                        /// <para>The annotation task ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionId { get; set; }

                        /// <summary>
                        /// <para>The session ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionSessionId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionSessionId { get; set; }

                        /// <summary>
                        /// <para>The bot ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                        /// </summary>
                        [NameInMap("BotId")]
                        [Validation(Required=false)]
                        public string BotId { get; set; }

                        /// <summary>
                        /// <para>The modified query.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>[]</para>
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// <para>Created.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("Create")]
                        [Validation(Required=false)]
                        public bool? Create { get; set; }

                        /// <summary>
                        /// <para>The time when the intent was created.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1682216045619</para>
                        /// </summary>
                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public long? CreateTime { get; set; }

                        /// <summary>
                        /// <para>Deleted</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Delete")]
                        [Validation(Required=false)]
                        public bool? Delete { get; set; }

                        /// <summary>
                        /// <para>The dialog ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>29921312</para>
                        /// </summary>
                        [NameInMap("DialogId")]
                        [Validation(Required=false)]
                        public long? DialogId { get; set; }

                        /// <summary>
                        /// <para>The instance ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>The intent ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>11234112</para>
                        /// </summary>
                        [NameInMap("IntentId")]
                        [Validation(Required=false)]
                        public long? IntentId { get; set; }

                        /// <summary>
                        /// <para>The time when the intent was last modified.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1682216045619</para>
                        /// </summary>
                        [NameInMap("ModifiedTime")]
                        [Validation(Required=false)]
                        public long? ModifiedTime { get; set; }

                    }

                    /// <summary>
                    /// <para>The list of mappings between chat annotation information and attached tags.</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionChatTagInfoList")]
                    [Validation(Required=false)]
                    public List<ListAnnotationMissionSessionResponseBodyDataAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatTagInfoList> AnnotationMissionChatTagInfoList { get; set; }
                    public class ListAnnotationMissionSessionResponseBodyDataAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatTagInfoList : TeaModel {
                        /// <summary>
                        /// <para>The chat ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>03f56192-fa8a-40dc-9558-39b357f0618f</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionChatId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionChatId { get; set; }

                        /// <summary>
                        /// <para>The ID of the chat tag information for the comment.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>03f56192-fa8a-40dc-9558-39b357f0618f</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionChatTagInfoId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionChatTagInfoId { get; set; }

                        /// <summary>
                        /// <para>The task ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>e7272cbb-a60d-4b41-b5c4-8863edc0b8f7</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionId { get; set; }

                        /// <summary>
                        /// <para>The session ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>03f56192-fa8a-40dc-9558-39b357f0618f</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionSessionId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionSessionId { get; set; }

                        /// <summary>
                        /// <para>The tag ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>03f56192-fa8a-40dc-9558-39b357f0618f</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionTagInfoId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionTagInfoId { get; set; }

                        /// <summary>
                        /// <para>The tag name.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>标签</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionTagInfoName")]
                        [Validation(Required=false)]
                        public string AnnotationMissionTagInfoName { get; set; }

                        /// <summary>
                        /// <para>Create</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Create")]
                        [Validation(Required=false)]
                        public bool? Create { get; set; }

                        /// <summary>
                        /// <para>The time when the tag was created.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1686797050000</para>
                        /// </summary>
                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public long? CreateTime { get; set; }

                        /// <summary>
                        /// <para>Delete.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Delete")]
                        [Validation(Required=false)]
                        public bool? Delete { get; set; }

                        /// <summary>
                        /// <para>The instance ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>32be9d94-1346-4c4a-a4d0-ccd379f87013</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>The time when the tag was last modified.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1679019660000</para>
                        /// </summary>
                        [NameInMap("ModifiedTime")]
                        [Validation(Required=false)]
                        public long? ModifiedTime { get; set; }

                    }

                    /// <summary>
                    /// <para>The table of hotword annotation information for the annotation task chat.</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionChatVocabularyInfoList")]
                    [Validation(Required=false)]
                    public List<ListAnnotationMissionSessionResponseBodyDataAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatVocabularyInfoList> AnnotationMissionChatVocabularyInfoList { get; set; }
                    public class ListAnnotationMissionSessionResponseBodyDataAnnotationMissionSessionListAnnotationMissionChatListAnnotationMissionChatVocabularyInfoList : TeaModel {
                        /// <summary>
                        /// <para>The chat ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionChatId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionChatId { get; set; }

                        /// <summary>
                        /// <para>The ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>03f56192-fa8a-40dc-9558-39b357f0618f</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionChatVocabularyInfoId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionChatVocabularyInfoId { get; set; }

                        /// <summary>
                        /// <para>The task ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>b3f2c931-5180-43ca-b4aa-2baee2d73c8b</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionId { get; set; }

                        /// <summary>
                        /// <para>The session ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                        /// </summary>
                        [NameInMap("AnnotationMissionSessionId")]
                        [Validation(Required=false)]
                        public string AnnotationMissionSessionId { get; set; }

                        /// <summary>
                        /// <para>Created</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Create")]
                        [Validation(Required=false)]
                        public bool? Create { get; set; }

                        /// <summary>
                        /// <para>The time when the resource was created.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1675218421941</para>
                        /// </summary>
                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public long? CreateTime { get; set; }

                        /// <summary>
                        /// <para>Deleted</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>true</para>
                        /// </summary>
                        [NameInMap("Delete")]
                        [Validation(Required=false)]
                        public bool? Delete { get; set; }

                        /// <summary>
                        /// <para>The instance ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>818961ce-d9ba-4f88-89ca-2a04b24bdf01</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>The time when the hotword was last modified.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1676272557653</para>
                        /// </summary>
                        [NameInMap("ModifiedTime")]
                        [Validation(Required=false)]
                        public long? ModifiedTime { get; set; }

                        /// <summary>
                        /// <para>The content of the hotword annotation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>[]</para>
                        /// </summary>
                        [NameInMap("Vocabulary")]
                        [Validation(Required=false)]
                        public string Vocabulary { get; set; }

                        /// <summary>
                        /// <para>The description.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>描述</para>
                        /// </summary>
                        [NameInMap("VocabularyDescription")]
                        [Validation(Required=false)]
                        public string VocabularyDescription { get; set; }

                        /// <summary>
                        /// <para>The hotword ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                        /// </summary>
                        [NameInMap("VocabularyId")]
                        [Validation(Required=false)]
                        public string VocabularyId { get; set; }

                        /// <summary>
                        /// <para>The name of the vocabulary.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>名称</para>
                        /// </summary>
                        [NameInMap("VocabularyName")]
                        [Validation(Required=false)]
                        public string VocabularyName { get; set; }

                        /// <summary>
                        /// <para>The weight of the hotword. The value ranges from -6 to 5.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("VocabularyWeight")]
                        [Validation(Required=false)]
                        public int? VocabularyWeight { get; set; }

                    }

                    /// <summary>
                    /// <para>The task ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>03f56192-fa8a-40dc-9558-39b357f0618f</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionId { get; set; }

                    /// <summary>
                    /// <para>The session ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>03f56192-fa8a-40dc-9558-39b357f0618f</para>
                    /// </summary>
                    [NameInMap("AnnotationMissionSessionId")]
                    [Validation(Required=false)]
                    public string AnnotationMissionSessionId { get; set; }

                    /// <summary>
                    /// <para>The annotation status of the chat.</para>
                    /// <list type="bullet">
                    /// <item><description><para>0: UNDO</para>
                    /// </description></item>
                    /// <item><description><para>1: DOING</para>
                    /// </description></item>
                    /// <item><description><para>2: DONE</para>
                    /// </description></item>
                    /// <item><description><para>3: CLOSED</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("AnnotationStatus")]
                    [Validation(Required=false)]
                    public int? AnnotationStatus { get; set; }

                    /// <summary>
                    /// <para>The content of the bot\&quot;s reply.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{\&quot;Answer\&quot;: u\&quot;\u53c2\u8003\u6587\u6863\uff1a<a href="https://help.aliyun.com/document_detail/215402.html%5C%5C">https://help.aliyun.com/document_detail/215402.html\\</a>&quot;, \&quot;QuestionId\&quot;: 371159, \&quot;Uuid\&quot;: \&quot;ac14000116781568127896224d0044\&quot;}</para>
                    /// </summary>
                    [NameInMap("Answer")]
                    [Validation(Required=false)]
                    public string Answer { get; set; }

                    /// <summary>
                    /// <para>The status of Automatic Speech Recognition (ASR) annotation.</para>
                    /// <list type="bullet">
                    /// <item><description><para>0: UNDO</para>
                    /// </description></item>
                    /// <item><description><para>1: DOING</para>
                    /// </description></item>
                    /// <item><description><para>2: DONE</para>
                    /// </description></item>
                    /// <item><description><para>3: CLOSED</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("AsrAnnotationStatus")]
                    [Validation(Required=false)]
                    public int? AsrAnnotationStatus { get; set; }

                    /// <summary>
                    /// <para>The time when the chat was created.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1682216045619</para>
                    /// </summary>
                    [NameInMap("CreateTime")]
                    [Validation(Required=false)]
                    public long? CreateTime { get; set; }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>77343553-cbc2-4487-a35c-869f1e86c573</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    /// <summary>
                    /// <para>The status of semantic tagging.</para>
                    /// <list type="bullet">
                    /// <item><description><para>0: UNDO</para>
                    /// </description></item>
                    /// <item><description><para>1: DOING</para>
                    /// </description></item>
                    /// <item><description><para>2: DONE</para>
                    /// </description></item>
                    /// <item><description><para>3: CLOSED</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("IntentAnnotationStatus")]
                    [Validation(Required=false)]
                    public int? IntentAnnotationStatus { get; set; }

                    /// <summary>
                    /// <para>The time when the chat was last modified.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1571649300000</para>
                    /// </summary>
                    [NameInMap("ModifiedTime")]
                    [Validation(Required=false)]
                    public long? ModifiedTime { get; set; }

                    /// <summary>
                    /// <para>The time when the chat was triggered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1682390676403</para>
                    /// </summary>
                    [NameInMap("OccurTime")]
                    [Validation(Required=false)]
                    public long? OccurTime { get; set; }

                    /// <summary>
                    /// <para>The ASR result.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[]</para>
                    /// </summary>
                    [NameInMap("OriginalAsrResult")]
                    [Validation(Required=false)]
                    public string OriginalAsrResult { get; set; }

                    /// <summary>
                    /// <para>The sequence ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>380578077</para>
                    /// </summary>
                    [NameInMap("SequenceId")]
                    [Validation(Required=false)]
                    public string SequenceId { get; set; }

                    /// <summary>
                    /// <para>The annotation action. 1: Correct. 20: Matching error, not optimized. 21: Matching error, optimized. 3: Uncovered. 4: Invalid.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("SubStatus")]
                    [Validation(Required=false)]
                    public int? SubStatus { get; set; }

                    /// <summary>
                    /// <para>The status of tag annotation.</para>
                    /// <list type="bullet">
                    /// <item><description><para>0: UNDO</para>
                    /// </description></item>
                    /// <item><description><para>1: DOING</para>
                    /// </description></item>
                    /// <item><description><para>2: DONE</para>
                    /// </description></item>
                    /// <item><description><para>3: CLOSED</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TagAnnotationStatus")]
                    [Validation(Required=false)]
                    public int? TagAnnotationStatus { get; set; }

                    /// <summary>
                    /// <para>Indicates a transcription error.</para>
                    /// <list type="bullet">
                    /// <item><description><para>0: No</para>
                    /// </description></item>
                    /// <item><description><para>1: Yes</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TranslationError")]
                    [Validation(Required=false)]
                    public int? TranslationError { get; set; }

                }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>64ba5ac9-a4e1-4333-b03c-9d4a588c9f6c</para>
                /// </summary>
                [NameInMap("AnnotationMissionId")]
                [Validation(Required=false)]
                public string AnnotationMissionId { get; set; }

                /// <summary>
                /// <para>The session ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>64ba5ac9-a4e1-4333-b03c-9d4a588c9f6c</para>
                /// </summary>
                [NameInMap("AnnotationMissionSessionId")]
                [Validation(Required=false)]
                public string AnnotationMissionSessionId { get; set; }

                /// <summary>
                /// <para>The annotation status.</para>
                /// <list type="bullet">
                /// <item><description><para>0: UNDO</para>
                /// </description></item>
                /// <item><description><para>1: DOING</para>
                /// </description></item>
                /// <item><description><para>2: DONE</para>
                /// </description></item>
                /// <item><description><para>3: CLOSED</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AnnotationStatus")]
                [Validation(Required=false)]
                public int? AnnotationStatus { get; set; }

                /// <summary>
                /// <para>The time when the session was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1691117009000</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// <para>Debug conversation</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("DebugConversation")]
                [Validation(Required=false)]
                public bool? DebugConversation { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>a4274627-265f-4e14-b2d6-4ee7d4f8593e</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The task group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2f642da1-b00b-4dd6-ac7d-dcbeefd13ff3</para>
                /// </summary>
                [NameInMap("JobGroupId")]
                [Validation(Required=false)]
                public string JobGroupId { get; set; }

                /// <summary>
                /// <para>The task ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>42da7cde-a5e8-45cc-b9d2-828711d95b30</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The time when the session was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1677987898384</para>
                /// </summary>
                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public long? ModifiedTime { get; set; }

                /// <summary>
                /// <para>The scenario ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>408d6c4d-23e2-41f6-bbdd-f919a8297aa4</para>
                /// </summary>
                [NameInMap("ScriptId")]
                [Validation(Required=false)]
                public string ScriptId { get; set; }

                /// <summary>
                /// <para>The ID of the task in the outbound call system, or the ID of the conversation in the navigation system.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40669e52-c1c8-487f-9593-29749086bdc9</para>
                /// </summary>
                [NameInMap("SessionId")]
                [Validation(Required=false)]
                public string SessionId { get; set; }

                /// <summary>
                /// <para>The version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

            /// <summary>
            /// <para>Additional information. If the call is successful, \<c>success\\</c> is returned. If the call fails, a specific error code is returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bp.java.nopowerContact</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Indicates whether the call was successful. \<c>true\\</c> indicates success. \<c>false\\</c> indicates failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Additional information. If the call is successful, \<c>success\\</c> is returned. If the call fails, a specific error code is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bp.java.nopowerContact</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. A value of \<c>true\\</c> indicates success. A value of \<c>false\\</c> indicates failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
