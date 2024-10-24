// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class CreateCostUnitResponseBody : TeaModel {
        /// <summary>
        /// The status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateCostUnitResponseBodyData Data { get; set; }
        public class CreateCostUnitResponseBodyData : TeaModel {
            /// <summary>
            /// The list of cost center entities.
            /// </summary>
            [NameInMap("CostUnitDtoList")]
            [Validation(Required=false)]
            public List<CreateCostUnitResponseBodyDataCostUnitDtoList> CostUnitDtoList { get; set; }
            public class CreateCostUnitResponseBodyDataCostUnitDtoList : TeaModel {
                /// <summary>
                /// The user ID of the owner of the cost center.
                /// </summary>
                [NameInMap("OwnerUid")]
                [Validation(Required=false)]
                public long? OwnerUid { get; set; }

                /// <summary>
                /// The ID of the parent cost center. A value of -1 indicates the root cost center.
                /// </summary>
                [NameInMap("ParentUnitId")]
                [Validation(Required=false)]
                public long? ParentUnitId { get; set; }

                /// <summary>
                /// The ID of the cost center.
                /// </summary>
                [NameInMap("UnitId")]
                [Validation(Required=false)]
                public long? UnitId { get; set; }

                /// <summary>
                /// The name of the cost center.
                /// </summary>
                [NameInMap("UnitName")]
                [Validation(Required=false)]
                public string UnitName { get; set; }

            }

        }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
