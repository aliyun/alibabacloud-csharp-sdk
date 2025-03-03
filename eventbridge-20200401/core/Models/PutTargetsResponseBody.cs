// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class PutTargetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Success: The call succeeded.</description></item>
        /// <item><description>Other codes: The call failed. For more information about error codes, see Error codes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PutTargetsResponseBodyData Data { get; set; }
        public class PutTargetsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the failed event target.</para>
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
                /// <para>The error code returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>EventRuleTargetIdDuplicate</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The id of event target is duplicate!</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

            }

            /// <summary>
            /// <para>The number of failed event targets. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: All event targets succeeded.</description></item>
            /// <item><description>An integer other than 0: indicates the number of failed event targets.</description></item>
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
        /// <para>The error message that is returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The event rule not existed!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6FB52207-7621-5292-BDF2-A17E2E984160</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
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
