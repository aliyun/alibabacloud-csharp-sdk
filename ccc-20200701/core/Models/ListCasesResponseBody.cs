// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListCasesResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCasesResponseBodyData Data { get; set; }
        public class ListCasesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>List of contact list execution details.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListCasesResponseBodyDataList> List { get; set; }
            public class ListCasesResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>Phase at which the call was abandoned.</para>
                /// <list type="bullet">
                /// <item><description><para>IVR (IVR interaction phase)</para>
                /// </description></item>
                /// <item><description><para>Queuing (queuing phase)</para>
                /// </description></item>
                /// <item><description><para>Ringing (agent ringing phase)</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Ringing</para>
                /// </summary>
                [NameInMap("AbandonPhase")]
                [Validation(Required=false)]
                public string AbandonPhase { get; set; }

                /// <summary>
                /// <para>The type of call abandonment, that is, the reason why the call was not successfully connected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NA</para>
                /// </summary>
                [NameInMap("AbandonType")]
                [Validation(Required=false)]
                public string AbandonType { get; set; }

                /// <summary>
                /// <para>Number of attempts, which is the total number of calls made to this contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AttemptCount")]
                [Validation(Required=false)]
                public long? AttemptCount { get; set; }

                /// <summary>
                /// <para>System-generated contact ID. Customers do not need to concern themselves with this.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60ecb1a2-4480-4d01-bede-c5b7655bfadf</para>
                /// </summary>
                [NameInMap("CaseId")]
                [Validation(Required=false)]
                public string CaseId { get; set; }

                /// <summary>
                /// <para>Custom variables defined by the customer, formatted as a JSON object. The object can contain up to 10 properties, each with a name and value defined by the customer. These can be configured when creating a predictive outbound dialing activity.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;name&quot;:&quot;yy&quot;,&quot;客戶标签&quot;:&quot;tag-yy&quot;}</para>
                /// </summary>
                [NameInMap("CustomVariables")]
                [Validation(Required=false)]
                public string CustomVariables { get; set; }

                /// <summary>
                /// <para>Reason for outbound call failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>无</para>
                /// </summary>
                [NameInMap("FailureReason")]
                [Validation(Required=false)]
                public string FailureReason { get; set; }

                /// <summary>
                /// <para>Phone number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1888888****</para>
                /// </summary>
                [NameInMap("PhoneNumber")]
                [Validation(Required=false)]
                public string PhoneNumber { get; set; }

                /// <summary>
                /// <para>Status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Connected</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

            /// <summary>
            /// <para>Page number, ranging from 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>Page size, ranging from 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>Total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7CC6523B-0E51-1B62-8DA5-6A9831CAE316</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
