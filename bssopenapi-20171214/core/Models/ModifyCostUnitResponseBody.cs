// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class ModifyCostUnitResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ModifyCostUnitResponseBodyData> Data { get; set; }
        public class ModifyCostUnitResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the cost center was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsSuccess")]
            [Validation(Required=false)]
            public bool? IsSuccess { get; set; }

            /// <summary>
            /// <para>The user ID of the cost center owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>823756287</para>
            /// </summary>
            [NameInMap("OwnerUid")]
            [Validation(Required=false)]
            public long? OwnerUid { get; set; }

            /// <summary>
            /// <para>The ID of the cost center.</para>
            /// 
            /// <b>Example:</b>
            /// <para>356349875</para>
            /// </summary>
            [NameInMap("UnitId")]
            [Validation(Required=false)]
            public long? UnitId { get; set; }

        }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Successful!</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F5B803CF-94D8-43AF-ADB3-D819AAD30E27</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
