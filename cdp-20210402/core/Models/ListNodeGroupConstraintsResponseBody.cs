// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdp20210402.Models
{
    public class ListNodeGroupConstraintsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListNodeGroupConstraintsResponseBodyData> Data { get; set; }
        public class ListNodeGroupConstraintsResponseBodyData : TeaModel {
            [NameInMap("HostGroupType")]
            [Validation(Required=false)]
            public string HostGroupType { get; set; }

            [NameInMap("RecommendedInstanceTypes")]
            [Validation(Required=false)]
            public List<string> RecommendedInstanceTypes { get; set; }

            [NameInMap("availableDataDiskCategories")]
            [Validation(Required=false)]
            public List<string> AvailableDataDiskCategories { get; set; }

            [NameInMap("availableInstanceTypes")]
            [Validation(Required=false)]
            public List<string> AvailableInstanceTypes { get; set; }

            [NameInMap("availableSystemDiskCategories")]
            [Validation(Required=false)]
            public List<string> AvailableSystemDiskCategories { get; set; }

            [NameInMap("defaultDataDiskCount")]
            [Validation(Required=false)]
            public int? DefaultDataDiskCount { get; set; }

            [NameInMap("defaultDataDiskSize")]
            [Validation(Required=false)]
            public int? DefaultDataDiskSize { get; set; }

            [NameInMap("defaultNodeCount")]
            [Validation(Required=false)]
            public int? DefaultNodeCount { get; set; }

            [NameInMap("defaultSystemDiskSize")]
            [Validation(Required=false)]
            public int? DefaultSystemDiskSize { get; set; }

            [NameInMap("maxDataDiskCount")]
            [Validation(Required=false)]
            public int? MaxDataDiskCount { get; set; }

            [NameInMap("maxDataDiskSize")]
            [Validation(Required=false)]
            public int? MaxDataDiskSize { get; set; }

            [NameInMap("maxNodeCount")]
            [Validation(Required=false)]
            public int? MaxNodeCount { get; set; }

            [NameInMap("maxSystemDiskSize")]
            [Validation(Required=false)]
            public int? MaxSystemDiskSize { get; set; }

            [NameInMap("minDataDiskCount")]
            [Validation(Required=false)]
            public int? MinDataDiskCount { get; set; }

            [NameInMap("minDataDiskSize")]
            [Validation(Required=false)]
            public int? MinDataDiskSize { get; set; }

            [NameInMap("minNodeCount")]
            [Validation(Required=false)]
            public int? MinNodeCount { get; set; }

            [NameInMap("minSystemDiskSize")]
            [Validation(Required=false)]
            public int? MinSystemDiskSize { get; set; }

            [NameInMap("nodeGroupName")]
            [Validation(Required=false)]
            public string NodeGroupName { get; set; }

        }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
