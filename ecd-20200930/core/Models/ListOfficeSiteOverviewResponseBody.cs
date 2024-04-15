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
        /// The office network information.
        /// </summary>
        [NameInMap("OfficeSiteOverviewResults")]
        [Validation(Required=false)]
        public List<ListOfficeSiteOverviewResponseBodyOfficeSiteOverviewResults> OfficeSiteOverviewResults { get; set; }
        public class ListOfficeSiteOverviewResponseBodyOfficeSiteOverviewResults : TeaModel {
            /// <summary>
            /// The number of expired cloud computers in the office network.
            /// </summary>
            [NameInMap("HasExpiredEdsCount")]
            [Validation(Required=false)]
            public int? HasExpiredEdsCount { get; set; }

            /// <summary>
            /// The number of expired cloud computers in the cloud computer pool.
            /// </summary>
            [NameInMap("HasExpiredEdsCountForGroup")]
            [Validation(Required=false)]
            public int? HasExpiredEdsCountForGroup { get; set; }

            /// <summary>
            /// The office network ID.
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// The office network name.
            /// </summary>
            [NameInMap("OfficeSiteName")]
            [Validation(Required=false)]
            public string OfficeSiteName { get; set; }

            /// <summary>
            /// The office network status.
            /// 
            /// Default values:
            /// 
            /// *   CONFIGUSERFAILED
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   REGISTERING
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   REGISTERED
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   NEEDCONFIGTRUST
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   CONFIGUSERING
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   CONFIGTRUSTFAILED
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   ERROR
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   CONFIGTRUSTING
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   NEEDCONFIGUSER
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("OfficeSiteStatus")]
            [Validation(Required=false)]
            public string OfficeSiteStatus { get; set; }

            /// <summary>
            /// The ID of the region where the office network resides.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The number of cloud computers that are running in the office network.
            /// </summary>
            [NameInMap("RunningEdsCount")]
            [Validation(Required=false)]
            public int? RunningEdsCount { get; set; }

            /// <summary>
            /// The number of running cloud computers in the cloud computer pool.
            /// </summary>
            [NameInMap("RunningEdsCountForGroup")]
            [Validation(Required=false)]
            public int? RunningEdsCountForGroup { get; set; }

            /// <summary>
            /// The total number of cloud computers in the office network.
            /// </summary>
            [NameInMap("TotalEdsCount")]
            [Validation(Required=false)]
            public int? TotalEdsCount { get; set; }

            /// <summary>
            /// The total number of cloud computers in the cloud computer pool.
            /// </summary>
            [NameInMap("TotalEdsCountForGroup")]
            [Validation(Required=false)]
            public int? TotalEdsCountForGroup { get; set; }

            /// <summary>
            /// The office network type and its suitable VPC type.
            /// 
            /// Valid values:
            /// 
            /// *   standard (default): standard, exclusive VPC
            /// *   customized: custom, user VPC
            /// *   basic: basic, shared VPC
            /// </summary>
            [NameInMap("VpcType")]
            [Validation(Required=false)]
            public string VpcType { get; set; }

            /// <summary>
            /// The number of cloud computers that are about to expire in the office network.
            /// </summary>
            [NameInMap("WillExpiredEdsCount")]
            [Validation(Required=false)]
            public int? WillExpiredEdsCount { get; set; }

            /// <summary>
            /// The number of cloud computers that are about to expire in the cloud computer pool.
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
