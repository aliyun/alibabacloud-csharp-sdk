// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudWebcallRequest : TeaModel {
        /// <summary>
        /// <para>是否开启amd；自动应答检查（传真机等），1.开启 0.不开启 默认为0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Amd")]
        [Validation(Required=false)]
        public long? Amd { get; set; }

        /// <summary>
        /// <para>可传入企业中继号码或设置好的客户侧外显号码</para>
        /// 
        /// <b>Example:</b>
        /// <para>41008502</para>
        /// </summary>
        [NameInMap("Clid")]
        [Validation(Required=false)]
        public string Clid { get; set; }

        /// <summary>
        /// <para>客户侧外显指定地区号码，优先级低于clid</para>
        /// 
        /// <b>Example:</b>
        /// <para>010</para>
        /// </summary>
        [NameInMap("ClidAreaCode")]
        [Validation(Required=false)]
        public string ClidAreaCode { get; set; }

        /// <summary>
        /// <para>客户侧外显号码组；使用clidGroup需要账号支持按标识路由，优先级低于clid</para>
        /// 
        /// <b>Example:</b>
        /// <para>clidGroup</para>
        /// </summary>
        [NameInMap("ClidGroup")]
        [Validation(Required=false)]
        public string ClidGroup { get; set; }

        /// <summary>
        /// <para>指定本次外呼使用的客户侧外显号码集合，系统将根据号码调度策略选择可用号码进行外呼</para>
        /// 
        /// <b>Example:</b>
        /// <para>41008502</para>
        /// </summary>
        [NameInMap("ClidList")]
        [Validation(Required=false)]
        public string ClidList { get; set; }

        /// <summary>
        /// <para>外显导航标识</para>
        /// 
        /// <b>Example:</b>
        /// <para>33</para>
        /// </summary>
        [NameInMap("CrnId")]
        [Validation(Required=false)]
        public string CrnId { get; set; }

        /// <summary>
        /// <para>延迟时长；秒数，延迟多少秒呼叫 参数取值范围：0&lt;=delay&lt;=60 默认为0</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Delay")]
        [Validation(Required=false)]
        public long? Delay { get; set; }

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
        /// <para>过期时间，精确到s，yyyy-MM-dd HH:mm:ss</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-04-20 10:00:00</para>
        /// </summary>
        [NameInMap("ExpirTime")]
        [Validation(Required=false)]
        public string ExpirTime { get; set; }

        /// <summary>
        /// <para>回呼接通后进入的ivrId；如果不传此参数，使用后台配置的ivr</para>
        /// 
        /// <b>Example:</b>
        /// <para>70</para>
        /// </summary>
        [NameInMap("IvrId")]
        [Validation(Required=false)]
        public long? IvrId { get; set; }

        /// <summary>
        /// <para>多号码时呼叫延时；tel多个号码时，号码之间的呼叫延迟，最大120秒，默认0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MultiTelDelay")]
        [Validation(Required=false)]
        public long? MultiTelDelay { get; set; }

        /// <summary>
        /// <para>多号码，是否每个号码呼叫都挂机推送；取值说明 0：只挂机推送一次； 1：每次呼叫都触发挂机推送；默认0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MultiTelPush")]
        [Validation(Required=false)]
        public long? MultiTelPush { get; set; }

        /// <summary>
        /// <para>请求唯一标识；说明：长度不超过300个字节。1个汉字是3字节。此字段保存到通话记录requestUniqueId字段，后续接口查询使用。一次接口请求造成的多次呼叫requestUniqueId相同；如果是加密的号码，需要URLEncode后传入</para>
        /// 
        /// <b>Example:</b>
        /// <para>requset12345</para>
        /// </summary>
        [NameInMap("RequestUniqueId")]
        [Validation(Required=false)]
        public string RequestUniqueId { get; set; }

        /// <summary>
        /// <para>重试次数；最大5次，使用的企业需要开启webcall自动重试开关</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Retry")]
        [Validation(Required=false)]
        public long? Retry { get; set; }

        /// <summary>
        /// <para>重试间隔，单位分钟，最小0分钟，最大59分钟</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RetryInterval")]
        [Validation(Required=false)]
        public long? RetryInterval { get; set; }

        /// <summary>
        /// <para>电话号码；固话带区号，手机不加0；固话带分机的以\&quot;-\&quot;分隔；支持多个号码，多个直接用英文逗号’,’分隔；传多个号码时，若前面的号码没接通则会呼叫后面的号码，若接通则不会呼叫；<a href="../%E5%AD%97%E6%AE%B5%E5%AE%9A%E4%B9%89/%E6%8E%A5%E5%8F%A3%E9%83%A8%E5%88%86/%E5%8A%A0%E5%AF%86%E5%A4%96%E5%91%BC%E5%8F%B7%E7%A0%81%E5%8A%A0%E5%AF%86%E8%A7%84%E5%88%99.md">加密外呼</a>；如果是加密的号码，需要URLEncode后传入</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13312345678</para>
        /// </summary>
        [NameInMap("Tel")]
        [Validation(Required=false)]
        public string Tel { get; set; }

        /// <summary>
        /// <para>呼叫客户超时时间；说明：参数取值范围 0&lt;=timeout&lt;=60；不传入，默认30(单位:s)</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

        /// <summary>
        /// <para>用户自定义字段；说明：长度不超过250个字节。1个汉字是3字节。此字段保存到通话记录userField字段，后续接口查询使用。该字段需“动态附带参数”paramNames有值时方可生效。</para>
        /// 
        /// <b>Example:</b>
        /// <para>UserField</para>
        /// </summary>
        [NameInMap("UserField")]
        [Validation(Required=false)]
        public string UserField { get; set; }

        /// <summary>
        /// <para>用哪种语言播放ivr提示音；1.普通话 2.粤语 4.标贝TTS 5.普通话-甜美女音 默认为1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Vid")]
        [Validation(Required=false)]
        public string Vid { get; set; }

    }

}
