// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetHotlineCallActionResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHotlineCallActionResponseBodyData Data { get; set; }
        public class GetHotlineCallActionResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>8999****</para>
            /// </summary>
            [NameInMap("ActionId")]
            [Validation(Required=false)]
            public long? ActionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2367****</para>
            /// </summary>
            [NameInMap("BuId")]
            [Validation(Required=false)]
            public long? BuId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1122****</para>
            /// </summary>
            [NameInMap("CalloutId")]
            [Validation(Required=false)]
            public long? CalloutId { get; set; }

            [NameInMap("CalloutName")]
            [Validation(Required=false)]
            public string CalloutName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1138902****</para>
            /// </summary>
            [NameInMap("CaseId")]
            [Validation(Required=false)]
            public long? CaseId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2377****</para>
            /// </summary>
            [NameInMap("ChannelId")]
            [Validation(Required=false)]
            public string ChannelId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ChannelType")]
            [Validation(Required=false)]
            public long? ChannelType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1223****</para>
            /// </summary>
            [NameInMap("DepId")]
            [Validation(Required=false)]
            public long? DepId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsTransfer")]
            [Validation(Required=false)]
            public string IsTransfer { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>7856876****</para>
            /// </summary>
            [NameInMap("MemberId")]
            [Validation(Required=false)]
            public long? MemberId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>8900****</para>
            /// </summary>
            [NameInMap("MemberList")]
            [Validation(Required=false)]
            public string MemberList { get; set; }

            [NameInMap("MemberName")]
            [Validation(Required=false)]
            public string MemberName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1332****</para>
            /// </summary>
            [NameInMap("ServicerId")]
            [Validation(Required=false)]
            public long? ServicerId { get; set; }

            [NameInMap("ServicerName")]
            [Validation(Required=false)]
            public string ServicerName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3423****</para>
            /// </summary>
            [NameInMap("SubTouchId")]
            [Validation(Required=false)]
            public long? SubTouchId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>12345****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public long? TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2235****</para>
            /// </summary>
            [NameInMap("TouchId")]
            [Validation(Required=false)]
            public long? TouchId { get; set; }

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
        /// <para>EE339D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
