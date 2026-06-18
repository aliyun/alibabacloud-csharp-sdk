// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class HotlineSessionQueryRequest : TeaModel {
        /// <summary>
        /// <para>Session ID. The acid received via WebSocket after an inbound call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7719786****</para>
        /// </summary>
        [NameInMap("Acid")]
        [Validation(Required=false)]
        public string Acid { get; set; }

        /// <summary>
        /// <para>Session ID List.</para>
        /// </summary>
        [NameInMap("AcidList")]
        [Validation(Required=false)]
        public List<string> AcidList { get; set; }

        /// <summary>
        /// <para>Call result. Valid values:  </para>
        /// <list type="bullet">
        /// <item><description><b>normal</b>: Normal hang-up.  </description></item>
        /// <item><description><b>touchRouteError</b>: Queue hang-up.  </description></item>
        /// <item><description><b>touchInQueue</b>: Queue hang-up.  </description></item>
        /// <item><description><b>touchInLoss</b>: Queue hang-up.  </description></item>
        /// <item><description><b>userHangup</b>: User hang-up or IVR hang-up.  </description></item>
        /// <item><description><b>sysHangup</b>: System hang-up or IVR hang-up.  </description></item>
        /// <item><description><b>transferAgent</b>: User hang-up or IVR hang-up.  </description></item>
        /// <item><description><b>dailing</b>: Agent hang-up during ringing.  </description></item>
        /// <item><description><b>TouchRingCallLoss</b>: Queue hang-up during ringing.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("CallResult")]
        [Validation(Required=false)]
        public string CallResult { get; set; }

        /// <summary>
        /// <para>List of call results.</para>
        /// </summary>
        [NameInMap("CallResultList")]
        [Validation(Required=false)]
        public List<string> CallResultList { get; set; }

        /// <summary>
        /// <para>Call Type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Outbound call.</description></item>
        /// <item><description><b>2</b>: Inbound call.</description></item>
        /// <item><description><b>3</b>: Change owner.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CallType")]
        [Validation(Required=false)]
        public int? CallType { get; set; }

        /// <summary>
        /// <para>Call Type List.</para>
        /// </summary>
        [NameInMap("CallTypeList")]
        [Validation(Required=false)]
        public List<int?> CallTypeList { get; set; }

        /// <summary>
        /// <para>Calling party number, such as a user\&quot;s phone number, agent number, or machine number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>135615****</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>List of called numbers.</para>
        /// </summary>
        [NameInMap("CalledNumberList")]
        [Validation(Required=false)]
        public List<string> CalledNumberList { get; set; }

        /// <summary>
        /// <para>Calling party number, such as a user\&quot;s phone number, customer service agent number, or machine number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>057177****</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public string CallingNumber { get; set; }

        /// <summary>
        /// <para>List of calling numbers.</para>
        /// </summary>
        [NameInMap("CallingNumberList")]
        [Validation(Required=false)]
        public List<string> CallingNumberList { get; set; }

        /// <summary>
        /// <para>Skill group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>List of skill group IDs.</para>
        /// </summary>
        [NameInMap("GroupIdList")]
        [Validation(Required=false)]
        public List<long?> GroupIdList { get; set; }

        /// <summary>
        /// <para>Skill group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>自动化技能组</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>Global unique ID (GUID) of the call detail.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acc1c58dab4a4****0e3813c66</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>AICCS instance ID.<br>You can obtain it in the <b>Instance Management</b> section of the left-side navigation pane in the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre-cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Membership ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7856****</para>
        /// </summary>
        [NameInMap("MemberId")]
        [Validation(Required=false)]
        public string MemberId { get; set; }

        /// <summary>
        /// <para>Membership List.</para>
        /// </summary>
        [NameInMap("MemberIdList")]
        [Validation(Required=false)]
        public List<string> MemberIdList { get; set; }

        /// <summary>
        /// <para>Membership name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>匿名会员</para>
        /// </summary>
        [NameInMap("MemberName")]
        [Validation(Required=false)]
        public string MemberName { get; set; }

        /// <summary>
        /// <para>Current page number. The value must be greater than <b>0</b>. Default Value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>Page size. The value must be greater than <b>0</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Extension parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>End UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1614829721</para>
        /// </summary>
        [NameInMap("QueryEndTime")]
        [Validation(Required=false)]
        public long? QueryEndTime { get; set; }

        /// <summary>
        /// <para>Start UNIX timestamp. Unit: ms.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1614828721</para>
        /// </summary>
        [NameInMap("QueryStartTime")]
        [Validation(Required=false)]
        public long? QueryStartTime { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Agent ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>555555</para>
        /// </summary>
        [NameInMap("ServicerId")]
        [Validation(Required=false)]
        public string ServicerId { get; set; }

        /// <summary>
        /// <para>List of agent IDs.</para>
        /// </summary>
        [NameInMap("ServicerIdList")]
        [Validation(Required=false)]
        public List<string> ServicerIdList { get; set; }

        /// <summary>
        /// <para>Agent Name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>刘测试</para>
        /// </summary>
        [NameInMap("ServicerName")]
        [Validation(Required=false)]
        public string ServicerName { get; set; }

    }

}
