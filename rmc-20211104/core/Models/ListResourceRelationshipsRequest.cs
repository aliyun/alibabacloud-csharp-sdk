/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RMC20211104.Models
{
    public class ListResourceRelationshipsRequest : TeaModel {
        /// <summary>
        /// The maximum number of entries to return on each page.
        /// 
        /// Valid values: 1 to 100.
        /// 
        /// Default value: 20.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used to initiate the next request.
        /// 
        /// If the total number of entries returned for the current request exceeds the value of the `MaxResults` parameter, the entries are truncated. In this case, you can use the token to initiate another request and obtain the remaining entries.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The region ID of the resource whose associated resources you want to query.
        /// </summary>
        [NameInMap("SourceRegionId")]
        [Validation(Required=false)]
        public string SourceRegionId { get; set; }

        /// <summary>
        /// The IDs of the resource whose associated resources you want to query.
        /// 
        /// You can specify a maximum of 10 resource IDs.
        /// </summary>
        [NameInMap("SourceResourceId")]
        [Validation(Required=false)]
        public List<string> SourceResourceId { get; set; }

        /// <summary>
        /// The type of the resource whose associated resources you want to query.
        /// </summary>
        [NameInMap("SourceResourceType")]
        [Validation(Required=false)]
        public string SourceResourceType { get; set; }

        /// <summary>
        /// The types of the associated resources that you want to query.
        /// 
        /// You can specify a maximum of 10 resource types.
        /// </summary>
        [NameInMap("TargetResourceType")]
        [Validation(Required=false)]
        public List<string> TargetResourceType { get; set; }

    }

}
