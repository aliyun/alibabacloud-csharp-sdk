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
        /// <para>The ASR hotword ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6cc9f5ca-2cb6-4cc7-a46b-2bbfd3e61b22</para>
        /// </summary>
        [NameInMap("AsrClassVocabularyId")]
        [Validation(Required=false)]
        public string AsrClassVocabularyId { get; set; }

        /// <summary>
        /// <para>The dataset ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6cc9f5ca-2cb6-4cc7-a46b-2bbfd3e61b22</para>
        /// </summary>
        [NameInMap("AsrCustomizationId")]
        [Validation(Required=false)]
        public string AsrCustomizationId { get; set; }

        [NameInMap("AsrOverrides")]
        [Validation(Required=false)]
        public string AsrOverrides { get; set; }

        /// <summary>
        /// <para>The ASR error correction dictionary ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94001ae8-72fd-4f93-84dc-e58e2b20363b</para>
        /// </summary>
        [NameInMap("AsrOverridesUuid")]
        [Validation(Required=false)]
        public string AsrOverridesUuid { get; set; }

        /// <summary>
        /// <para>The hotword ID. You can view the ASR hotword ID on the <a href="https://aiccs.console.aliyun.com/sentence/vocab?spm=a2c4g.11186623.0.0.7f9bf965IKBpsi">ASR Hotword Management page</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6cc9f5ca-2cb6-4cc7-a46b-2bbfd3e61b22</para>
        /// </summary>
        [NameInMap("AsrVocabularyId")]
        [Validation(Required=false)]
        public string AsrVocabularyId { get; set; }

        /// <summary>
        /// <para>The policy level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: system.</description></item>
        /// <item><description>1: tenant.</description></item>
        /// <item><description>2: instance.</description></item>
        /// </list>
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
        /// <para>The entity ID corresponding to config_level.</para>
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
        /// <para>Speech Recognition</para>
        /// </summary>
        [NameInMap("NlsServiceType")]
        [Validation(Required=false)]
        public string NlsServiceType { get; set; }

    }

}
