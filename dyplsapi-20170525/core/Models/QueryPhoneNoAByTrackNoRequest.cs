// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyplsapi20170525.Models
{
    public class QueryPhoneNoAByTrackNoRequest : TeaModel {
        /// <summary>
        /// The cabinet number.
        /// </summary>
        [NameInMap("CabinetNo")]
        [Validation(Required=false)]
        public string CabinetNo { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// Phone number X returned by the API operation for creating a binding.
        /// </summary>
        [NameInMap("PhoneNoX")]
        [Validation(Required=false)]
        public string PhoneNoX { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The tracking number.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("trackNo")]
        [Validation(Required=false)]
        public string TrackNo { get; set; }

    }

}
