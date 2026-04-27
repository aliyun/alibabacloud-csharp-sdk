// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudPreviewoutcallRequest : TeaModel {
        /// <summary>
        /// <para>备用外呼号码；tel没呼通时呼叫备用号码，最多支持5个号码，多个之间用逗号分隔</para>
        /// 
        /// <b>Example:</b>
        /// <para>41008502</para>
        /// </summary>
        [NameInMap("BackupTels")]
        [Validation(Required=false)]
        public string BackupTels { get; set; }

        /// <summary>
        /// <para>通道变量可以在以下场景中使用：1. 事件推送，作为推送字段使用2. 通话记录中，将字段存储在自定义字段3. 通过SIP-Header方式将字段传到呼叫的下游链路格式如: [{&quot;name&quot;:&quot;mainUniqueId&quot;,&quot;value&quot;:&quot;cdr_main_unique_id&quot;,&quot;type&quot;:&quot;2&quot;},{&quot;name&quot;:&quot;callType&quot;,&quot;value&quot;:&quot;cdr_call_type&quot;,&quot;type&quot;:&quot;2&quot;}]name：变量名称value：变量值type：变量类型，1.普通变量 2.PJSIP_HEADER变量（用于将变量通过SIP-Header方式传到客户侧，最多支持5个）</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;mainUniqueId&quot;,&quot;value&quot;:&quot;cdr_main_unique_id&quot;,&quot;type&quot;:&quot;2&quot;},{&quot;name&quot;:&quot;callType&quot;,&quot;value&quot;:&quot;cdr_call_type&quot;,&quot;type&quot;:&quot;2&quot;}]</para>
        /// </summary>
        [NameInMap("CallVariables")]
        [Validation(Required=false)]
        public string CallVariables { get; set; }

        /// <summary>
        /// <para>此次通话录音是否进行ASR转写；0.不进行 1.进行 默认：1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CdrIsAsr")]
        [Validation(Required=false)]
        public long? CdrIsAsr { get; set; }

        /// <summary>
        /// <para>外显号码集合, 格式如: [{&quot;clid&quot;:&quot;1708587xxxx&quot;,&quot;priority&quot;:1},{&quot;clid&quot;:&quot;1304412xxxx&quot;,&quot;priority&quot;:2},{&quot;clid&quot;:&quot;0107990xxxx&quot;,&quot;priority&quot;:3}] clid：外显号码（String类型）（必填）priority：优先级（Integer类型）（非必填） 特别说明： 一次呼叫最多允许传10个指定号码；若指定了号码优先级，要求所有传入的号码都必传</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;clid&quot;:&quot;1708587xxxx&quot;,&quot;priority&quot;:1},{&quot;clid&quot;:&quot;1304412xxxx&quot;,&quot;priority&quot;:2},{&quot;clid&quot;:&quot;0107990xxxx&quot;,&quot;priority&quot;:3}]</para>
        /// </summary>
        [NameInMap("ClidList")]
        [Validation(Required=false)]
        public string ClidList { get; set; }

        /// <summary>
        /// <para>座席工号；3-10位数字</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111</para>
        /// </summary>
        [NameInMap("Cno")]
        [Validation(Required=false)]
        public string Cno { get; set; }

        /// <summary>
        /// <para>外显导航标识</para>
        /// 
        /// <b>Example:</b>
        /// <para>12333</para>
        /// </summary>
        [NameInMap("CrnId")]
        [Validation(Required=false)]
        public string CrnId { get; set; }

        /// <summary>
        /// <para>呼叫客户侧超时时间；取值范围 5&lt;=dialTelTimeout&lt;=60，默认45(单位:s)</para>
        /// 
        /// <b>Example:</b>
        /// <para>26</para>
        /// </summary>
        [NameInMap("DialTelTimeout")]
        [Validation(Required=false)]
        public long? DialTelTimeout { get; set; }

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
        /// <para>是否满意度调查；0.不进行满意度调查 1.进行满意度调查，默认：取企业配置</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsInvestigation")]
        [Validation(Required=false)]
        public long? IsInvestigation { get; set; }

        /// <summary>
        /// <para>可传入企业中继号码或设置好的客户侧外显号码</para>
        /// 
        /// <b>Example:</b>
        /// <para>41008502</para>
        /// </summary>
        [NameInMap("ObClid")]
        [Validation(Required=false)]
        public string ObClid { get; set; }

        /// <summary>
        /// <para>指定外显区号；传入区号，在指定区号下外显号码；如果obClid和obClidAreaCode都传的情况下，按照obClid外显</para>
        /// 
        /// <b>Example:</b>
        /// <para>010</para>
        /// </summary>
        [NameInMap("ObClidAreaCode")]
        [Validation(Required=false)]
        public string ObClidAreaCode { get; set; }

        /// <summary>
        /// <para>客户侧外显号码组；使用clidGroup需要账号支持按标识路由，使用此参数时clid参数无效</para>
        /// 
        /// <b>Example:</b>
        /// <para>333</para>
        /// </summary>
        [NameInMap("ObClidGroup")]
        [Validation(Required=false)]
        public string ObClidGroup { get; set; }

        /// <summary>
        /// <para>请求唯一id；取值：如果没有传入值则系统会生产。如果是加密的号码，需要URLEncode后传入</para>
        /// 
        /// <b>Example:</b>
        /// <para>req1234567</para>
        /// </summary>
        [NameInMap("RequestUniqueId")]
        [Validation(Required=false)]
        public string RequestUniqueId { get; set; }

        /// <summary>
        /// <para>需要进行呼叫的客户方电话号码，固话带区号，手机不加0。 当开启号码隐藏设置时，可从弹屏事件中获取customerNumberKey的值，进行外呼；<a href="../%E5%AD%97%E6%AE%B5%E5%AE%9A%E4%B9%89/%E6%8E%A5%E5%8F%A3%E9%83%A8%E5%88%86/%E5%8A%A0%E5%AF%86%E5%A4%96%E5%91%BC%E5%8F%B7%E7%A0%81%E5%8A%A0%E5%AF%86%E8%A7%84%E5%88%99.md">加密外呼</a>；如果是加密的号码，需要URLEncode后传入；当外呼相关配置-支持分机号外呼开启后，此字段可支持传手机号-分机号格式</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1774821736</para>
        /// </summary>
        [NameInMap("Tel")]
        [Validation(Required=false)]
        public string Tel { get; set; }

        /// <summary>
        /// <para>呼叫座席侧超时时间；取值范围 5&lt;=timeout&lt;=60，默认30(单位:s)</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

    }

}
