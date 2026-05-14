// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkDescribeClientResponseBody : TeaModel {
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
        public ClinkDescribeClientResponseBodyData Data { get; set; }
        public class ClinkDescribeClientResponseBodyData : TeaModel {
            [NameInMap("Client")]
            [Validation(Required=false)]
            public ClinkDescribeClientResponseBodyDataClient Client { get; set; }
            public class ClinkDescribeClientResponseBodyDataClient : TeaModel {
                /// <summary>
                /// <para>是否激活，0: 否；1: 是</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Active")]
                [Validation(Required=false)]
                public long? Active { get; set; }

                /// <summary>
                /// <para>区号</para>
                /// 
                /// <b>Example:</b>
                /// <para>010</para>
                /// </summary>
                [NameInMap("AreaCode")]
                [Validation(Required=false)]
                public string AreaCode { get; set; }

                /// <summary>
                /// <para>座席满意度自动执行，1：开启；0：关闭，默认开启</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AutoInvestigation")]
                [Validation(Required=false)]
                public long? AutoInvestigation { get; set; }

                /// <summary>
                /// <para>座席绑定电话</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("BindTel")]
                [Validation(Required=false)]
                public string BindTel { get; set; }

                /// <summary>
                /// <para>外显号码数组</para>
                /// </summary>
                [NameInMap("Clid")]
                [Validation(Required=false)]
                public List<string> Clid { get; set; }

                /// <summary>
                /// <para>按地区外显配置，当clidType（外显号码类型）值为3且clidRule（外显规则）值为2（自定义）时有意义，具体配置项见 clidArea 对象</para>
                /// </summary>
                [NameInMap("ClidArea")]
                [Validation(Required=false)]
                public List<ClinkDescribeClientResponseBodyDataClientClidArea> ClidArea { get; set; }
                public class ClinkDescribeClientResponseBodyDataClientClidArea : TeaModel {
                    /// <summary>
                    /// <para>地区组名称</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>示例值示例值</para>
                    /// </summary>
                    [NameInMap("AreaGroupName")]
                    [Validation(Required=false)]
                    public string AreaGroupName { get; set; }

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
                    /// <para>动态号码组名称，当assignType（号码类型）值为1（动态号码组）时为必填项</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("DynamicTelGroupName")]
                    [Validation(Required=false)]
                    public string DynamicTelGroupName { get; set; }

                    /// <summary>
                    /// <para>外显号码</para>
                    /// </summary>
                    [NameInMap("ObClids")]
                    [Validation(Required=false)]
                    public List<string> ObClids { get; set; }

                }

                /// <summary>
                /// <para>外显规则 当clidType（外显号码类型）值为0（全部）时，1:随机；2: 轮选。 当clidType（外显号码类型）值为3（智能外显）时，1:动态；2: 自定义。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ClidRule")]
                [Validation(Required=false)]
                public long? ClidRule { get; set; }

                /// <summary>
                /// <para>外显号码类型，0: 全部; 2: 座席指定; 3: 智能外显</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
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
                /// <para>云号码四种呼叫模式；数组长度 为 4，依次对应云号码外呼的四种模式（实体卡、工作卡、两端呼、RTC)的开启状态；</para>
                /// </summary>
                [NameInMap("CloudNumberModes")]
                [Validation(Required=false)]
                public List<long?> CloudNumberModes { get; set; }

                /// <summary>
                /// <para>座席号</para>
                /// 
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("Cno")]
                [Validation(Required=false)]
                public string Cno { get; set; }

                /// <summary>
                /// <para>座席crm id</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("CrmId")]
                [Validation(Required=false)]
                public string CrmId { get; set; }

                /// <summary>
                /// <para>号码隐藏类型，0: 不隐藏；1: 隐藏规则与全局设置保持一致</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("HiddenTel")]
                [Validation(Required=false)]
                public string HiddenTel { get; set; }

                /// <summary>
                /// <para>呼入整理时长，客户来电座席接听，双方通话结束后座席的话后处理时长，此期间座席不接收新的客户来电。取值范围：0～3600秒。</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("IbWrapupTime")]
                [Validation(Required=false)]
                public long? IbWrapupTime { get; set; }

                /// <summary>
                /// <para>呼入整理类型，1：队列；2：座席。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IbWrapupType")]
                [Validation(Required=false)]
                public long? IbWrapupType { get; set; }

                /// <summary>
                /// <para>座席名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>xclient</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>外呼挂机短信开关 0：关闭， 1：开启。开启后，当座席发起外呼时，系统会依据【短信中心 - 短信设置 - 外呼双方接听通知 / 外呼客户未接听通知】中的配置条件发送短信。</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ObHangupSms")]
                [Validation(Required=false)]
                public long? ObHangupSms { get; set; }

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
                /// </summary>
                [NameInMap("Permission")]
                [Validation(Required=false)]
                public ClinkDescribeClientResponseBodyDataClientPermission Permission { get; set; }
                public class ClinkDescribeClientResponseBodyDataClientPermission : TeaModel {
                    /// <summary>
                    /// <para>语音转写，0: 关闭；1: 呼入开启；2 外呼开启；3 全部开启；默认值为 0</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Asr")]
                    [Validation(Required=false)]
                    public long? Asr { get; set; }

                    /// <summary>
                    /// <para>外呼权限，0: 关闭；1: 无限制；2: 国内长途；3: 国内本地，默认值为 1</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Call")]
                    [Validation(Required=false)]
                    public long? Call { get; set; }

                    /// <summary>
                    /// <para>通话记录查看权限，1: 全部；2: 所属队列；3:本座席，默认值为 1</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Cdr")]
                    [Validation(Required=false)]
                    public long? Cdr { get; set; }

                    /// <summary>
                    /// <para>在线客服查看会话记录权限 ，0：全部、1：所属队列、2：本座席； 默认值为 0</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Chat")]
                    [Validation(Required=false)]
                    public long? Chat { get; set; }

                    /// <summary>
                    /// <para>其他数据查看权限：1：全部 2：所属员工组 3：自己 4:指定员工组 ,默认所属员工组</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("OtherData")]
                    [Validation(Required=false)]
                    public long? OtherData { get; set; }

                    /// <summary>
                    /// <para>通话录音权限，0: 关闭；1: 呼入；2: 外呼；3: 全部，默认值为 3</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Record")]
                    [Validation(Required=false)]
                    public long? Record { get; set; }

                    /// <summary>
                    /// <para>录音试听下载权限，0: 关闭；1: 试听下载；2：试听，默认值 1</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("RecordDownload")]
                    [Validation(Required=false)]
                    public long? RecordDownload { get; set; }

                    /// <summary>
                    /// <para>短信发送权限，0: 关闭；1: 开启，默认值为 0</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Sms")]
                    [Validation(Required=false)]
                    public long? Sms { get; set; }

                    /// <summary>
                    /// <para>外呼任务查看权限，1：全部 3：自己，默认全部</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("TaskInventory")]
                    [Validation(Required=false)]
                    public long? TaskInventory { get; set; }

                    /// <summary>
                    /// <para>通话转移/咨询权限，可选范围，0：全部，1：所属员工组, 默认所属员工组</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Transfer")]
                    [Validation(Required=false)]
                    public long? Transfer { get; set; }

                }

                /// <summary>
                /// <para>座席所属队列的队列号数组</para>
                /// </summary>
                [NameInMap("Qnos")]
                [Validation(Required=false)]
                public List<string> Qnos { get; set; }

                /// <summary>
                /// <para>座席所属队列详情</para>
                /// </summary>
                [NameInMap("Queues")]
                [Validation(Required=false)]
                public List<ClinkDescribeClientResponseBodyDataClientQueues> Queues { get; set; }
                public class ClinkDescribeClientResponseBodyDataClientQueues : TeaModel {
                    /// <summary>
                    /// <para>队列名称</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xx1</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>优先级</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("Penalty")]
                    [Validation(Required=false)]
                    public long? Penalty { get; set; }

                    /// <summary>
                    /// <para>队列号</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1122</para>
                    /// </summary>
                    [NameInMap("Qno")]
                    [Validation(Required=false)]
                    public string Qno { get; set; }

                }

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

                /// <summary>
                /// <para>座席备用手机号</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("ReserveTel")]
                [Validation(Required=false)]
                public string ReserveTel { get; set; }

                /// <summary>
                /// <para>座席角色，0: 普通座席；1: 班长座席</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public long? Role { get; set; }

                /// <summary>
                /// <para>座席服务地区，区号数组 配置座席服务的地区，可用于外呼任务中“按服务地区分配”的策略。</para>
                /// </summary>
                [NameInMap("ServeArea")]
                [Validation(Required=false)]
                public List<string> ServeArea { get; set; }

                /// <summary>
                /// <para>座席状态，0: 离线；1: 在线</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public long? Status { get; set; }

                /// <summary>
                /// <para>电话绑定类型，电话类型， 1: 固话；2: 手机；3:IP话机；4:软电话</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TelType")]
                [Validation(Required=false)]
                public long? TelType { get; set; }

                /// <summary>
                /// <para>座席类型，1：全渠道、2：呼叫中心、3：在线客服</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public long? Type { get; set; }

                /// <summary>
                /// <para>整理时长，座席进行外呼操作后的整理时间，取值范围 0-300 秒。</para>
                /// 
                /// <b>Example:</b>
                /// <para>59</para>
                /// </summary>
                [NameInMap("WrapupTime")]
                [Validation(Required=false)]
                public long? WrapupTime { get; set; }

            }

            /// <summary>
            /// <para>请求 id</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值示例值</para>
            /// </summary>
            [NameInMap("ClinkRequestId")]
            [Validation(Required=false)]
            public string ClinkRequestId { get; set; }

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
        /// <para>ED815433-724A-4357-9991-A54AD2FF09FD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
