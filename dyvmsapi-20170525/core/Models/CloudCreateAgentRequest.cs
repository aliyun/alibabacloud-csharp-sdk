// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudCreateAgentRequest : TeaModel {
        /// <summary>
        /// <para>是否激活；取值0或1，取值说明 0：不激活，1激活，默认激活</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Active")]
        [Validation(Required=false)]
        public long? Active { get; set; }

        /// <summary>
        /// <para>座席所属区号；区号格式</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>010</para>
        /// </summary>
        [NameInMap("AreaCode")]
        [Validation(Required=false)]
        public string AreaCode { get; set; }

        /// <summary>
        /// <para>呼叫权限；取值说明 0：无限制，1：国内长途，2：国内本市，3：内部呼叫，默认无限制</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("CallPower")]
        [Validation(Required=false)]
        public long? CallPower { get; set; }

        /// <summary>
        /// <para>座席工号；正整数，取值3-10位数字</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111</para>
        /// </summary>
        [NameInMap("Cno")]
        [Validation(Required=false)]
        public string Cno { get; set; }

        /// <summary>
        /// <para>备注</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

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
        /// <para>呼入是否录音；取值说明 0：不录用，1：录音，默认录音</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IbRecord")]
        [Validation(Required=false)]
        public long? IbRecord { get; set; }

        /// <summary>
        /// <para>是否开启ASR转写；取值说明：0：不开启，1：开启，默认不开启</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IsAsr")]
        [Validation(Required=false)]
        public long? IsAsr { get; set; }

        /// <summary>
        /// <para>是否允许外呼；取值说明 0：不允许，1：可以，默认允许</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsOb")]
        [Validation(Required=false)]
        public long? IsOb { get; set; }

        /// <summary>
        /// <para>外呼主叫记忆开关；取值说明：0：关闭 1：开启；默认开启</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsObRemember")]
        [Validation(Required=false)]
        public string IsObRemember { get; set; }

        /// <summary>
        /// <para>是否开启座席质检；取值说明：0：不开启，1：开启，默认开启</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsQualityCheck")]
        [Validation(Required=false)]
        public long? IsQualityCheck { get; set; }

        /// <summary>
        /// <para>座席姓名；需进行UTF-8格式的URLEncode编码</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>透传号码；可传入企业中继号码或设置好的客户侧外显号码，当obClidType值为2或3时必选</para>
        /// 
        /// <b>Example:</b>
        /// <para>22223333</para>
        /// </summary>
        [NameInMap("ObClid")]
        [Validation(Required=false)]
        public string ObClid { get; set; }

        /// <summary>
        /// <para>外显属性；取值：{&quot;isMatchCapital&quot;:0,&quot;areaCodeRule&quot;:1,&quot;isRandom&quot;:1}；obClidType=4时，isMatchCapital表示是否匹配省会号码，1是 0否，areaCodeRule表示区号匹配规则，1座席区号 2客户号码区号 ;isRandom 随机外显</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;isMatchCapital&quot;:0,&quot;areaCodeRule&quot;:1,&quot;isRandom&quot;:1}</para>
        /// </summary>
        [NameInMap("ObClidProperty")]
        [Validation(Required=false)]
        public string ObClidProperty { get; set; }

        /// <summary>
        /// <para>外显规则；取值：1:默认 2:随机 3:按区号 4 动态外显 ，默认值为1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ObClidType")]
        [Validation(Required=false)]
        public long? ObClidType { get; set; }

        /// <summary>
        /// <para>外呼是否录音；取值说明 0：不录音，1：录音，默认录音</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ObRecord")]
        [Validation(Required=false)]
        public long? ObRecord { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>可外呼时间段；格式：08:00,20:00</para>
        /// 
        /// <b>Example:</b>
        /// <para>08:00,20:00</para>
        /// </summary>
        [NameInMap("PermitObPreviewTime")]
        [Validation(Required=false)]
        public string PermitObPreviewTime { get; set; }

        /// <summary>
        /// <para>座席权限；取值1或0，取值说明 1：班长席，0：普通座席，默认为0 普通座席</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Power")]
        [Validation(Required=false)]
        public long? Power { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>所选的技能id；可选择多个，多个之间使用英文标点逗号间隔.例如:&quot;1,2,3&quot;；传入skillIds时，需要同时传入skillLevels</para>
        /// 
        /// <b>Example:</b>
        /// <para>1,2,3</para>
        /// </summary>
        [NameInMap("SkillIds")]
        [Validation(Required=false)]
        public string SkillIds { get; set; }

        /// <summary>
        /// <para>所选的技能的等级；值越小技能越高，多个间用英文标点逗号间隔。(与技能id相对应) 例如:&quot;5,1,1&quot;表示技能id为1的等级是5; 技能id为2的等级是1; 技能id为3的等级是1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5,1,1</para>
        /// </summary>
        [NameInMap("SkillLevels")]
        [Validation(Required=false)]
        public string SkillLevels { get; set; }

        /// <summary>
        /// <para>webrtc软电话返回地址；取值说明：0：企业默认 1：公网域名 2：专线域名 3：公网IP 4：专线IP</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("WebrtcUrlType")]
        [Validation(Required=false)]
        public long? WebrtcUrlType { get; set; }

        /// <summary>
        /// <para>整理时间；单位秒数，默认10秒</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Wrapup")]
        [Validation(Required=false)]
        public long? Wrapup { get; set; }

    }

}
