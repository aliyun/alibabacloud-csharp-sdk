// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeUserConnectionRecordsRequest : TeaModel {
        [NameInMap("ConnectDurationFrom")]
        [Validation(Required=false)]
        public long? ConnectDurationFrom { get; set; }

        [NameInMap("ConnectDurationTo")]
        [Validation(Required=false)]
        public long? ConnectDurationTo { get; set; }

        [NameInMap("ConnectEndTimeFrom")]
        [Validation(Required=false)]
        public long? ConnectEndTimeFrom { get; set; }

        [NameInMap("ConnectEndTimeTo")]
        [Validation(Required=false)]
        public long? ConnectEndTimeTo { get; set; }

        [NameInMap("ConnectStartTimeFrom")]
        [Validation(Required=false)]
        public long? ConnectStartTimeFrom { get; set; }

        [NameInMap("ConnectStartTimeTo")]
        [Validation(Required=false)]
        public long? ConnectStartTimeTo { get; set; }

        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        [NameInMap("DesktopId")]
        [Validation(Required=false)]
        public string DesktopId { get; set; }

        [NameInMap("EndUserId")]
        [Validation(Required=false)]
        public string EndUserId { get; set; }

        [NameInMap("EndUserType")]
        [Validation(Required=false)]
        public string EndUserType { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
