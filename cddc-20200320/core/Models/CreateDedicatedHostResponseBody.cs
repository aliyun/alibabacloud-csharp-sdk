// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cddc20200320.Models
{
    public class CreateDedicatedHostResponseBody : TeaModel {
        /// <summary>
        /// The created hosts.
        /// </summary>
        [NameInMap("DedicateHostList")]
        [Validation(Required=false)]
        public CreateDedicatedHostResponseBodyDedicateHostList DedicateHostList { get; set; }
        public class CreateDedicatedHostResponseBodyDedicateHostList : TeaModel {
            [NameInMap("DedicateHostList")]
            [Validation(Required=false)]
            public List<CreateDedicatedHostResponseBodyDedicateHostListDedicateHostList> DedicateHostList { get; set; }
            public class CreateDedicatedHostResponseBodyDedicateHostListDedicateHostList : TeaModel {
                /// <summary>
                /// The host ID.
                /// </summary>
                [NameInMap("DedicatedHostId")]
                [Validation(Required=false)]
                public string DedicatedHostId { get; set; }

            }

        }

        /// <summary>
        /// The order ID.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public long? OrderId { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
