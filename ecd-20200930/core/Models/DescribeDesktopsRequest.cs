// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDesktopsRequest : TeaModel {
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public List<string> DesktopId { get; set; }

        [NameInMap("DesktopName")]
        [Validation(Required=false)]
        public string DesktopName { get; set; }

        [NameInMap("DesktopStatus")]
        [Validation(Required=false)]
        public string DesktopStatus { get; set; }

        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public List<string> EndUserId { get; set; }

        [NameInMap("ExcludedEndUserId")]
        [Validation(Required=false)]
        public List<string> ExcludedEndUserId { get; set; }

        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        [NameInMap("FilterDesktopGroup")]
        [Validation(Required=false)]
        public bool? FilterDesktopGroup { get; set; }

        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        [NameInMap("ManagementFlag")]
        [Validation(Required=false)]
        public string ManagementFlag { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        [NameInMap("OfficeSiteName")]
        [Validation(Required=false)]
        public string OfficeSiteName { get; set; }

        [NameInMap("PolicyGroupId")]
        [Validation(Required=false)]
        public string PolicyGroupId { get; set; }

        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        [NameInMap("QueryFotaUpdate")]
        [Validation(Required=false)]
        public bool? QueryFotaUpdate { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeDesktopsRequestTag> Tag { get; set; }
        public class DescribeDesktopsRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
