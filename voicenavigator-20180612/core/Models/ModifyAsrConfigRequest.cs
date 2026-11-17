// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.VoiceNavigator20180612.Models
{
    public class ModifyAsrConfigRequest : TeaModel {
        /// <summary>
        /// <para>The AppKey of the engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>your_app_key</para>
        /// </summary>
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        /// <summary>
        /// <para>The ASR acoustic model ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6cc9f5ca-2cb6-4cc7-a46b-2bbfd3e61b22</para>
        /// </summary>
        [NameInMap("AsrAcousticModelId")]
        [Validation(Required=false)]
        public string AsrAcousticModelId { get; set; }

        /// <summary>
        /// <para>The ASR class vocabulary ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6cc9f5ca-2cb6-4cc7-a46b-2bbfd3e61b22</para>
        /// </summary>
        [NameInMap("AsrClassVocabularyId")]
        [Validation(Required=false)]
        public string AsrClassVocabularyId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the ASR context.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AsrContextEnabled")]
        [Validation(Required=false)]
        public bool? AsrContextEnabled { get; set; }

        /// <summary>
        /// <para>The dataset ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6cc9f5ca-2cb6-4cc7-a46b-2bbfd3e61b22</para>
        /// </summary>
        [NameInMap("AsrCustomizationId")]
        [Validation(Required=false)]
        public string AsrCustomizationId { get; set; }

        /// <summary>
        /// <para>The ASR error correction dictionary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;misrecognizedText&quot;:&quot;Hello&quot;,&quot;correctedText&quot;:&quot;Hi&quot;}]</para>
        /// </summary>
        [NameInMap("AsrOverrides")]
        [Validation(Required=false)]
        public string AsrOverrides { get; set; }

        /// <summary>
        /// <para>The ID of the ASR error correction dictionary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94001ae8-72fd-4f93-84dc-e58e2b20363b</para>
        /// </summary>
        [NameInMap("AsrOverridesUuid")]
        [Validation(Required=false)]
        public string AsrOverridesUuid { get; set; }

        /// <summary>
        /// <para>The hot word ID. You can view the ASR hot word ID on the <a href="https://aiccs.console.aliyun.com/sentence/vocab?spm=a2c4g.11186623.0.0.7f9bf965IKBpsi">ASR Hot Word Management page</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6cc9f5ca-2cb6-4cc7-a46b-2bbfd3e61b22</para>
        /// </summary>
        [NameInMap("AsrVocabularyId")]
        [Validation(Required=false)]
        public string AsrVocabularyId { get; set; }

        /// <summary>
        /// <para>The policy level. Valid values: 0: system, 1: tenant, 2: instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ConfigLevel")]
        [Validation(Required=false)]
        public int? ConfigLevel { get; set; }

        /// <summary>
        /// <para>The TTS engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ali</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The iFLYTEK ASR configuration parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Uuid&quot;:&quot;b06c4ed3-a5e3-4c55-92b7-c2d2a88ca37f&quot;}</para>
        /// </summary>
        [NameInMap("EngineXunfei")]
        [Validation(Required=false)]
        public string EngineXunfei { get; set; }

        /// <summary>
        /// <para>The entity ID corresponding to the config level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6cc9f5ca-2cb6-4cc7-a46b-2bbfd3e61b22</para>
        /// </summary>
        [NameInMap("EntryId")]
        [Validation(Required=false)]
        public string EntryId { get; set; }

        /// <summary>
        /// <para>NluServiceType</para>
        /// 
        /// <b>Example:</b>
        /// <para>Speech recognition</para>
        /// </summary>
        [NameInMap("NlsServiceType")]
        [Validation(Required=false)]
        public string NlsServiceType { get; set; }

    }

}
