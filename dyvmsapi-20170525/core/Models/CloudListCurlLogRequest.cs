// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudListCurlLogRequest : TeaModel {
        /// <summary>
        /// <para>查询结束时间；格式:&quot;yyyy-MM-dd HH:mm:ss&quot;,精确到s。startTime与endTime不允许跨月，默认值取当前月份最后一天</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-23 10:00:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

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
        /// <para>需要取出的数据条数；大于0，最大不能超过500，默认10</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public string Limit { get; set; }

        /// <summary>
        /// <para>推送结果；取值：1、成功，0、失败</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public long? Result { get; set; }

        /// <summary>
        /// <para>重试次数；默认-2</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Retry")]
        [Validation(Required=false)]
        public long? Retry { get; set; }

        /// <summary>
        /// <para>从第几条开始取；大于等于0，默认0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Start")]
        [Validation(Required=false)]
        public string Start { get; set; }

        /// <summary>
        /// <para>查询开始时间；格式:&quot;yyyy-MM-dd HH:mm:ss&quot;,精确到s。startTime与endTime不允许跨月，默认值取当前月份第一天</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-20 10:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>推送类型；1:来电推送、2:来电响铃推送、3:外呼响铃推送、4:webcall转座席响铃推送、5:来电接通推送、6:外呼接通推送、7:来电挂机推送、8:外呼挂机推送、9:座席状态推送、10:按键推送、11:号码状态识别推送、12:录音状态推送、13:HTTP交互推送、15:ASR语音转换结果推送、14:预测式外呼任务推送、16:webcall客户侧响铃推送、17:满意度调查推送、18:预测外呼客户接听状态推送、19:NLU推送、20:预测外呼双方接听推送、21:IVR交互结束推送、22:外呼客户响铃推送、23:webcall客户接听推送、24:webcall转接响铃推送、25:webcall转接接通推送、26:主叫外呼分机响铃推送、27:主叫外呼分机接听推送、28:主叫外呼客户响铃推送、29:主叫外呼双方接通推送</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

        /// <summary>
        /// <para>推送的url；说明：目的URL</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
