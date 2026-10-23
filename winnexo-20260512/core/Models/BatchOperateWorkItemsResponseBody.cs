// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class BatchOperateWorkItemsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The results for each item. The order of the results matches the order of the items in the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<BatchOperateWorkItemsResponseBodyItems> Items { get; set; }
        public class BatchOperateWorkItemsResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The reason for skipping or failure.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>Indicates whether the execution was successful.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

            /// <summary>
            /// <para>The ID of the work item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("workItemId")]
            [Validation(Required=false)]
            public string WorkItemId { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource does not exist</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of skipped or failed operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("skipped")]
        [Validation(Required=false)]
        public long? Skipped { get; set; }

        /// <summary>
        /// <para>The number of successful operations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("succeeded")]
        [Validation(Required=false)]
        public long? Succeeded { get; set; }

    }

}
