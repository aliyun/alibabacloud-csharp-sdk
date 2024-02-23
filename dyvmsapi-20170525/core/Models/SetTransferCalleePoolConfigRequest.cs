// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class SetTransferCalleePoolConfigRequest : TeaModel {
        /// <summary>
        /// The call mode. Valid values:
        /// 
        /// *   **roundRobin**
        /// *   **random**
        /// </summary>
        [NameInMap("CalledRouteMode")]
        [Validation(Required=false)]
        public string CalledRouteMode { get; set; }

        /// <summary>
        /// The information about the phone numbers for transferring the call.
        /// </summary>
        [NameInMap("Details")]
        [Validation(Required=false)]
        public List<SetTransferCalleePoolConfigRequestDetails> Details { get; set; }
        public class SetTransferCalleePoolConfigRequestDetails : TeaModel {
            /// <summary>
            /// The called number.
            /// </summary>
            [NameInMap("Called")]
            [Validation(Required=false)]
            public string Called { get; set; }

            /// <summary>
            /// The calling number.
            /// </summary>
            [NameInMap("Caller")]
            [Validation(Required=false)]
            public string Caller { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The phone number used for transferring the call.
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The qualification ID. You can call the [GetHotlineQualificationByOrder](~~393548~~) operation to obtain the qualification ID.
        /// </summary>
        [NameInMap("QualificationId")]
        [Validation(Required=false)]
        public string QualificationId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
