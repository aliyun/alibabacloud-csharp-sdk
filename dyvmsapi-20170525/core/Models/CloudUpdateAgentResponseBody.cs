// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudUpdateAgentResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CloudUpdateAgentResponseBodyData Data { get; set; }
        public class CloudUpdateAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>座席配置信息</para>
            /// </summary>
            [NameInMap("Agent")]
            [Validation(Required=false)]
            public CloudUpdateAgentResponseBodyDataAgent Agent { get; set; }
            public class CloudUpdateAgentResponseBodyDataAgent : TeaModel {
                /// <summary>
                /// <para>是否启用，0：停用，1：启用，默认启用</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Active")]
                [Validation(Required=false)]
                public string Active { get; set; }

                /// <summary>
                /// <para>座席类型，1：电话座席，2：电脑座席，默认电话座席</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AgentType")]
                [Validation(Required=false)]
                public string AgentType { get; set; }

                /// <summary>
                /// <para>区号格式</para>
                /// 
                /// <b>Example:</b>
                /// <para>010</para>
                /// </summary>
                [NameInMap("AreaCode")]
                [Validation(Required=false)]
                public string AreaCode { get; set; }

                /// <summary>
                /// <para>座席绑定电话</para>
                /// 
                /// <b>Example:</b>
                /// <para>22223333</para>
                /// </summary>
                [NameInMap("BindTel")]
                [Validation(Required=false)]
                public string BindTel { get; set; }

                /// <summary>
                /// <para>电话类型，1:固话 2:手机 3:分机 4:软电话</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BindTelType")]
                [Validation(Required=false)]
                public string BindTelType { get; set; }

                /// <summary>
                /// <para>呼叫权限，0：无限制，1：国内长途，2：国内本市，3：内部呼叫，默认无限制</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CallPower")]
                [Validation(Required=false)]
                public string CallPower { get; set; }

                /// <summary>
                /// <para>座席工号</para>
                /// 
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("Cno")]
                [Validation(Required=false)]
                public string Cno { get; set; }

                /// <summary>
                /// <para>创建时间，格式: yyyy-MM-dd HH:mm:ss</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-04-20 10:00:00</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>企业编号</para>
                /// 
                /// <b>Example:</b>
                /// <para>7000002</para>
                /// </summary>
                [NameInMap("EnterpriseId")]
                [Validation(Required=false)]
                public string EnterpriseId { get; set; }

                /// <summary>
                /// <para>呼入是否录音，0：不录用，1：录音，默认录音</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IbRecord")]
                [Validation(Required=false)]
                public string IbRecord { get; set; }

                /// <summary>
                /// <para>座席id</para>
                /// 
                /// <b>Example:</b>
                /// <para>100012</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>是否开启ASR转写：0：不开启，1：开启，默认不开启</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsAsr")]
                [Validation(Required=false)]
                public string IsAsr { get; set; }

                /// <summary>
                /// <para>是否允许外呼，0：不允许，1：可以，默认允许</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsOb")]
                [Validation(Required=false)]
                public string IsOb { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsQualityCheck")]
                [Validation(Required=false)]
                public string IsQualityCheck { get; set; }

                /// <summary>
                /// <para>座席姓名</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>外显号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>22223333</para>
                /// </summary>
                [NameInMap("ObClid")]
                [Validation(Required=false)]
                public string ObClid { get; set; }

                /// <summary>
                /// <para>外显规则属性，JSON格式</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;isMatchCapital&quot;:0,&quot;areaCodeRule&quot;:1}</para>
                /// </summary>
                [NameInMap("ObClidProperty")]
                [Validation(Required=false)]
                public string ObClidProperty { get; set; }

                /// <summary>
                /// <para>外显规则 1：企业默认 2：随机 3：按区号 4：动态外显</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ObClidType")]
                [Validation(Required=false)]
                public string ObClidType { get; set; }

                /// <summary>
                /// <para>外呼是否录音，0：不录音，1：录音，默认录音</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ObRecord")]
                [Validation(Required=false)]
                public string ObRecord { get; set; }

                /// <summary>
                /// <para>1：班长席，0：普通座席，默认普通座席</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Power")]
                [Validation(Required=false)]
                public string Power { get; set; }

                /// <summary>
                /// <para>座席状态，0:离线，1：在线</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>webrtc软电话返回地址，0：企业默认 1：公网域名 2：专线域名 3：公网IP 4：专线IP</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("WebrtcUrlType")]
                [Validation(Required=false)]
                public string WebrtcUrlType { get; set; }

                /// <summary>
                /// <para>整理时间，秒数，默认10秒</para>
                /// 
                /// <b>Example:</b>
                /// <para>22</para>
                /// </summary>
                [NameInMap("Wrapup")]
                [Validation(Required=false)]
                public string Wrapup { get; set; }

            }

            /// <summary>
            /// <para>座席所需技能数组</para>
            /// </summary>
            [NameInMap("AgentSkills")]
            [Validation(Required=false)]
            public List<CloudUpdateAgentResponseBodyDataAgentSkills> AgentSkills { get; set; }
            public class CloudUpdateAgentResponseBodyDataAgentSkills : TeaModel {
                /// <summary>
                /// <para>座席id</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("Cno")]
                [Validation(Required=false)]
                public string Cno { get; set; }

                /// <summary>
                /// <para>创建时间，格式: yyyy-MM-dd HH:mm:ss</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-04-20 10:00:00</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>企业编号</para>
                /// 
                /// <b>Example:</b>
                /// <para>7000002</para>
                /// </summary>
                [NameInMap("EnterpriseId")]
                [Validation(Required=false)]
                public string EnterpriseId { get; set; }

                /// <summary>
                /// <para>queueSkill关系表中id</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>skill的id</para>
                /// 
                /// <b>Example:</b>
                /// <para>111</para>
                /// </summary>
                [NameInMap("SkillId")]
                [Validation(Required=false)]
                public string SkillId { get; set; }

                /// <summary>
                /// <para>技能值</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("SkillLevel")]
                [Validation(Required=false)]
                public string SkillLevel { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D9CB3933-9FE3-4870-BA8E-2BEE91B69D23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
