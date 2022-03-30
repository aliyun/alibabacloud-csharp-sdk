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
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("SourceRegionId")]
        [Validation(Required=false)]
        public string SourceRegionId { get; set; }

        [NameInMap("SourceResourceId")]
        [Validation(Required=false)]
        public List<string> SourceResourceId { get; set; }

        [NameInMap("SourceResourceType")]
        [Validation(Required=false)]
        public string SourceResourceType { get; set; }

        [NameInMap("TargetResourceType")]
        [Validation(Required=false)]
        public List<string> TargetResourceType { get; set; }

    }

}
