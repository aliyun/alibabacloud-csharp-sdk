// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class ListDeployableInstancesResponseBody : TeaModel {
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<ListDeployableInstancesResponseBodyDataList> DataList { get; set; }
        public class ListDeployableInstancesResponseBodyDataList : TeaModel {
            [NameInMap("CloudGameInstanceId")]
            [Validation(Required=false)]
            public string CloudGameInstanceId { get; set; }

            [NameInMap("CloudGameInstanceName")]
            [Validation(Required=false)]
            public string CloudGameInstanceName { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
