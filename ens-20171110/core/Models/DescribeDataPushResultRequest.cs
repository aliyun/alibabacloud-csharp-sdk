// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeDataPushResultRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=true)]
        public string AppId { get; set; }

        [NameInMap("DataNames")]
        [Validation(Required=false)]
        public string DataNames { get; set; }

        [NameInMap("DataVersions")]
        [Validation(Required=false)]
        public string DataVersions { get; set; }

        [NameInMap("MinDate")]
        [Validation(Required=false)]
        public string MinDate { get; set; }

        [NameInMap("MaxDate")]
        [Validation(Required=false)]
        public string MaxDate { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionIds")]
        [Validation(Required=false)]
        public string RegionIds { get; set; }

    }

}
