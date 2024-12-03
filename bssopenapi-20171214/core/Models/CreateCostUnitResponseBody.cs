// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class CreateCostUnitResponseBody : TeaModel {
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
        public CreateCostUnitResponseBodyData Data { get; set; }
        public class CreateCostUnitResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of cost center entities.</para>
            /// </summary>
            [NameInMap("CostUnitDtoList")]
            [Validation(Required=false)]
            public List<CreateCostUnitResponseBodyDataCostUnitDtoList> CostUnitDtoList { get; set; }
            public class CreateCostUnitResponseBodyDataCostUnitDtoList : TeaModel {
                /// <summary>
                /// <para>The user ID of the owner of the cost center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>26387563</para>
                /// </summary>
                [NameInMap("OwnerUid")]
                [Validation(Required=false)]
                public long? OwnerUid { get; set; }

                /// <summary>
                /// <para>The ID of the parent cost center. A value of -1 indicates the root cost center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("ParentUnitId")]
                [Validation(Required=false)]
                public long? ParentUnitId { get; set; }

                /// <summary>
                /// <para>The ID of the cost center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>84327659328</para>
                /// </summary>
                [NameInMap("UnitId")]
                [Validation(Required=false)]
                public long? UnitId { get; set; }

                /// <summary>
                /// <para>The name of the cost center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("UnitName")]
                [Validation(Required=false)]
                public string UnitName { get; set; }

            }

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
        /// <para>F5B803CF-94D8-43AF-ADB3-D819AAD30E27</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
