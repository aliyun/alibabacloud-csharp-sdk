// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ots20160620.Models
{
    public class ListInstanceResponseBody : TeaModel {
        [NameInMap("InstanceInfos")]
        [Validation(Required=false)]
        public ListInstanceResponseBodyInstanceInfos InstanceInfos { get; set; }
        public class ListInstanceResponseBodyInstanceInfos : TeaModel {
            [NameInMap("InstanceInfo")]
            [Validation(Required=false)]
            public List<ListInstanceResponseBodyInstanceInfosInstanceInfo> InstanceInfo { get; set; }
            public class ListInstanceResponseBodyInstanceInfosInstanceInfo : TeaModel {
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

        }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
