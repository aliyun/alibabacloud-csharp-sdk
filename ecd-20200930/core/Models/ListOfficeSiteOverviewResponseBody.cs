// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ListOfficeSiteOverviewResponseBody : TeaModel {
        /// <summary>
        /// The token that is used to start the next query. If this parameter is empty, all results are returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// Details of the workspaces.
        /// </summary>
        [NameInMap("OfficeSiteOverviewResults")]
        [Validation(Required=false)]
        public List<ListOfficeSiteOverviewResponseBodyOfficeSiteOverviewResults> OfficeSiteOverviewResults { get; set; }
        public class ListOfficeSiteOverviewResponseBodyOfficeSiteOverviewResults : TeaModel {
            /// <summary>
            /// The number of expired cloud desktops in the workspace.
            /// </summary>
            [NameInMap("HasExpiredEdsCount")]
            [Validation(Required=false)]
            public int? HasExpiredEdsCount { get; set; }

            /// <summary>
            /// The number of expired cloud desktops in the desktop group.
            /// </summary>
            [NameInMap("HasExpiredEdsCountForGroup")]
            [Validation(Required=false)]
            public int? HasExpiredEdsCountForGroup { get; set; }

            /// <summary>
            /// The ID of the workspace.
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// The name of the workspace.
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// The status of the workspace.
            /// </summary>
            [NameInMap("OfficeSiteStatus")]
            [Validation(Required=false)]
            public string OfficeSiteStatus { get; set; }

            /// <summary>
            /// The region ID of the workspace.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The number of running cloud desktops in the workspace.
            /// </summary>
            [NameInMap("RunningEdsCount")]
            [Validation(Required=false)]
            public int? RunningEdsCount { get; set; }

            /// <summary>
            /// The number of running cloud desktops in the desktop group.
            /// </summary>
            [NameInMap("RunningEdsCountForGroup")]
            [Validation(Required=false)]
            public int? RunningEdsCountForGroup { get; set; }

            /// <summary>
            /// The total number of cloud desktops in the workspace.
            /// </summary>
            [NameInMap("TotalEdsCount")]
            [Validation(Required=false)]
            public int? TotalEdsCount { get; set; }

            /// <summary>
            /// The total number of cloud desktops in the desktop group.
            /// </summary>
            [NameInMap("TotalEdsCountForGroup")]
            [Validation(Required=false)]
            public int? TotalEdsCountForGroup { get; set; }

            /// <summary>
            /// The virtual private cloud (VPC) type of the workspace.
            /// </summary>
            [NameInMap("VpcType")]
            [Validation(Required=false)]
            public string VpcType { get; set; }

            /// <summary>
            /// The number of cloud desktops that are about to expire in the workspace.
            /// </summary>
            [NameInMap("WillExpiredEdsCount")]
            [Validation(Required=false)]
            public int? WillExpiredEdsCount { get; set; }

            /// <summary>
            /// The number of cloud desktops that are about to expire in the desktop group.
            /// </summary>
            [NameInMap("WillExpiredEdsCountForGroup")]
            [Validation(Required=false)]
            public int? WillExpiredEdsCountForGroup { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
