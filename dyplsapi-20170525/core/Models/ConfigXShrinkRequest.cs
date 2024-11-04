// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class ConfigXShrinkRequest : TeaModel {
        /// <summary>
        /// <para>开/关呼叫能力状态‘0’：禁用‘1’：开启</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CallAbility")]
        [Validation(Required=false)]
        public string CallAbility { get; set; }

        /// <summary>
        /// <para>客户uid</para>
        /// 
        /// <b>Example:</b>
        /// <para>1898871967585852</para>
        /// </summary>
        [NameInMap("CallerParentId")]
        [Validation(Required=false)]
        public long? CallerParentId { get; set; }

        /// <summary>
        /// <para>号码池key</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC5**********************a1a</para>
        /// </summary>
        [NameInMap("CustomerPoolKey")]
        [Validation(Required=false)]
        public string CustomerPoolKey { get; set; }

        /// <summary>
        /// <para>是否透传来显为真实主叫：00-非透传：互相拨打时都显示工作号;10-透传：A客户为主叫时,B员工的来显为客户A号码;B员工为主叫时,A客户的来显为工作号;默认为 00</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("GNFlag")]
        [Validation(Required=false)]
        public string GNFlag { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>请求去重ID, reqId最大长度为20位,接入方需要保持原子性</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>564**********879</para>
        /// </summary>
        [NameInMap("ReqId")]
        [Validation(Required=false)]
        public string ReqId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>顺振控制参数</para>
        /// </summary>
        [NameInMap("SequenceCalls")]
        [Validation(Required=false)]
        public string SequenceCallsShrink { get; set; }

        /// <summary>
        /// <para>顺振模式：0-不顺振（默认）1-有条件顺振，先接续calledNo指定被叫，如果该被叫未能接通，再顺振sequenceCalls号码列表2-无条件顺振，不接续calledNo指定被叫，直接顺振sequenceCalls号码列表</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SequenceMode")]
        [Validation(Required=false)]
        public string SequenceMode { get; set; }

        /// <summary>
        /// <para>开/关短信功能状态‘0’：禁用；‘1’：开启；</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SmsAbility")]
        [Validation(Required=false)]
        public string SmsAbility { get; set; }

        /// <summary>
        /// <para>是否透传来显为真实用户0：不透传; 1：透传默认：0不透传</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SmsSignMode")]
        [Validation(Required=false)]
        public string SmsSignMode { get; set; }

        /// <summary>
        /// <para>X号码</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17*******22</para>
        /// </summary>
        [NameInMap("TelX")]
        [Validation(Required=false)]
        public string TelX { get; set; }

    }

}
