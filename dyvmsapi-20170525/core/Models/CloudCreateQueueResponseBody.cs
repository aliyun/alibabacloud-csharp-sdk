// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudCreateQueueResponseBody : TeaModel {
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
        public CloudCreateQueueResponseBodyData Data { get; set; }
        public class CloudCreateQueueResponseBodyData : TeaModel {
            /// <summary>
            /// <para>队列配置信息</para>
            /// </summary>
            [NameInMap("Queue")]
            [Validation(Required=false)]
            public CloudCreateQueueResponseBodyDataQueue Queue { get; set; }
            public class CloudCreateQueueResponseBodyDataQueue : TeaModel {
                /// <summary>
                /// <para>位置播报 0关闭 1大于announce_position_param时播放 2小于等于announce_position_param时播放</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
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
                /// <para>2</para>
                /// </summary>
                [NameInMap("AnnouncePositionParam")]
                [Validation(Required=false)]
                public long? AnnouncePositionParam { get; set; }

                /// <summary>
                /// <para>是否播报\&quot;您是下一位\&quot;,0关闭，1开启</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AnnouncePositionYouarenext")]
                [Validation(Required=false)]
                public long? AnnouncePositionYouarenext { get; set; }

                /// <summary>
                /// <para>播报固定语音 0关闭 1打开</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AnnounceSound")]
                [Validation(Required=false)]
                public long? AnnounceSound { get; set; }

                /// <summary>
                /// <para>固定语音文件</para>
                /// 
                /// <b>Example:</b>
                /// <para>sound_file3</para>
                /// </summary>
                [NameInMap("AnnounceSoundFile")]
                [Validation(Required=false)]
                public string AnnounceSoundFile { get; set; }

                /// <summary>
                /// <para>播放固定语音周期，秒数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
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
                /// <para>queueName</para>
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
                /// <para>80</para>
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
                /// <para>default</para>
                /// </summary>
                [NameInMap("MusicClass")]
                [Validation(Required=false)]
                public string MusicClass { get; set; }

                /// <summary>
                /// <para>队列号</para>
                /// 
                /// <b>Example:</b>
                /// <para>12331</para>
                /// </summary>
                [NameInMap("Qno")]
                [Validation(Required=false)]
                public string Qno { get; set; }

                /// <summary>
                /// <para>队列超时时间，取值范围5-600秒，默认600秒</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("QueueTimeout")]
                [Validation(Required=false)]
                public long? QueueTimeout { get; set; }

                /// <summary>
                /// <para>座席超时无应答,呼叫下一座席的延迟秒数</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Retry")]
                [Validation(Required=false)]
                public long? Retry { get; set; }

                /// <summary>
                /// <para>语音报号，true:播报，false:不播报</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SayAgentno")]
                [Validation(Required=false)]
                public bool? SayAgentno { get; set; }

                /// <summary>
                /// <para>服务水平秒数，低于此时间内接听的认为是高服务水平</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
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
                /// <para>0</para>
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

            /// <summary>
            /// <para>队列所需技能数组</para>
            /// </summary>
            [NameInMap("QueueSkills")]
            [Validation(Required=false)]
            public List<CloudCreateQueueResponseBodyDataQueueSkills> QueueSkills { get; set; }
            public class CloudCreateQueueResponseBodyDataQueueSkills : TeaModel {
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
                public long? EnterpriseId { get; set; }

                /// <summary>
                /// <para>queueSkill关系表中id</para>
                /// 
                /// <b>Example:</b>
                /// <para>54474</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>队列id</para>
                /// 
                /// <b>Example:</b>
                /// <para>51937</para>
                /// </summary>
                [NameInMap("QueueId")]
                [Validation(Required=false)]
                public long? QueueId { get; set; }

                /// <summary>
                /// <para>skill的id</para>
                /// 
                /// <b>Example:</b>
                /// <para>48734</para>
                /// </summary>
                [NameInMap("SkillId")]
                [Validation(Required=false)]
                public long? SkillId { get; set; }

                /// <summary>
                /// <para>技能值</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("SkillLevel")]
                [Validation(Required=false)]
                public long? SkillLevel { get; set; }

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
        /// <para>90E63D28-E31D-1EB2-8939-A9486641****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
