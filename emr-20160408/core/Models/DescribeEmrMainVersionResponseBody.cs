// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class DescribeEmrMainVersionResponseBody : TeaModel {
        [NameInMap("EmrMainVersion")]
        [Validation(Required=false)]
        public DescribeEmrMainVersionResponseBodyEmrMainVersion EmrMainVersion { get; set; }
        public class DescribeEmrMainVersionResponseBodyEmrMainVersion : TeaModel {
            [NameInMap("ClusterTypeInfoList")]
            [Validation(Required=false)]
            public DescribeEmrMainVersionResponseBodyEmrMainVersionClusterTypeInfoList ClusterTypeInfoList { get; set; }
            public class DescribeEmrMainVersionResponseBodyEmrMainVersionClusterTypeInfoList : TeaModel {
                [NameInMap("ClusterTypeInfo")]
                [Validation(Required=false)]
                public List<DescribeEmrMainVersionResponseBodyEmrMainVersionClusterTypeInfoListClusterTypeInfo> ClusterTypeInfo { get; set; }
                public class DescribeEmrMainVersionResponseBodyEmrMainVersionClusterTypeInfoListClusterTypeInfo : TeaModel {
                    [NameInMap("ClusterType")]
                    [Validation(Required=false)]
                    public string ClusterType { get; set; }

                    [NameInMap("ServiceInfoList")]
                    [Validation(Required=false)]
                    public DescribeEmrMainVersionResponseBodyEmrMainVersionClusterTypeInfoListClusterTypeInfoServiceInfoList ServiceInfoList { get; set; }
                    public class DescribeEmrMainVersionResponseBodyEmrMainVersionClusterTypeInfoListClusterTypeInfoServiceInfoList : TeaModel {
                        [NameInMap("ServiceInfo")]
                        [Validation(Required=false)]
                        public List<DescribeEmrMainVersionResponseBodyEmrMainVersionClusterTypeInfoListClusterTypeInfoServiceInfoListServiceInfo> ServiceInfo { get; set; }
                        public class DescribeEmrMainVersionResponseBodyEmrMainVersionClusterTypeInfoListClusterTypeInfoServiceInfoListServiceInfo : TeaModel {
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
            [NameInMap("ClusterTypeWhiteUserList")]
            [Validation(Required=false)]
            public DescribeEmrMainVersionResponseBodyEmrMainVersionClusterTypeWhiteUserList ClusterTypeWhiteUserList { get; set; }
            public class DescribeEmrMainVersionResponseBodyEmrMainVersionClusterTypeWhiteUserList : TeaModel {
                [NameInMap("ClusterTypeWhiteUser")]
                [Validation(Required=false)]
                public List<DescribeEmrMainVersionResponseBodyEmrMainVersionClusterTypeWhiteUserListClusterTypeWhiteUser> ClusterTypeWhiteUser { get; set; }
                public class DescribeEmrMainVersionResponseBodyEmrMainVersionClusterTypeWhiteUserListClusterTypeWhiteUser : TeaModel {
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
            public DescribeEmrMainVersionResponseBodyEmrMainVersionWhiteUserList WhiteUserList { get; set; }
            public class DescribeEmrMainVersionResponseBodyEmrMainVersionWhiteUserList : TeaModel {
                [NameInMap("WwhiteUser")]
                [Validation(Required=false)]
                public List<string> WwhiteUser { get; set; }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
