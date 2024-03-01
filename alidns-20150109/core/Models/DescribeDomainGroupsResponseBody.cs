// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainGroupsResponseBody : TeaModel {
        /// <summary>
        /// The domain name groups.
        /// </summary>
        [NameInMap("DomainGroups")]
        [Validation(Required=false)]
        public DescribeDomainGroupsResponseBodyDomainGroups DomainGroups { get; set; }
        public class DescribeDomainGroupsResponseBodyDomainGroups : TeaModel {
            [NameInMap("DomainGroup")]
            [Validation(Required=false)]
            public List<DescribeDomainGroupsResponseBodyDomainGroupsDomainGroup> DomainGroup { get; set; }
            public class DescribeDomainGroupsResponseBodyDomainGroupsDomainGroup : TeaModel {
                /// <summary>
                /// The number of domain name groups.
                /// </summary>
                [NameInMap("DomainCount")]
                [Validation(Required=false)]
                public long? DomainCount { get; set; }

                /// <summary>
                /// The ID of the domain name group. Valid values:
                /// 
                /// *   defaultGroup: the default group
                /// *   If an empty string is returned, it indicates the group that contains all domain names.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The name of the domain name group.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

            }

        }

        /// <summary>
        /// The page number. Pages start from page **1**. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: **1 to 100**. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
