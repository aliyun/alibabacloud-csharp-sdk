// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20170115.Models
{
    public class ListClusterServiceConfigResponseBody : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        [NameInMap("ConfigList")]
        [Validation(Required=false)]
        public ListClusterServiceConfigResponseBodyConfigList ConfigList { get; set; }
        public class ListClusterServiceConfigResponseBodyConfigList : TeaModel {
            [NameInMap("Config")]
            [Validation(Required=false)]
            public List<ListClusterServiceConfigResponseBodyConfigListConfig> Config { get; set; }
            public class ListClusterServiceConfigResponseBodyConfigListConfig : TeaModel {
                [NameInMap("DefaultValue")]
                [Validation(Required=false)]
                public string DefaultValue { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NeedRestart")]
                [Validation(Required=false)]
                public string NeedRestart { get; set; }

                [NameInMap("RunningValue")]
                [Validation(Required=false)]
                public string RunningValue { get; set; }

                [NameInMap("Unit")]
                [Validation(Required=false)]
                public string Unit { get; set; }

                [NameInMap("ValueRange")]
                [Validation(Required=false)]
                public string ValueRange { get; set; }

            }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
