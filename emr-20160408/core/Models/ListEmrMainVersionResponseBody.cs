// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListEmrMainVersionResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("EmrMainVersionList")]
        [Validation(Required=false)]
        public ListEmrMainVersionResponseBodyEmrMainVersionList EmrMainVersionList { get; set; }
        public class ListEmrMainVersionResponseBodyEmrMainVersionList : TeaModel {
            [NameInMap("EmrMainVersion")]
            [Validation(Required=false)]
            public List<ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersion> EmrMainVersion { get; set; }
            public class ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersion : TeaModel {
                [NameInMap("ClusterTypeInfo")]
                [Validation(Required=false)]
                public List<ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersionClusterTypeInfo> ClusterTypeInfo { get; set; }
                public class ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersionClusterTypeInfo : TeaModel {
                    [NameInMap("ServiceInfoList")]
                    [Validation(Required=false)]
                    public ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersionClusterTypeInfoServiceInfoList ServiceInfoList { get; set; }
                    public class ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersionClusterTypeInfoServiceInfoList : TeaModel {
                        [NameInMap("ServiceInfo")]
                        [Validation(Required=false)]
                        public List<ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersionClusterTypeInfoServiceInfoListServiceInfo> ServiceInfo { get; set; }
                        public class ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersionClusterTypeInfoServiceInfoListServiceInfo : TeaModel {
                            public string ServiceDisplayName { get; set; }
                            public string ServiceVersion { get; set; }
                            public bool? Display { get; set; }
                            public string ServiceDisplayVersion { get; set; }
                            public bool? Mandatory { get; set; }
                            public string ServiceName { get; set; }
                        }
                    };

                    [NameInMap("ClusterType")]
                    [Validation(Required=false)]
                    public string ClusterType { get; set; }

                }

            }
        };

    }

}
