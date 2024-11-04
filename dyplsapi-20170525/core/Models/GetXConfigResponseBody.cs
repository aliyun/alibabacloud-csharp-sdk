// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class GetXConfigResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>开/关呼叫能力状态： ‘0’：禁用； ‘1’：开启；</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CallAbility")]
        [Validation(Required=false)]
        public string CallAbility { get; set; }

        /// <summary>
        /// <para>返回状态码 0000表示成功 其他表示失败</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>是否透传来显为真实主叫： 00-非透传：互相拨打时都显示工作号; 10-透传：A客户为主叫时,B员工的来显为客户A号码;B员工为主叫时,A客户的来显为工作号; 默认为 00</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("GNFlag")]
        [Validation(Required=false)]
        public string GNFlag { get; set; }

        /// <summary>
        /// <para>返回信息</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>顺振控制参数</para>
        /// </summary>
        [NameInMap("SequenceCalls")]
        [Validation(Required=false)]
        public List<GetXConfigResponseBodySequenceCalls> SequenceCalls { get; set; }
        public class GetXConfigResponseBodySequenceCalls : TeaModel {
            /// <summary>
            /// <para>顺振提示音放音编号，格式如callNoPlayCode</para>
            /// 
            /// <b>Example:</b>
            /// <para>01</para>
            /// </summary>
            [NameInMap("SequenceCallNoPlayCode")]
            [Validation(Required=false)]
            public string SequenceCallNoPlayCode { get; set; }

            /// <summary>
            /// <para>顺振被叫号码</para>
            /// 
            /// <b>Example:</b>
            /// <para>18*******33</para>
            /// </summary>
            [NameInMap("SequenceCalledNo")]
            [Validation(Required=false)]
            public string SequenceCalledNo { get; set; }

            /// <summary>
            /// <para>接通后主被叫放音编号，格式如calledPlayCode</para>
            /// 
            /// <b>Example:</b>
            /// <para>02</para>
            /// </summary>
            [NameInMap("SequenceCalledPlayCode")]
            [Validation(Required=false)]
            public string SequenceCalledPlayCode { get; set; }

        }

        /// <summary>
        /// <para>顺振模式： 0-不顺振（默认） 1-有条件顺振，先接续calledNo指定被叫，如果该被叫未能接通，再顺振sequenceCalls号码列表 2-无条件顺振，不接续calledNo指定被叫，直接顺振sequenceCalls号码列表</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SequenceMode")]
        [Validation(Required=false)]
        public string SequenceMode { get; set; }

        /// <summary>
        /// <para>开/关短信功能状态： ‘0’：禁用；‘1’：开启；</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SmsAbility")]
        [Validation(Required=false)]
        public string SmsAbility { get; set; }

        /// <summary>
        /// <para>是否透传来显为真实用户 0：不透传; 1：透传 默认：0不透传</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SmsSignMode")]
        [Validation(Required=false)]
        public string SmsSignMode { get; set; }

        /// <summary>
        /// <para>返回是否成功 true  表示成功 false表示失败</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>X号码</para>
        /// 
        /// <b>Example:</b>
        /// <para>17*******22</para>
        /// </summary>
        [NameInMap("TelX")]
        [Validation(Required=false)]
        public string TelX { get; set; }

    }

}
