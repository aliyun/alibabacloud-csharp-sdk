// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetDataItemListResponseBody : TeaModel {
        /// <summary>
        /// Response parameters.
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetDataItemListResponseBodyData> Data { get; set; }
        public class GetDataItemListResponseBodyData : TeaModel {
            /// <summary>
            /// The identifier of the data item.
            /// </summary>
            [NameInMap("code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// The name of the data item.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Data filling method, 1: monthly value 2: annual value.
            /// </summary>
            [NameInMap("period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// The data item unit.
            /// </summary>
            [NameInMap("unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
