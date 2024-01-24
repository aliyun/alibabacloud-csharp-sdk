// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class CreateDrdsInstanceResponseBody : TeaModel {
        /// <summary>
        /// Indicates the details of the result.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateDrdsInstanceResponseBodyData Data { get; set; }
        public class CreateDrdsInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates the ID of the instance.
            /// </summary>
            [NameInMap("DrdsInstanceIdList")]
            [Validation(Required=false)]
            public CreateDrdsInstanceResponseBodyDataDrdsInstanceIdList DrdsInstanceIdList { get; set; }
            public class CreateDrdsInstanceResponseBodyDataDrdsInstanceIdList : TeaModel {
                [NameInMap("drdsInstanceIdList")]
                [Validation(Required=false)]
                public List<string> DrdsInstanceIdList { get; set; }

            }

            /// <summary>
            /// Indicates the ID of the order.
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

        }

        /// <summary>
        /// Indicates the ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
