// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListApplicationResponseBody : TeaModel {
        [NameInMap("ApplicationList")]
        [Validation(Required=false)]
        public ListApplicationResponseBodyApplicationList ApplicationList { get; set; }
        public class ListApplicationResponseBodyApplicationList : TeaModel {
            [NameInMap("Application")]
            [Validation(Required=false)]
            public List<ListApplicationResponseBodyApplicationListApplication> Application { get; set; }
            public class ListApplicationResponseBodyApplicationListApplication : TeaModel {
                public string AppId { get; set; }
                public string ApplicationType { get; set; }
                public long? BuildPackageId { get; set; }
                public string ClusterId { get; set; }
                public int? ClusterType { get; set; }
                public string Name { get; set; }
                public string RegionId { get; set; }
                public string ResourceGroupId { get; set; }
                public int? RunningInstanceCount { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
