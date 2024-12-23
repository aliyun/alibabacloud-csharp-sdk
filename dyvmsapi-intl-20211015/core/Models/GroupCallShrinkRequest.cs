// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi_intl20211015.Models
{
    public class GroupCallShrinkRequest : TeaModel {
        /// <summary>
        /// <para>被叫号码。上限为5万个。</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumberShrink { get; set; }

        /// <summary>
        /// <para>主叫号码。  若您不填该参数，系统将会使用当地随机号码作为外显号码。 若您专属号码外呼，则必须传入已购买的号码，仅支持一个号码。您可以登录国际语音服务控制台，选择&quot;号码管理&quot;查看已购买的号码。</para>
        /// 
        /// <b>Example:</b>
        /// <para>852****1111</para>
        /// </summary>
        [NameInMap("CallerIdNumber")]
        [Validation(Required=false)]
        public string CallerIdNumber { get; set; }

        /// <summary>
        /// <para>国家/地区二字码，ISO2。</para>
        /// 
        /// <b>Example:</b>
        /// <para>HK</para>
        /// </summary>
        [NameInMap("CountryId")]
        [Validation(Required=false)]
        public string CountryId { get; set; }

        /// <summary>
        /// <para>预留给调用方使用的ID，最终会通过在回执消息中将此ID带回给调用方。  字符串类型，长度为1~15个字节。</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>语音文件的播放次数。取值范围：1~3。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PlayTimes")]
        [Validation(Required=false)]
        public long? PlayTimes { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>发送类型：取值[1,2]。  1： 立即开始发送任务，不等待。  2： 定时开始发送任务。如果传该类型，TimingStart为必选字段。</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("SendType")]
        [Validation(Required=false)]
        public long? SendType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>s****************D</para>
        /// </summary>
        [NameInMap("Signature")]
        [Validation(Required=false)]
        public string Signature { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>l*********y</para>
        /// </summary>
        [NameInMap("SignatureNonce")]
        [Validation(Required=false)]
        public string SignatureNonce { get; set; }

        /// <summary>
        /// <para>语速控制，取值范围：-500~500。  音频类型为TTS时必传。录音文件可不传。</para>
        /// 
        /// <b>Example:</b>
        /// <para>94</para>
        /// </summary>
        [NameInMap("Speed")]
        [Validation(Required=false)]
        public long? Speed { get; set; }

        /// <summary>
        /// <para>任务名称。</para>
        /// 
        /// <b>Example:</b>
        /// <para>群呼任务</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20**-**-******10Z</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public string Timestamp { get; set; }

        /// <summary>
        /// <para>2022-05-01T08:00:00+08:00</para>
        /// 
        /// <b>Example:</b>
        /// <para>定时发送的时间。</para>
        /// </summary>
        [NameInMap("TimingStart")]
        [Validation(Required=false)]
        public string TimingStart { get; set; }

        /// <summary>
        /// <para>文本转语音的模板ID。  您可以登录国际语音服务控制台，选择&quot;语音模板管理&quot;-&quot;文本转语音模板&quot;，查看模板ID。  此参数与VoiceCode二选一必填。分别代表使用语音文件作为呼叫内容呼叫或者使用固定模板文字作为呼叫内容。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1****01</para>
        /// </summary>
        [NameInMap("TtsCode")]
        [Validation(Required=false)]
        public string TtsCode { get; set; }

        /// <summary>
        /// <para>模板中的变量参数，JSON格式。</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;code&quot;:&quot;1234&quot;}</para>
        /// </summary>
        [NameInMap("TtsParam")]
        [Validation(Required=false)]
        public string TtsParam { get; set; }

        /// <summary>
        /// <para>语音文件的模板ID。  您可以登录国际语音服务控制台，选择&quot;语音模板管理&quot;-&quot;语音文件&quot;，查看模板ID。  此参数与TtsCode二选一必填。分别代表使用语音文件作为呼叫内容呼叫或者使用固定模板文字作为呼叫内容。</para>
        /// 
        /// <b>Example:</b>
        /// <para>2*****01</para>
        /// </summary>
        [NameInMap("VoiceCode")]
        [Validation(Required=false)]
        public string VoiceCode { get; set; }

        /// <summary>
        /// <para>语音文件播放的音量。取值范围：0~100，默认取值100。</para>
        /// 
        /// <b>Example:</b>
        /// <para>11</para>
        /// </summary>
        [NameInMap("Volume")]
        [Validation(Required=false)]
        public long? Volume { get; set; }

    }

}
