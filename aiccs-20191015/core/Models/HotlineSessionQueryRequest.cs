// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class HotlineSessionQueryRequest : TeaModel {
        /// <summary>
        /// <para>The session ID. The acid in the websocket after an inbound call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7719786****</para>
        /// </summary>
        [NameInMap("Acid")]
        [Validation(Required=false)]
        public string Acid { get; set; }

        /// <summary>
        /// <para>The list of session IDs.</para>
        /// </summary>
        [NameInMap("AcidList")]
        [Validation(Required=false)]
        public List<string> AcidList { get; set; }

        /// <summary>
        /// <para>The call result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>normal</b>: normal hangup.</description></item>
        /// <item><description><b>touchRouteError</b>: queue hangup.</description></item>
        /// <item><description><b>touchInQueue</b>: queue hangup.</description></item>
        /// <item><description><b>touchInLoss</b>: queue hangup.</description></item>
        /// <item><description><b>userHangup</b>: user hangup or IVR hangup.</description></item>
        /// <item><description><b>sysHangup</b>: system hangup or IVR hangup.</description></item>
        /// <item><description><b>transferAgent</b>: user hangup or IVR hangup.</description></item>
        /// <item><description><b>dailing</b>: agent hangup or ringing hangup.</description></item>
        /// <item><description><b>TouchRingCallLoss</b>: queue hangup or ringing hangup.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("CallResult")]
        [Validation(Required=false)]
        public string CallResult { get; set; }

        /// <summary>
        /// <para>The list of call results.</para>
        /// </summary>
        [NameInMap("CallResultList")]
        [Validation(Required=false)]
        public List<string> CallResultList { get; set; }

        /// <summary>
        /// <para>The call type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: outbound call.</description></item>
        /// <item><description><b>2</b>: inbound call.</description></item>
        /// <item><description><b>3</b>: transferred call.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CallType")]
        [Validation(Required=false)]
        public int? CallType { get; set; }

        /// <summary>
        /// <para>The list of call types.</para>
        /// </summary>
        [NameInMap("CallTypeList")]
        [Validation(Required=false)]
        public List<int?> CallTypeList { get; set; }

        /// <summary>
        /// <para>The number of the caller. For example, a mobile phone number of a user, an agent number, or a robot number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>135615****</para>
        /// </summary>
        [NameInMap("CalledNumber")]
        [Validation(Required=false)]
        public string CalledNumber { get; set; }

        /// <summary>
        /// <para>The list of called numbers.</para>
        /// </summary>
        [NameInMap("CalledNumberList")]
        [Validation(Required=false)]
        public List<string> CalledNumberList { get; set; }

        /// <summary>
        /// <para>The number of the callee. For example, a mobile phone number of a user, an agent number, or a robot number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>057177****</para>
        /// </summary>
        [NameInMap("CallingNumber")]
        [Validation(Required=false)]
        public string CallingNumber { get; set; }

        /// <summary>
        /// <para>The list of calling numbers.</para>
        /// </summary>
        [NameInMap("CallingNumberList")]
        [Validation(Required=false)]
        public List<string> CallingNumberList { get; set; }

        /// <summary>
        /// <para>The ID of the skill group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The list of skill group IDs.</para>
        /// </summary>
        [NameInMap("GroupIdList")]
        [Validation(Required=false)]
        public List<long?> GroupIdList { get; set; }

        /// <summary>
        /// <para>The name of the skill group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AutomationSkillGroup</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The globally unique ID of the call details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acc1c58dab4a4****0e3813c66</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The ID of the Artificial Intelligence Cloud Call Service (AICCS) instance.
        /// You can obtain the instance ID from <b>Instance Management</b> in the left-side navigation pane of the <a href="https://aiccs.console.aliyun.com/overview">Artificial Intelligence Cloud Call Service console</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc_xp_pre-cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The member ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7856****</para>
        /// </summary>
        [NameInMap("MemberId")]
        [Validation(Required=false)]
        public string MemberId { get; set; }

        /// <summary>
        /// <para>The list of member IDs.</para>
        /// </summary>
        [NameInMap("MemberIdList")]
        [Validation(Required=false)]
        public List<string> MemberIdList { get; set; }

        /// <summary>
        /// <para>The member name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AnonymousMember</para>
        /// </summary>
        [NameInMap("MemberName")]
        [Validation(Required=false)]
        public string MemberName { get; set; }

        /// <summary>
        /// <para>The current page number. The value must be greater than <b>0</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The value must be greater than <b>0</b>. Default value: <b>20</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The extended parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>The end timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1614829721</para>
        /// </summary>
        [NameInMap("QueryEndTime")]
        [Validation(Required=false)]
        public long? QueryEndTime { get; set; }

        /// <summary>
        /// <para>The start timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1614828721</para>
        /// </summary>
        [NameInMap("QueryStartTime")]
        [Validation(Required=false)]
        public long? QueryStartTime { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The agent ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>555555</para>
        /// </summary>
        [NameInMap("ServicerId")]
        [Validation(Required=false)]
        public string ServicerId { get; set; }

        /// <summary>
        /// <para>The list of agent IDs.</para>
        /// </summary>
        [NameInMap("ServicerIdList")]
        [Validation(Required=false)]
        public List<string> ServicerIdList { get; set; }

        /// <summary>
        /// <para>The agent name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestAgent</para>
        /// </summary>
        [NameInMap("ServicerName")]
        [Validation(Required=false)]
        public string ServicerName { get; set; }

    }

}
