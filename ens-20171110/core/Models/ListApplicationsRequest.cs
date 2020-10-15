// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class ListApplicationsRequest : TeaModel {
        [NameInMap("ClusterNames")]
        [Validation(Required=false)]
        public string ClusterNames { get; set; }

        [NameInMap("AppVersions")]
        [Validation(Required=false)]
        public string AppVersions { get; set; }

        [NameInMap("Level")]
        [Validation(Required=false)]
        public string Level { get; set; }

        [NameInMap("OutAppInfoParams")]
        [Validation(Required=false)]
        public string OutAppInfoParams { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("MinDate")]
        [Validation(Required=false)]
        public string MinDate { get; set; }

        [NameInMap("MaxDate")]
        [Validation(Required=false)]
        public string MaxDate { get; set; }

    }

}
