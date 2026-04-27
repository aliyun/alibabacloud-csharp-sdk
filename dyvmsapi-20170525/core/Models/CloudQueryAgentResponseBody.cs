// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudQueryAgentResponseBody : TeaModel {
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
        public CloudQueryAgentResponseBodyData Data { get; set; }
        public class CloudQueryAgentResponseBodyData : TeaModel {
            /// <summary>
            /// <para>座席列表数组</para>
            /// </summary>
            [NameInMap("Agents")]
            [Validation(Required=false)]
            public List<CloudQueryAgentResponseBodyDataAgents> Agents { get; set; }
            public class CloudQueryAgentResponseBodyDataAgents : TeaModel {
                /// <summary>
                /// <para>座席信息</para>
                /// </summary>
                [NameInMap("Agent")]
                [Validation(Required=false)]
                public CloudQueryAgentResponseBodyDataAgentsAgent Agent { get; set; }
                public class CloudQueryAgentResponseBodyDataAgentsAgent : TeaModel {
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
                    /// <para>41008502</para>
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
                    /// <para>0</para>
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
                    /// <para>133</para>
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
                    /// <para>name1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>外显号码</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>41008502</para>
                    /// </summary>
                    [NameInMap("ObClid")]
                    [Validation(Required=false)]
                    public string ObClid { get; set; }

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
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>webrtc软电话返回地址，0：企业默认 1：公网域名 2：专线域名 3：公网IP 4：专线IP</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("WebrtcUrlType")]
                    [Validation(Required=false)]
                    public string WebrtcUrlType { get; set; }

                    /// <summary>
                    /// <para>整理时间，秒数，默认10秒</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Wrapup")]
                    [Validation(Required=false)]
                    public string Wrapup { get; set; }

                }

                /// <summary>
                /// <para>座席所属队列信息</para>
                /// </summary>
                [NameInMap("QueueList")]
                [Validation(Required=false)]
                public List<CloudQueryAgentResponseBodyDataAgentsQueueList> QueueList { get; set; }
                public class CloudQueryAgentResponseBodyDataAgentsQueueList : TeaModel {
                    /// <summary>
                    /// <para>位置播报 0关闭 1大于announce_position_param时播放 2小于等于announce_position_param时播放</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("AnnouncePosition")]
                    [Validation(Required=false)]
                    public long? AnnouncePosition { get; set; }

                    /// <summary>
                    /// <para>位置播报周期，秒数</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("AnnouncePositionFrequency")]
                    [Validation(Required=false)]
                    public long? AnnouncePositionFrequency { get; set; }

                    /// <summary>
                    /// <para>多余少余n个时播报，必须大于等于2</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("AnnouncePositionParam")]
                    [Validation(Required=false)]
                    public long? AnnouncePositionParam { get; set; }

                    /// <summary>
                    /// <para>是否播报\&quot;您是下一位\&quot;,0关闭，1开启</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("AnnouncePositionYouarenext")]
                    [Validation(Required=false)]
                    public long? AnnouncePositionYouarenext { get; set; }

                    /// <summary>
                    /// <para>播报固定语音 0关闭 1打开</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("AnnounceSound")]
                    [Validation(Required=false)]
                    public long? AnnounceSound { get; set; }

                    /// <summary>
                    /// <para>固定语音文件</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>voice_filexxxxx</para>
                    /// </summary>
                    [NameInMap("AnnounceSoundFile")]
                    [Validation(Required=false)]
                    public string AnnounceSoundFile { get; set; }

                    /// <summary>
                    /// <para>播放固定语音周期，秒数</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>17</para>
                    /// </summary>
                    [NameInMap("AnnounceSoundFrequency")]
                    [Validation(Required=false)]
                    public long? AnnounceSoundFrequency { get; set; }

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
                    /// <para>队列名</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>queue_name</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>企业编号</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7000002</para>
                    /// </summary>
                    [NameInMap("EnterpriseId")]
                    [Validation(Required=false)]
                    public long? EnterpriseId { get; set; }

                    /// <summary>
                    /// <para>队列id</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>76</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>队列中为空时是否可以join，取值：1：置忙 2：通话中 4：振铃 8：无效 16：整理</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("JoinEmpty")]
                    [Validation(Required=false)]
                    public long? JoinEmpty { get; set; }

                    /// <summary>
                    /// <para>最大等待数，设置范围0-999，0表示不做任何限制</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxLen")]
                    [Validation(Required=false)]
                    public long? MaxLen { get; set; }

                    /// <summary>
                    /// <para>座席超时时间，取值范围20-60秒，默认25秒</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>25</para>
                    /// </summary>
                    [NameInMap("MemberTimeout")]
                    [Validation(Required=false)]
                    public long? MemberTimeout { get; set; }

                    /// <summary>
                    /// <para>等待语音class</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>class1</para>
                    /// </summary>
                    [NameInMap("MusicClass")]
                    [Validation(Required=false)]
                    public string MusicClass { get; set; }

                    /// <summary>
                    /// <para>队列号</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>322</para>
                    /// </summary>
                    [NameInMap("Qno")]
                    [Validation(Required=false)]
                    public string Qno { get; set; }

                    /// <summary>
                    /// <para>队列超时时间，取值范围5-600秒，默认600秒</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>600</para>
                    /// </summary>
                    [NameInMap("QueueTimeout")]
                    [Validation(Required=false)]
                    public long? QueueTimeout { get; set; }

                    /// <summary>
                    /// <para>座席超时无应答,呼叫下一座席的延迟秒数</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20</para>
                    /// </summary>
                    [NameInMap("Retry")]
                    [Validation(Required=false)]
                    public long? Retry { get; set; }

                    /// <summary>
                    /// <para>语音报号，true:播报，false:不播报</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("SayAgentno")]
                    [Validation(Required=false)]
                    public bool? SayAgentno { get; set; }

                    /// <summary>
                    /// <para>服务水平秒数，低于此时间内接听的认为是高服务水平</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("ServiceLevel")]
                    [Validation(Required=false)]
                    public long? ServiceLevel { get; set; }

                    /// <summary>
                    /// <para>呼叫策略：rrordered:技能优先 rrmemory:轮选 fewestcalls:平均 random:随机 linear:顺序 leastrecent:最长空闲时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rrordered</para>
                    /// </summary>
                    [NameInMap("Strategy")]
                    [Validation(Required=false)]
                    public string Strategy { get; set; }

                    /// <summary>
                    /// <para>是否支持vip，1:支持，0:不支持</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("VipSupport")]
                    [Validation(Required=false)]
                    public long? VipSupport { get; set; }

                    /// <summary>
                    /// <para>队列优先级，取值范围1-10，数值越高，优先级越高</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public long? Weight { get; set; }

                    /// <summary>
                    /// <para>整理时间，取值范围3-3600秒</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>30</para>
                    /// </summary>
                    [NameInMap("WrapupTime")]
                    [Validation(Required=false)]
                    public long? WrapupTime { get; set; }

                }

            }

            /// <summary>
            /// <para>总数</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

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
        /// <para>F655A8D5-B967-440B-8683-DAD6FF8DE990</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
