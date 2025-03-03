// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class DeleteTargetsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The code 200 indicates that the request was successful. Other codes indicate that the request failed. For information about error codes, see Error codes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteTargetsResponseBodyData Data { get; set; }
        public class DeleteTargetsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information about the event body that failed to be processed.</para>
            /// </summary>
            [NameInMap("ErrorEntries")]
            [Validation(Required=false)]
            public List<DeleteTargetsResponseBodyDataErrorEntries> ErrorEntries { get; set; }
            public class DeleteTargetsResponseBodyDataErrorEntries : TeaModel {
                /// <summary>
                /// <para>The ID of the event body that failed to be processed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>target5</para>
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
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The id of event target is duplicate!</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

            }

            /// <summary>
            /// <para>The number of event bodies that failed to be processed. Valid values: 0: No event bodies failed to be processed. An integer other than 0: the number of event bodies that failed to be processed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ErrorEntriesCount")]
            [Validation(Required=false)]
            public int? ErrorEntriesCount { get; set; }

        }

        /// <summary>
        /// <para>The returned error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EventBusNotExist</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>78FA9EAC-F0C0-58B0-871E-9F9756CE1D29</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation is successful. Valid values: true and false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
