// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkDescribeQueueResponseBody : TeaModel {
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
        public ClinkDescribeQueueResponseBodyData Data { get; set; }
        public class ClinkDescribeQueueResponseBodyData : TeaModel {
            /// <summary>
            /// <para>请求 id</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("ClinkRequestId")]
            [Validation(Required=false)]
            public string ClinkRequestId { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public ClinkDescribeQueueResponseBodyDataResult Result { get; set; }
            public class ClinkDescribeQueueResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>在线客服排队位置推送(小于该位置则推送)</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("ChatLocation")]
                [Validation(Required=false)]
                public long? ChatLocation { get; set; }

                /// <summary>
                /// <para>在线客服最大排队数</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("ChatMaxWait")]
                [Validation(Required=false)]
                public long? ChatMaxWait { get; set; }

                /// <summary>
                /// <para>在线客服分配策略，2：轮选；4：随机；5：技能优先</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ChatStrategy")]
                [Validation(Required=false)]
                public long? ChatStrategy { get; set; }

                /// <summary>
                /// <para>企业id</para>
                /// 
                /// <b>Example:</b>
                /// <para>8004970</para>
                /// </summary>
                [NameInMap("EnterpriseId")]
                [Validation(Required=false)]
                public long? EnterpriseId { get; set; }

                /// <summary>
                /// <para>允许呼入队列 0：不允许 1：允许</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IbAllowed")]
                [Validation(Required=false)]
                public long? IbAllowed { get; set; }

                /// <summary>
                /// <para>队列中为空时是否可以join（设置了队列等待数，来电进入队列后处于等待状态，等待超时才溢出；如果勾选了这几个选项，认为座席不可用，直接溢出，减少客户等待时间）， 1: 置忙；2: 通话中；4: 振铃；8: 无效；16: 整理。 如选多种状态则传对应数值的和，如选置忙和通话中，值为 3</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("JoinEmpty")]
                [Validation(Required=false)]
                public long? JoinEmpty { get; set; }

                /// <summary>
                /// <para>最大并发置忙座席数，开关配置</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MaxPauseClientFlag")]
                [Validation(Required=false)]
                public long? MaxPauseClientFlag { get; set; }

                /// <summary>
                /// <para>最大并发置忙座席数，配置类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MaxPauseClientType")]
                [Validation(Required=false)]
                public long? MaxPauseClientType { get; set; }

                /// <summary>
                /// <para>最大并发置忙座席数，配置值</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MaxPauseClientValue")]
                [Validation(Required=false)]
                public long? MaxPauseClientValue { get; set; }

                /// <summary>
                /// <para>呼叫中心最大排队数</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("MaxWait")]
                [Validation(Required=false)]
                public long? MaxWait { get; set; }

                /// <summary>
                /// <para>座席超时时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>51</para>
                /// </summary>
                [NameInMap("MemberTimeout")]
                [Validation(Required=false)]
                public long? MemberTimeout { get; set; }

                /// <summary>
                /// <para>队列名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>41</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public long? Name { get; set; }

                /// <summary>
                /// <para>队列号</para>
                /// 
                /// <b>Example:</b>
                /// <para>2201</para>
                /// </summary>
                [NameInMap("Qno")]
                [Validation(Required=false)]
                public string Qno { get; set; }

                /// <summary>
                /// <para>cno 座席号 penalty 优先级 type 座席类型 1：全渠道、2：呼叫中心、3：在线客服</para>
                /// </summary>
                [NameInMap("QueueMembers")]
                [Validation(Required=false)]
                public List<ClinkDescribeQueueResponseBodyDataResultQueueMembers> QueueMembers { get; set; }
                public class ClinkDescribeQueueResponseBodyDataResultQueueMembers : TeaModel {
                    /// <summary>
                    /// <para>座席号</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2233</para>
                    /// </summary>
                    [NameInMap("Cno")]
                    [Validation(Required=false)]
                    public string Cno { get; set; }

                    /// <summary>
                    /// <para>优先级</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Penalty")]
                    [Validation(Required=false)]
                    public long? Penalty { get; set; }

                    /// <summary>
                    /// <para>座席类型</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public long? Type { get; set; }

                }

                /// <summary>
                /// <para>队列超时时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>51</para>
                /// </summary>
                [NameInMap("QueueTimeout")]
                [Validation(Required=false)]
                public long? QueueTimeout { get; set; }

                /// <summary>
                /// <para>座席超时无应答,呼叫下一座席的延迟秒数,⇐0时采用默认值5。</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("Retry")]
                [Validation(Required=false)]
                public long? Retry { get; set; }

                /// <summary>
                /// <para>语音报号(是否报座席号)(1：是 0：否)</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SayCno")]
                [Validation(Required=false)]
                public long? SayCno { get; set; }

                /// <summary>
                /// <para>服务水平秒数，取值范围 10-30秒，低于此时间内接听的认为是高服务水平</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ServiceLevel")]
                [Validation(Required=false)]
                public long? ServiceLevel { get; set; }

                /// <summary>
                /// <para>呼叫策略，1：顺序，2：轮选，3：平均，4：随机，5：技能优先，6：距上一通呼入空闲时间累计最长，7：技能优先+距上一通呼入空闲时间累计最长，8：距上一通呼入空闲时间累计最长(全队列)，9：技能优先+距上一通呼入空闲时间累计最长(全队列)，10：全队列平均，11：技能优先+轮选，12：最长空闲时长，13：技能优先+当前空闲状态时长最长，14：距上一通通话空闲时间累计最长</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Strategy")]
                [Validation(Required=false)]
                public long? Strategy { get; set; }

                /// <summary>
                /// <para>支持VIP级别(VIP客户优先)(0：不支持 1：支持)</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("VipSupport")]
                [Validation(Required=false)]
                public long? VipSupport { get; set; }

                /// <summary>
                /// <para>队列优先级，取值范围 1-10。默认值为 1，座席属于多个队列时，优先级高的队列的来电将优先接听；数值越高，优先级越高</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public long? Weight { get; set; }

                /// <summary>
                /// <para>整理时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>45</para>
                /// </summary>
                [NameInMap("WrapupTime")]
                [Validation(Required=false)]
                public long? WrapupTime { get; set; }

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
        /// <para>F655A8D5-B967-440B-8683-DAD6FF8DE990</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
