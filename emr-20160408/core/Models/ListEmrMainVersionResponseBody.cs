// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListEmrMainVersionResponseBody : TeaModel {
        [NameInMap("EmrMainVersionList")]
        [Validation(Required=false)]
        public ListEmrMainVersionResponseBodyEmrMainVersionList EmrMainVersionList { get; set; }
        public class ListEmrMainVersionResponseBodyEmrMainVersionList : TeaModel {
            [NameInMap("EmrMainVersion")]
            [Validation(Required=false)]
            public List<ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersion> EmrMainVersion { get; set; }
            public class ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersion : TeaModel {
                public ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersionClusterTypeInfoList ClusterTypeInfoList { get; set; }
                public class ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersionClusterTypeInfoList : TeaModel {
                    [NameInMap("ClusterTypeInfo")]
                    [Validation(Required=false)]
                    public List<ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersionClusterTypeInfoListClusterTypeInfo> ClusterTypeInfo { get; set; }
                    public class ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersionClusterTypeInfoListClusterTypeInfo : TeaModel {
                        [NameInMap("ClusterType")]
                        [Validation(Required=false)]
                        public string ClusterType { get; set; }

                        [NameInMap("ServiceInfoList")]
                        [Validation(Required=false)]
                        public ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersionClusterTypeInfoListClusterTypeInfoServiceInfoList ServiceInfoList { get; set; }
                        public class ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersionClusterTypeInfoListClusterTypeInfoServiceInfoList : TeaModel {
                            [NameInMap("ServiceInfo")]
                            [Validation(Required=false)]
                            public List<ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersionClusterTypeInfoListClusterTypeInfoServiceInfoListServiceInfo> ServiceInfo { get; set; }
                            public class ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersionClusterTypeInfoListClusterTypeInfoServiceInfoListServiceInfo : TeaModel {
                                public bool? Display { get; set; }
                                public bool? Mandatory { get; set; }
                                public string ServiceDisplayName { get; set; }
                                public string ServiceDisplayVersion { get; set; }
                                public string ServiceName { get; set; }
                                public string ServiceVersion { get; set; }
                            }
                        };

                    }

                }
                public ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersionClusterTypeWhiteUserList ClusterTypeWhiteUserList { get; set; }
                public class ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersionClusterTypeWhiteUserList : TeaModel {
                    [NameInMap("ClusterTypeWhiteUser")]
                    [Validation(Required=false)]
                    public List<ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersionClusterTypeWhiteUserListClusterTypeWhiteUser> ClusterTypeWhiteUser { get; set; }
                    public class ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersionClusterTypeWhiteUserListClusterTypeWhiteUser : TeaModel {
                        [NameInMap("ClusterType")]
                        [Validation(Required=false)]
                        public string ClusterType { get; set; }

                        [NameInMap("UserId")]
                        [Validation(Required=false)]
                        public string UserId { get; set; }

                    }

                }
                public bool? Display { get; set; }
                public bool? EcmVersion { get; set; }
                public string EmrVersion { get; set; }
                public string ImageId { get; set; }
                public string PublishType { get; set; }
                public string RegionId { get; set; }
                public string StackName { get; set; }
                public string StackVersion { get; set; }
                public ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersionWhiteUserList WhiteUserList { get; set; }
                public class ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersionWhiteUserList : TeaModel {
                    [NameInMap("WhiteUser")]
                    [Validation(Required=false)]
                    public List<string> WhiteUser { get; set; }

                }
            }
        };

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
        public int? TotalCount { get; set; }

    }

}
