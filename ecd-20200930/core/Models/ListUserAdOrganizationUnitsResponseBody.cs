// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListUserAdOrganizationUnitsResponseBody : TeaModel {
        /// <summary>
        /// A pagination token.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The OUs of the AD domain.
        /// </summary>
        [NameInMap("OUNames")]
        [Validation(Required=false)]
        public List<ListUserAdOrganizationUnitsResponseBodyOUNames> OUNames { get; set; }
        public class ListUserAdOrganizationUnitsResponseBodyOUNames : TeaModel {
            /// <summary>
            /// The name of the OU.
            /// </summary>
            [NameInMap("DisplayOUName")]
            [Validation(Required=false)]
            public string DisplayOUName { get; set; }

            /// <summary>
            /// The canonical name (CNAME) of the OU in the AD domain controller.
            /// </summary>
            [NameInMap("OUName")]
            [Validation(Required=false)]
            public string OUName { get; set; }

            /// <summary>
            /// The enterprise AD office network ID.
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
