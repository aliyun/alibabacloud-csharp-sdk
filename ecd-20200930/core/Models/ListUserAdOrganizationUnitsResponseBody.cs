// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListUserAdOrganizationUnitsResponseBody : TeaModel {
        /// <summary>
        /// The token that is used to start the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The names of the OUs in the AD domain.
        /// </summary>
        [NameInMap("OUNames")]
        [Validation(Required=false)]
        public List<ListUserAdOrganizationUnitsResponseBodyOUNames> OUNames { get; set; }
        public class ListUserAdOrganizationUnitsResponseBodyOUNames : TeaModel {
            /// <summary>
            /// The display name of the OU.
            /// </summary>
            [NameInMap("DisplayOUName")]
            [Validation(Required=false)]
            public string DisplayOUName { get; set; }

            /// <summary>
            /// The name of the OU of the AD domain controller.
            /// </summary>
            [NameInMap("OUName")]
            [Validation(Required=false)]
            public string OUName { get; set; }

            /// <summary>
            /// The ID of the AD workspace.
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
