// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Agency20221216.Models
{
    public class CreateCustomerRequest : TeaModel {
        /// <summary>
        /// Customer\\"s name.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CustomerName")]
        [Validation(Required=false)]
        public string CustomerName { get; set; }

        /// <summary>
        /// The source/channel that allow client to connected with us. Please enumerate with Customer Source.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CustomerSource")]
        [Validation(Required=false)]
        public string CustomerSource { get; set; }

        /// <summary>
        /// The sub-industry that Customer\\"s business belongs to. Please enumerate with Customer Trade.
        /// </summary>
        [NameInMap("CustomerSubTrade")]
        [Validation(Required=false)]
        public string CustomerSubTrade { get; set; }

        /// <summary>
        /// The industry that Customer\\"s business belongs to. Please enumerate with Customer Trade.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CustomerTrade")]
        [Validation(Required=false)]
        public string CustomerTrade { get; set; }

        /// <summary>
        /// The region that Customer choose to launch the Cloud Service. Please use ListCountries to confirm the valid region list for current UID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Nation")]
        [Validation(Required=false)]
        public string Nation { get; set; }

    }

}
