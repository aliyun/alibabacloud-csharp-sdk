// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class AllocateCostUnitResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The message code. Example: success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AllocateCostUnitResourceResponseBodyData Data { get; set; }
        public class AllocateCostUnitResourceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the financial unit resource allocation is successful.</para>
            /// <list type="bullet">
            /// <item><description>true: The allocation succeeded.</description></item>
            /// <item><description>false: The allocation failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsSuccess")]
            [Validation(Required=false)]
            public bool? IsSuccess { get; set; }

            /// <summary>
            /// <para>The ID of the destination financial unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32857346527</para>
            /// </summary>
            [NameInMap("ToUnitId")]
            [Validation(Required=false)]
            public long? ToUnitId { get; set; }

            /// <summary>
            /// <para>The ID of the owner of the destination financial unit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>34857693874</para>
            /// </summary>
            [NameInMap("ToUnitUserId")]
            [Validation(Required=false)]
            public long? ToUnitUserId { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful！</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>845C629F-47A7-4F46-A470-ED5047C4C250</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
