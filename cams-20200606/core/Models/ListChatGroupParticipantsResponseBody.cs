// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class ListChatGroupParticipantsResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The request status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>OK: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>For other values, see the <a href="https://help.aliyun.com/document_detail/196974.html">error code list</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListChatGroupParticipantsResponseBodyData Data { get; set; }
        public class ListChatGroupParticipantsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of group members.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListChatGroupParticipantsResponseBodyDataList> List { get; set; }
            public class ListChatGroupParticipantsResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The phone number of the group member.</para>
                /// 
                /// <b>Example:</b>
                /// <para>861382***</para>
                /// </summary>
                [NameInMap("ParticipantNumber")]
                [Validation(Required=false)]
                public string ParticipantNumber { get; set; }

            }

            /// <summary>
            /// <para>The total number of participants.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>90E63D28-E31D-1EB2-8939-A94866411B2O</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
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
