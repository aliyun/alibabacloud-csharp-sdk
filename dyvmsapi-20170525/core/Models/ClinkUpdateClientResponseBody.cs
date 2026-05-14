// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkUpdateClientResponseBody : TeaModel {
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
        public ClinkUpdateClientResponseBodyData Data { get; set; }
        public class ClinkUpdateClientResponseBodyData : TeaModel {
            [NameInMap("Client")]
            [Validation(Required=false)]
            public ClinkUpdateClientResponseBodyDataClient Client { get; set; }
            public class ClinkUpdateClientResponseBodyDataClient : TeaModel {
                /// <summary>
                /// <para>启用状态，0: 停用；1: 启用</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Active")]
                [Validation(Required=false)]
                public long? Active { get; set; }

                /// <summary>
                /// <para>所属区号</para>
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
                /// <para>可外显号码集合</para>
                /// </summary>
                [NameInMap("Clid")]
                [Validation(Required=false)]
                public List<string> Clid { get; set; }

                /// <summary>
                /// <para>给地区指定可外显号码</para>
                /// </summary>
                [NameInMap("ClidArea")]
                [Validation(Required=false)]
                public List<ClinkUpdateClientResponseBodyDataClientClidArea> ClidArea { get; set; }
                public class ClinkUpdateClientResponseBodyDataClientClidArea : TeaModel {
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
                    /// <para>示例值示例值</para>
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
                /// <para>缺省外显号码集合，当clidType（外显号码类型）值为3且clidRule（外显规则）值为1时，支持配置缺省外显</para>
                /// </summary>
                [NameInMap("ClidDefault")]
                [Validation(Required=false)]
                public List<string> ClidDefault { get; set; }

                /// <summary>
                /// <para>外显规则，根据外显号码类型值来定义，1: 随机；2: 轮选 或 1: 动态；2: 自定义</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ClidRule")]
                [Validation(Required=false)]
                public long? ClidRule { get; set; }

                /// <summary>
                /// <para>外显号码类型，0: 全部；2: 座席指定；3: 智能外显</para>
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
                /// <para>云号码四种呼叫模式；数组长度 为 4，依次对应云号码外呼的四种模式（实体卡、工作卡、两端呼、RTC)的开启状态；</para>
                /// </summary>
                [NameInMap("CloudNumberModes")]
                [Validation(Required=false)]
                public List<long?> CloudNumberModes { get; set; }

                /// <summary>
                /// <para>座席工号</para>
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
                /// <para>51</para>
                /// </summary>
                [NameInMap("CrmId")]
                [Validation(Required=false)]
                public long? CrmId { get; set; }

                /// <summary>
                /// <para>动态号码组名称，当assignType（号码类型）值为1（动态号码组）时为必填项</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("DynamicTelGroupName")]
                [Validation(Required=false)]
                public string DynamicTelGroupName { get; set; }

                /// <summary>
                /// <para>号码隐藏类型，0: 不隐藏；1: 隐藏规则与全局设置保持一致</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("HiddenTel")]
                [Validation(Required=false)]
                public long? HiddenTel { get; set; }

                /// <summary>
                /// <para>座席名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>座席密码</para>
                /// 
                /// <b>Example:</b>
                /// <para>xxx</para>
                /// </summary>
                [NameInMap("Password")]
                [Validation(Required=false)]
                public string Password { get; set; }

                /// <summary>
                /// <para>permission</para>
                /// </summary>
                [NameInMap("Permission")]
                [Validation(Required=false)]
                public ClinkUpdateClientResponseBodyDataClientPermission Permission { get; set; }
                public class ClinkUpdateClientResponseBodyDataClientPermission : TeaModel {
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
                    /// <para>3</para>
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
                /// <para>所属队列号集合</para>
                /// </summary>
                [NameInMap("Qnos")]
                [Validation(Required=false)]
                public List<string> Qnos { get; set; }

                /// <summary>
                /// <para>轮选方式，1: 按天轮选；2: 按次轮选</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RecurrentselectionType")]
                [Validation(Required=false)]
                public long? RecurrentselectionType { get; set; }

                /// <summary>
                /// <para>轮选值设置 1: 按天轮选，每 n 天外呼更换一次外显号码，可设置 1-30 天 2: 按次轮选，每 n 次外呼更换一次外显号码，可设置 1-30 次</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("RecurrentselectionValue")]
                [Validation(Required=false)]
                public long? RecurrentselectionValue { get; set; }

                /// <summary>
                /// <para>座席角色，0: 普通座席；1: 班长座席</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public long? Role { get; set; }

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
                /// <para>整理时长，座席进行外呼操作后的整理时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>79</para>
                /// </summary>
                [NameInMap("WrapupTime")]
                [Validation(Required=false)]
                public long? WrapupTime { get; set; }

            }

            /// <summary>
            /// <para>请求 id</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例值示例值</para>
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
        /// <para>D9CB3933-9FE3-4870-BA8E-2BEE91B69D23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
