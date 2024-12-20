// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class SendCcoSmartCallRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ActionCodeBreak")]
        [Validation(Required=false)]
        public bool? ActionCodeBreak { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("ActionCodeTimeBreak")]
        [Validation(Required=false)]
        public int? ActionCodeTimeBreak { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("AsrAlsAmId")]
        [Validation(Required=false)]
        public string AsrAlsAmId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>customer_service_8k</para>
        /// </summary>
        [NameInMap("AsrBaseId")]
        [Validation(Required=false)]
        public string AsrBaseId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bf71664d30d2478fb8cb8c39c6b6****</para>
        /// </summary>
        [NameInMap("AsrModelId")]
        [Validation(Required=false)]
        public string AsrModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("AsrVocabularyId")]
        [Validation(Required=false)]
        public string AsrVocabularyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2d4c-4e78-8d2a-afbb06cf****.wav</para>
        /// </summary>
        [NameInMap("BackgroundFileCode")]
        [Validation(Required=false)]
        public string BackgroundFileCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BackgroundSpeed")]
        [Validation(Required=false)]
        public int? BackgroundSpeed { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BackgroundVolume")]
        [Validation(Required=false)]
        public int? BackgroundVolume { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>137****0000</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0571****0000</para>
        /// </summary>
        [NameInMap("CalledShowNumber")]
        [Validation(Required=false)]
        public string CalledShowNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("DynamicId")]
        [Validation(Required=false)]
        public string DynamicId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fasle</para>
        /// </summary>
        [NameInMap("EarlyMediaAsr")]
        [Validation(Required=false)]
        public bool? EarlyMediaAsr { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableITN")]
        [Validation(Required=false)]
        public bool? EnableITN { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("MuteTime")]
        [Validation(Required=false)]
        public int? MuteTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>222356****</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("PauseTime")]
        [Validation(Required=false)]
        public int? PauseTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PlayTimes")]
        [Validation(Required=false)]
        public int? PlayTimes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aiccs</para>
        /// </summary>
        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("RecordFlag")]
        [Validation(Required=false)]
        public bool? RecordFlag { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>120</para>
        /// </summary>
        [NameInMap("SessionTimeout")]
        [Validation(Required=false)]
        public int? SessionTimeout { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Speed")]
        [Validation(Required=false)]
        public int? Speed { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("TtsConf")]
        [Validation(Required=false)]
        public bool? TtsConf { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TtsSpeed")]
        [Validation(Required=false)]
        public int? TtsSpeed { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xiaoyun</para>
        /// </summary>
        [NameInMap("TtsStyle")]
        [Validation(Required=false)]
        public string TtsStyle { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TtsVolume")]
        [Validation(Required=false)]
        public int? TtsVolume { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2d4c-4e78-8d2a-afbb06cf****.wav,$name$</para>
        /// </summary>
        [NameInMap("VoiceCode")]
        [Validation(Required=false)]
        public string VoiceCode { get; set; }

        [NameInMap("VoiceCodeParam")]
        [Validation(Required=false)]
        public string VoiceCodeParam { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public int? Volume { get; set; }

    }

}
