// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkCreateClientShrinkRequest : TeaModel {
        /// <summary>
        /// <para>启用状态，0: 停用；1: 启用，默认值为 1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Active")]
        [Validation(Required=false)]
        public long? Active { get; set; }

        /// <summary>
        /// <para>所属区号</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>010</para>
        /// </summary>
        [NameInMap("AreaCode")]
        [Validation(Required=false)]
        public string AreaCode { get; set; }

        /// <summary>
        /// <para>号码类型，默认值为0，0: 号码；1: 动态号码组</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AssignType")]
        [Validation(Required=false)]
        public long? AssignType { get; set; }

        /// <summary>
        /// <para>可外显号码集合，当clidType（外显号码类型）值为非0时为必填项</para>
        /// </summary>
        [NameInMap("Clid")]
        [Validation(Required=false)]
        public string ClidShrink { get; set; }

        /// <summary>
        /// <para>按地区外显配置，当clidType（外显号码类型）值为3且clidRule（外显规则）值为2（自定义）时有意义，具体配置项见 clidArea 对象</para>
        /// </summary>
        [NameInMap("ClidArea")]
        [Validation(Required=false)]
        public string ClidAreaShrink { get; set; }

        /// <summary>
        /// <para>缺省外显号码集合，当clidType（外显号码类型）值为3且clidRule（外显规则）值为1（动态）时，支持配置缺省外显</para>
        /// </summary>
        [NameInMap("ClidDefault")]
        [Validation(Required=false)]
        public string ClidDefaultShrink { get; set; }

        /// <summary>
        /// <para>外显规则，默认值为 1 当clidType（外显号码类型）值为0（全部）时，1:随机；2: 轮选。 当clidType（外显号码类型）值为3（智能外显）时，1:动态；2: 自定义。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ClidRule")]
        [Validation(Required=false)]
        public long? ClidRule { get; set; }

        /// <summary>
        /// <para>外显号码类型，0: 全部；2: 座席指定；3: 智能外显；默认值为 0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ClidType")]
        [Validation(Required=false)]
        public long? ClidType { get; set; }

        /// <summary>
        /// <para>云号码外呼开关，0-关，1-开</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CloudNumberEnabled")]
        [Validation(Required=false)]
        public long? CloudNumberEnabled { get; set; }

        /// <summary>
        /// <para>云号码四种呼叫模式；数组长度 为 4，依次对应云号码外呼的四种模式（实体卡、工作卡、两端呼、RTC)的开启状态； 例如：[0,0,0,1] 表示 座席只可使用 RTC 外呼模式。 注意：仅当企业开启了云手机外呼功能，才能为座席设置该属性，否则，座席将创建失败</para>
        /// </summary>
        [NameInMap("CloudNumberModes")]
        [Validation(Required=false)]
        public string CloudNumberModesShrink { get; set; }

        /// <summary>
        /// <para>座席工号，长度为4-11个字符，必须全部为数字，要求唯一</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111</para>
        /// </summary>
        [NameInMap("Cno")]
        [Validation(Required=false)]
        public long? Cno { get; set; }

        /// <summary>
        /// <para>CRM 编号，与第三方 CRM 系统对接时，可作为唯一标识</para>
        /// 
        /// <b>Example:</b>
        /// <para>87</para>
        /// </summary>
        [NameInMap("CrmId")]
        [Validation(Required=false)]
        public long? CrmId { get; set; }

        /// <summary>
        /// <para>缺省动态外呼组id，当obClidDefaultType值为1时为必填项</para>
        /// 
        /// <b>Example:</b>
        /// <para>17</para>
        /// </summary>
        [NameInMap("DynamicTelGroupIdDefault")]
        [Validation(Required=false)]
        public long? DynamicTelGroupIdDefault { get; set; }

        /// <summary>
        /// <para>动态号码组名称，当assignType（号码类型）值为1（动态号码组）时为必填项</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("DynamicTelGroupName")]
        [Validation(Required=false)]
        public string DynamicTelGroupName { get; set; }

        /// <summary>
        /// <para>呼叫中心 id</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8004970</para>
        /// </summary>
        [NameInMap("EnterpriseId")]
        [Validation(Required=false)]
        public long? EnterpriseId { get; set; }

        /// <summary>
        /// <para>号码隐藏类型，0: 不隐藏；1: 隐藏规则与全局设置保持一致，默认值为 0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HiddenTel")]
        [Validation(Required=false)]
        public long? HiddenTel { get; set; }

        /// <summary>
        /// <para>座席名称，只允许输入中文、字母、数字、下划线，长度不超过 20 个字符</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>缺省号码类型 0：号码 1：动态号码组 默认0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ObClidDefaultType")]
        [Validation(Required=false)]
        public long? ObClidDefaultType { get; set; }

        /// <summary>
        /// <para>外呼挂机短信开关 0：关闭， 1：开启。开启后，当座席发起外呼时，系统会依据【短信中心 - 短信设置 - 外呼双方接听通知 / 外呼客户未接听通知】中的配置条件发送短信。</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ObHangupSms")]
        [Validation(Required=false)]
        public long? ObHangupSms { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>座席密码，采用 AES加密 ，默认长度为 8 位。如果企业开启了密码安全设置，则需要按照设置的规则设置</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>是否可置忙登录，关闭后，座席不允许置忙登录，0：关闭，1：开启，默认1。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PauseLogin")]
        [Validation(Required=false)]
        public long? PauseLogin { get; set; }

        /// <summary>
        /// <para>permission</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Permission")]
        [Validation(Required=false)]
        public string PermissionShrink { get; set; }

        /// <summary>
        /// <para>所属队列号集合</para>
        /// </summary>
        [NameInMap("Qnos")]
        [Validation(Required=false)]
        public string QnosShrink { get; set; }

        /// <summary>
        /// <para>轮选方式，1: 按天轮选；2: 按次轮选，当外显号码类型为全部、外显规则为轮选时配置才生效</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RecurrentselectionType")]
        [Validation(Required=false)]
        public long? RecurrentselectionType { get; set; }

        /// <summary>
        /// <para>轮选值设置，当外显号码类型为全部、外显规则为轮选时配置才生效 1: 按天轮选，每 n 天外呼更换一次外显号码，可设置 1-30 天 2: 按次轮选，每 n 次外呼更换一次外显号码，可设置 1-30 次</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RecurrentselectionValue")]
        [Validation(Required=false)]
        public long? RecurrentselectionValue { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>座席角色，0: 普通座席；1: 班长座席，默认值为 0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Role")]
        [Validation(Required=false)]
        public long? Role { get; set; }

        /// <summary>
        /// <para>座席服务地区，区号数组 配置座席服务的地区，可用于外呼任务中“按服务地区分配”的策略。</para>
        /// </summary>
        [NameInMap("ServeArea")]
        [Validation(Required=false)]
        public string ServeAreaShrink { get; set; }

        /// <summary>
        /// <para>座席类型，1：全渠道、2：呼叫中心、3：在线客服；默认值为 2</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public long? Type { get; set; }

        /// <summary>
        /// <para>微信小程序RTC开关 1：开启 0：关闭 默认关闭</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("WechatMiniProgramRtc")]
        [Validation(Required=false)]
        public long? WechatMiniProgramRtc { get; set; }

        /// <summary>
        /// <para>整理时长，座席进行外呼操作后的整理时间。取值范围 0-300 秒，默认值为 30</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("WrapupTime")]
        [Validation(Required=false)]
        public long? WrapupTime { get; set; }

    }

}
