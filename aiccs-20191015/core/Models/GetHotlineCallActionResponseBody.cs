// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetHotlineCallActionResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHotlineCallActionResponseBodyData Data { get; set; }
        public class GetHotlineCallActionResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Customer ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8999****</para>
            /// </summary>
            [NameInMap("ActionId")]
            [Validation(Required=false)]
            public long? ActionId { get; set; }

            /// <summary>
            /// <para>Tenant ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2367****</para>
            /// </summary>
            [NameInMap("BuId")]
            [Validation(Required=false)]
            public long? BuId { get; set; }

            /// <summary>
            /// <para>Callout ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1122****</para>
            /// </summary>
            [NameInMap("CalloutId")]
            [Validation(Required=false)]
            public long? CalloutId { get; set; }

            /// <summary>
            /// <para>Call name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>王XX</para>
            /// </summary>
            [NameInMap("CalloutName")]
            [Validation(Required=false)]
            public string CalloutName { get; set; }

            /// <summary>
            /// <para>Ticket ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1138902****</para>
            /// </summary>
            [NameInMap("CaseId")]
            [Validation(Required=false)]
            public long? CaseId { get; set; }

            /// <summary>
            /// <para>Channel ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2377****</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <para>Channel Type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Hotline.</description></item>
            /// <item><description><b>2</b>: Online.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ChannelType")]
            [Validation(Required=false)]
            public long? ChannelType { get; set; }

            /// <summary>
            /// <para>Department ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1223****</para>
            /// </summary>
            [NameInMap("DepId")]
            [Validation(Required=false)]
            public long? DepId { get; set; }

            /// <summary>
            /// <para>Indicates whether the call is transferred.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsTransfer")]
            [Validation(Required=false)]
            public string IsTransfer { get; set; }

            /// <summary>
            /// <para>Membership ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7856876****</para>
            /// </summary>
            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public long? MemberId { get; set; }

            /// <summary>
            /// <para>Membership List.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8900****</para>
            /// </summary>
            [NameInMap("MemberList")]
            [Validation(Required=false)]
            public string MemberList { get; set; }

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
            /// <para>Agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1332****</para>
            /// </summary>
            [NameInMap("ServicerId")]
            [Validation(Required=false)]
            public long? ServicerId { get; set; }

            /// <summary>
            /// <para>Agent name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>XX测试</para>
            /// </summary>
            [NameInMap("ServicerName")]
            [Validation(Required=false)]
            public string ServicerName { get; set; }

            /// <summary>
            /// <para>Sub-touch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3423****</para>
            /// </summary>
            [NameInMap("SubTouchId")]
            [Validation(Required=false)]
            public long? SubTouchId { get; set; }

            /// <summary>
            /// <para>Job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <para>Touch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2235****</para>
            /// </summary>
            [NameInMap("TouchId")]
            [Validation(Required=false)]
            public long? TouchId { get; set; }

        }

        /// <summary>
        /// <para>Description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE339D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Succeeded.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
