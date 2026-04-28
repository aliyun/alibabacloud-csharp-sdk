// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudGetRecordUrlRequest : TeaModel {
        /// <summary>
        /// <para>呼叫类型；说明：开启分线录音时，获取客户侧或座席侧录音需要，recordFormat=1时有效，recordFormat=0时忽略。取值范围：1,2,4,5（数字含义：呼入,webcall,预览外呼,预测外呼）</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("CallType")]
        [Validation(Required=false)]
        public long? CallType { get; set; }

        /// <summary>
        /// <para>是否下载；１为下载，空或０表示试听</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Download")]
        [Validation(Required=false)]
        public long? Download { get; set; }

        /// <summary>
        /// <para>呼叫中心 id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7000002</para>
        /// </summary>
        [NameInMap("EnterpriseId")]
        [Validation(Required=false)]
        public long? EnterpriseId { get; set; }

        /// <summary>
        /// <para>录音文件名；如7000101-20160815140025-01087120766-01087120766--record-sip-1-1471240825.87</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7000101-20160815140025-01087120766-01087120766--record-sip-1-1471240825.87</para>
        /// </summary>
        [NameInMap("RecordFile")]
        [Validation(Required=false)]
        public string RecordFile { get; set; }

        /// <summary>
        /// <para>录音文件类型；取值说明：0为mp3，1为wav，默认为mp3类型</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RecordFormat")]
        [Validation(Required=false)]
        public long? RecordFormat { get; set; }

        /// <summary>
        /// <para>分线录音录音侧；说明：开启分线录音时，获取客户侧或座席侧录音需要，recordFormat=1时有效，recordFormat=0时忽略。取值范围：1,2 (数字含义：客户侧，座席侧)recordSide不为空时，callType必选</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RecordSide")]
        [Validation(Required=false)]
        public long? RecordSide { get; set; }

        /// <summary>
        /// <para>录音类型，不填可根据 recordFile 解析；record:录音voicemail:留言tsi:彩铃、当开启号码录音状态识别，发起预览外呼，客户号码是手机且客户未接听时返回该地址 rasr:语音机器人客户侧录音 transfer:转接consult:咨询threeway:三方</para>
        /// 
        /// <b>Example:</b>
        /// <para>record</para>
        /// </summary>
        [NameInMap("RecordType")]
        [Validation(Required=false)]
        public string RecordType { get; set; }

    }

}
