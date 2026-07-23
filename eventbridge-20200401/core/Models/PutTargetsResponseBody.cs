// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class PutTargetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description><para>Success: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>Other values indicate an error. For details, see Error codes.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PutTargetsResponseBodyData Data { get; set; }
        public class PutTargetsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Details about the event targets that failed to be processed.</para>
            /// </summary>
            [NameInMap("ErrorEntries")]
            [Validation(Required=false)]
            public List<PutTargetsResponseBodyDataErrorEntries> ErrorEntries { get; set; }
            public class PutTargetsResponseBodyDataErrorEntries : TeaModel {
                /// <summary>
                /// <para>The ID of the failed event target.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Mlm123456JHd2RsRoKw</para>
                /// </summary>
                [NameInMap("EntryId")]
                [Validation(Required=false)]
                public string EntryId { get; set; }

                /// <summary>
                /// <para>The error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EventRuleTargetIdDuplicate</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The description of the error.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The id of event target is duplicate!</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

            }

            /// <summary>
            /// <para>The number of event targets that failed to be processed. A value of 0 indicates that all event targets were processed successfully.</para>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// <item><description></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ErrorEntriesCount")]
            [Validation(Required=false)]
            public int? ErrorEntriesCount { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The event rule not existed!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique ID that Alibaba Cloud generates for the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6FB52207-7621-5292-BDF2-A17E2E984160</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returns true if the operation is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
