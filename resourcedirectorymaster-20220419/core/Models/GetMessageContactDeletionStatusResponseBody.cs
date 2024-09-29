// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class GetMessageContactDeletionStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The deletion information of the contact.</para>
        /// </summary>
        [NameInMap("ContactDeletionStatus")]
        [Validation(Required=false)]
        public GetMessageContactDeletionStatusResponseBodyContactDeletionStatus ContactDeletionStatus { get; set; }
        public class GetMessageContactDeletionStatusResponseBodyContactDeletionStatus : TeaModel {
            /// <summary>
            /// <para>The ID of the contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-qL4HqKONzOM7****</para>
            /// </summary>
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            /// <summary>
            /// <para>The types of messages received by the contact.</para>
            /// </summary>
            [NameInMap("FailReasonList")]
            [Validation(Required=false)]
            public List<GetMessageContactDeletionStatusResponseBodyContactDeletionStatusFailReasonList> FailReasonList { get; set; }
            public class GetMessageContactDeletionStatusResponseBodyContactDeletionStatusFailReasonList : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud account ID of the member.</para>
                /// 
                /// <b>Example:</b>
                /// <para>199796839435****</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// <para>The types of messages received by the contact.</para>
                /// </summary>
                [NameInMap("MessageTypes")]
                [Validation(Required=false)]
                public List<string> MessageTypes { get; set; }

            }

            /// <summary>
            /// <para>The deletion status of the contact. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Deleting</description></item>
            /// <item><description>Failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Deleting</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95060F1D-6990-4645-8920-A81D1BBFE992</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
