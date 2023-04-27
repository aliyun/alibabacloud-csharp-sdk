// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateStandardGroupResponseBody : TeaModel {
        /// <summary>
        /// The name of the security rule set.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The type of the database engine. For more information about the valid values of this parameter, see [DbType parameter](~~198106~~).
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **CreateStandardGroup**.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The name of the security rule set.
        /// </summary>
        [NameInMap("StandardGroup")]
        [Validation(Required=false)]
        public CreateStandardGroupResponseBodyStandardGroup StandardGroup { get; set; }
        public class CreateStandardGroupResponseBodyStandardGroup : TeaModel {
            [NameInMap("DbType")]
            [Validation(Required=false)]
            public string DbType { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("GroupMode")]
            [Validation(Required=false)]
            public string GroupMode { get; set; }

            /// <summary>
            /// The ID of the tenant.
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("LastMenderId")]
            [Validation(Required=false)]
            public long? LastMenderId { get; set; }

        }

        /// <summary>
        /// The error message returned if the request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
