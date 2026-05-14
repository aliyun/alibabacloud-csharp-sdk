// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkCreateQueueRequest : TeaModel {
        /// <summary>
        /// <para>在线客服排队位置推送(小于该位置则推送)；默认值为 10</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ChatLocation")]
        [Validation(Required=false)]
        public long? ChatLocation { get; set; }

        /// <summary>
        /// <para>在线客服最大排队数；默认值为 20</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("ChatMaxWait")]
        [Validation(Required=false)]
        public long? ChatMaxWait { get; set; }

        /// <summary>
        /// <para>在线客服分配策略，2：轮选；4：随机；5：技能优先；默认值为 2</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ChatStrategy")]
        [Validation(Required=false)]
        public long? ChatStrategy { get; set; }

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
        /// <para>是否允许呼入队列，0: 否；1: 是；默认值为 1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IbAllowed")]
        [Validation(Required=false)]
        public long? IbAllowed { get; set; }

        /// <summary>
        /// <para>队列中为空时是否可以join，1: 置忙；2: 通话中；4: 振铃；8: 无效；16: 整理 如选多种状态则传对应数值的和，如选置忙和通话中，值为 3。默认值为 0，即都未选中</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("JoinEmpty")]
        [Validation(Required=false)]
        public long? JoinEmpty { get; set; }

        /// <summary>
        /// <para>最大并发置忙座席数，开关配置，0:关闭，1:开启；默认值为 0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxPauseClientFlag")]
        [Validation(Required=false)]
        public long? MaxPauseClientFlag { get; set; }

        /// <summary>
        /// <para>最大并发置忙座席数，配置类型，0:百分比，1:数值；默认值为 0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxPauseClientType")]
        [Validation(Required=false)]
        public long? MaxPauseClientType { get; set; }

        /// <summary>
        /// <para>最大并发置忙座席数，配置值，当配置类型为百分比时最大值为100，默认值为 0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("MaxPauseClientValue")]
        [Validation(Required=false)]
        public long? MaxPauseClientValue { get; set; }

        /// <summary>
        /// <para>最大等待数，设置范围 0-999，0 表示不做任何限制。默认值为 5</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MaxWait")]
        [Validation(Required=false)]
        public long? MaxWait { get; set; }

        /// <summary>
        /// <para>座席超时时间，取值范围 20-60 秒。默认值为 25</para>
        /// 
        /// <b>Example:</b>
        /// <para>26</para>
        /// </summary>
        [NameInMap("MemberTimeout")]
        [Validation(Required=false)]
        public long? MemberTimeout { get; set; }

        /// <summary>
        /// <para>队列名称，只允许输入中文，字母，数字，下划线，长度不超过 20 个字符</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>队列工号，4 位数字，要求唯一</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1111</para>
        /// </summary>
        [NameInMap("Qno")]
        [Validation(Required=false)]
        public string Qno { get; set; }

        /// <summary>
        /// <para>队列内座席及技能值设置。技能值 1-10，技能值 1 的优先级为最高 cno 队列下座席号 penalty该座席在队列中的优先级</para>
        /// </summary>
        [NameInMap("QueueMembers")]
        [Validation(Required=false)]
        public List<ClinkCreateQueueRequestQueueMembers> QueueMembers { get; set; }
        public class ClinkCreateQueueRequestQueueMembers : TeaModel {
            /// <summary>
            /// <para>队列下座席号</para>
            /// 
            /// <b>Example:</b>
            /// <para>1111</para>
            /// </summary>
            [NameInMap("Cno")]
            [Validation(Required=false)]
            public string Cno { get; set; }

            /// <summary>
            /// <para>该座席在队列中的优先级</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Penalty")]
            [Validation(Required=false)]
            public long? Penalty { get; set; }

        }

        /// <summary>
        /// <para>队列超时时间，取值范围 30-600 秒。默认值为 600</para>
        /// 
        /// <b>Example:</b>
        /// <para>33</para>
        /// </summary>
        [NameInMap("QueueTimeout")]
        [Validation(Required=false)]
        public long? QueueTimeout { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>是否报座席号，0: 否；1:是；默认值为 0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SayCno")]
        [Validation(Required=false)]
        public long? SayCno { get; set; }

        /// <summary>
        /// <para>服务水平秒数，取值范围 10-30 秒，低于此时间内接听的认为是高服务水平。默认值为 15</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("ServiceLevel")]
        [Validation(Required=false)]
        public long? ServiceLevel { get; set; }

        /// <summary>
        /// <para>呼叫策略， 1：顺序，2：轮选，3：平均，4：随机，5：技能优先，6：距上一通呼入空闲时间累计最长，7：技能优先+距上一通呼入空闲时间累计最长，8：距上一通呼入空闲时间累计最长(全队列)，9：技能优先+距上一通呼入空闲时间累计最长(全队列)，10：全队列平均，11：技能优先+轮选，12：最长空闲时长，13：技能优先+当前空闲状态时长最长，14：距上一通通话空闲时间累计最长，默认值为 2</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Strategy")]
        [Validation(Required=false)]
        public long? Strategy { get; set; }

        /// <summary>
        /// <para>VIP客户优先，0:不支持；1:支持；默认值为 0</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("VipSupport")]
        [Validation(Required=false)]
        public long? VipSupport { get; set; }

        /// <summary>
        /// <para>队列优先级，取值范围 1-10。默认值为 1 座席属于多个队列时，优先级高的队列的来电将优先接听；数值越高，优先级越高</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("Weight")]
        [Validation(Required=false)]
        public long? Weight { get; set; }

        /// <summary>
        /// <para>整理时长，取值范围 3-300 秒，整理期间座席不接受新的呼叫。默认值为 15</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("WrapupTime")]
        [Validation(Required=false)]
        public long? WrapupTime { get; set; }

    }

}
