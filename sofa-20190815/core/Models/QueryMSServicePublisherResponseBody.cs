// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryMSServicePublisherResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("Publishers")]
        [Validation(Required=false)]
        public List<QueryMSServicePublisherResponseBodyPublishers> Publishers { get; set; }
        public class QueryMSServicePublisherResponseBodyPublishers : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("HostIp")]
            [Validation(Required=false)]
            public string HostIp { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("ServiceIp")]
            [Validation(Required=false)]
            public string ServiceIp { get; set; }

            [NameInMap("ServicePort")]
            [Validation(Required=false)]
            public int? ServicePort { get; set; }

            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

            [NameInMap("Zone")]
            [Validation(Required=false)]
            public string Zone { get; set; }

        }

    }

}
