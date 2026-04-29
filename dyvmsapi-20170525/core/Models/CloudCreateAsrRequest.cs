// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudCreateAsrRequest : TeaModel {
        /// <summary>
        /// <para>通话类型；1:呼入,2:webcall,4:预览外呼,5:预测外呼,6:主叫外呼,9:内部呼叫</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CallType")]
        [Validation(Required=false)]
        public long? CallType { get; set; }

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
        /// <para>主通道的唯一标识</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sip-2-1489989807.36601</para>
        /// </summary>
        [NameInMap("MainUniqueId")]
        [Validation(Required=false)]
        public string MainUniqueId { get; set; }

        /// <summary>
        /// <para>录音文件名；例: 7000002-20170320140327-1581-1500-record-sip-2-148998.366</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7000002-20170320140327-1581-1500-record-sip-2-148998.366</para>
        /// </summary>
        [NameInMap("RecordFile")]
        [Validation(Required=false)]
        public string RecordFile { get; set; }

        /// <summary>
        /// <para>录音通道类型；取值范围：0：混音 1：分线录音时客户侧,2：分线录音时座席侧,3:分线录音时客户侧和座席侧</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("RecordSide")]
        [Validation(Required=false)]
        public long? RecordSide { get; set; }

        /// <summary>
        /// <para>语音文件类型,取值：record,voicemail 说明：record是录音， voicemail是留言</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>record</para>
        /// </summary>
        [NameInMap("RecordType")]
        [Validation(Required=false)]
        public string RecordType { get; set; }

        /// <summary>
        /// <para>当wav过期时，是否支持使用mp3进行转写；0-不支持（默认）；1-代表支持，如果通话wav过期，则自动使用mp3转写，转写结果中通道类型会被设置为混音类型；混音mp3无法区分两侧，双声道mp3可以区分两侧内容</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SupportMp3")]
        [Validation(Required=false)]
        public string SupportMp3 { get; set; }

        /// <summary>
        /// <para>从通道的唯一标识</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sip-2-1489989807.36601</para>
        /// </summary>
        [NameInMap("UniqueId")]
        [Validation(Required=false)]
        public string UniqueId { get; set; }

    }

}
