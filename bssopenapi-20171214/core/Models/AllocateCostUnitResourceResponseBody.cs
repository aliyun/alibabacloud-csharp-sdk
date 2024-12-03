// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class AllocateCostUnitResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public AllocateCostUnitResourceResponseBodyData Data { get; set; }
        public class AllocateCostUnitResourceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether resources are allocated to the specified cost center. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: The resources are allocated to the specified cost center.</description></item>
            /// <item><description>false: The resources fail to be allocated to the specified cost center.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsSuccess")]
            [Validation(Required=false)]
            public bool? IsSuccess { get; set; }

            /// <summary>
            /// <para>The ID of the destination cost center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32857346527</para>
            /// </summary>
            [NameInMap("ToUnitId")]
            [Validation(Required=false)]
            public long? ToUnitId { get; set; }

            /// <summary>
            /// <para>The user ID of the owner of the destination cost center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>34857693874</para>
            /// </summary>
            [NameInMap("ToUnitUserId")]
            [Validation(Required=false)]
            public long? ToUnitUserId { get; set; }

        }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful！</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
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
