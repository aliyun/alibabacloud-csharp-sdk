// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class CreateAgAccountResponseBody : TeaModel {
        /// <summary>
        /// The relationship between the account that is used to call the CreateAgAccount operation and the account that is created.
        /// </summary>
        [NameInMap("AgRelationDto")]
        [Validation(Required=false)]
        public CreateAgAccountResponseBodyAgRelationDto AgRelationDto { get; set; }
        public class CreateAgAccountResponseBodyAgRelationDto : TeaModel {
            /// <summary>
            /// The ID of the account that is used to call the CreateAgAccount operation.
            /// </summary>
            [NameInMap("Mpk")]
            [Validation(Required=false)]
            public string Mpk { get; set; }

            /// <summary>
            /// The ID of the account that is created.
            /// </summary>
            [NameInMap("Pk")]
            [Validation(Required=false)]
            public string Pk { get; set; }

            /// <summary>
            /// The role of the account that is created.
            /// </summary>
            [NameInMap("RamAdminRoleName")]
            [Validation(Required=false)]
            public string RamAdminRoleName { get; set; }

            /// <summary>
            /// The type of the relationship.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

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
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
