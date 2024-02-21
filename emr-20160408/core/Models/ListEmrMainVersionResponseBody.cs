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
                [NameInMap("ClusterTypeInfoList")]
                [Validation(Required=false)]
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
                                [NameInMap("Display")]
                                [Validation(Required=false)]
                                public bool? Display { get; set; }

                                [NameInMap("Mandatory")]
                                [Validation(Required=false)]
                                public bool? Mandatory { get; set; }

                                [NameInMap("ServiceDisplayName")]
                                [Validation(Required=false)]
                                public string ServiceDisplayName { get; set; }

                                [NameInMap("ServiceDisplayVersion")]
                                [Validation(Required=false)]
                                public string ServiceDisplayVersion { get; set; }

                                [NameInMap("ServiceName")]
                                [Validation(Required=false)]
                                public string ServiceName { get; set; }

                                [NameInMap("ServiceVersion")]
                                [Validation(Required=false)]
                                public string ServiceVersion { get; set; }

                            }

                        }

                    }

                }

                [NameInMap("ClusterTypeWhiteUserList")]
                [Validation(Required=false)]
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

                [NameInMap("Display")]
                [Validation(Required=false)]
                public bool? Display { get; set; }

                [NameInMap("EcmVersion")]
                [Validation(Required=false)]
                public bool? EcmVersion { get; set; }

                [NameInMap("EmrVersion")]
                [Validation(Required=false)]
                public string EmrVersion { get; set; }

                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("PublishType")]
                [Validation(Required=false)]
                public string PublishType { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("StackName")]
                [Validation(Required=false)]
                public string StackName { get; set; }

                [NameInMap("StackVersion")]
                [Validation(Required=false)]
                public string StackVersion { get; set; }

                [NameInMap("WhiteUserList")]
                [Validation(Required=false)]
                public ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersionWhiteUserList WhiteUserList { get; set; }
                public class ListEmrMainVersionResponseBodyEmrMainVersionListEmrMainVersionWhiteUserList : TeaModel {
                    [NameInMap("WhiteUser")]
                    [Validation(Required=false)]
                    public List<string> WhiteUser { get; set; }

                }

            }

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
        public int? TotalCount { get; set; }

    }

}
