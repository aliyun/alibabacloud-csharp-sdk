// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDomainGroupsResponseBody : TeaModel {
        /// <summary>
        /// The list of domain name groups.
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
                /// The ID of the domain name group.
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
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of domain name groups.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
