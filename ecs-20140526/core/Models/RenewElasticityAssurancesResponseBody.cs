// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RenewElasticityAssurancesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the renewal order.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// The IDs of the elasticity assurances.
        /// </summary>
        [NameInMap("PrivatePoolOptionsIdSet")]
        [Validation(Required=false)]
        public RenewElasticityAssurancesResponseBodyPrivatePoolOptionsIdSet PrivatePoolOptionsIdSet { get; set; }
        public class RenewElasticityAssurancesResponseBodyPrivatePoolOptionsIdSet : TeaModel {
            [NameInMap("PrivatePoolOptionsId")]
            [Validation(Required=false)]
            public List<string> PrivatePoolOptionsId { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
