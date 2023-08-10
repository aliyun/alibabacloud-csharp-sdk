// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam20211201.Models
{
    public class ListOrganizationalUnitsForApplicationResponseBody : TeaModel {
        /// <summary>
        /// The IDs of the organizations that are allowed to access the application.
        /// </summary>
        [NameInMap("OrganizationalUnits")]
        [Validation(Required=false)]
        public List<ListOrganizationalUnitsForApplicationResponseBodyOrganizationalUnits> OrganizationalUnits { get; set; }
        public class ListOrganizationalUnitsForApplicationResponseBodyOrganizationalUnits : TeaModel {
            /// <summary>
            /// The ID of the organization that is allowed to access the application.
            /// </summary>
            [NameInMap("OrganizationalUnitId")]
            [Validation(Required=false)]
            public string OrganizationalUnitId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of the returned entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
