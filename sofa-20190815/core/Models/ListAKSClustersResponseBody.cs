// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListAKSClustersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListAKSClustersResponseBodyList> List { get; set; }
        public class ListAKSClustersResponseBodyList : TeaModel {
            [NameInMap("AlsProjectName")]
            [Validation(Required=false)]
            public string AlsProjectName { get; set; }

            [NameInMap("ClusterProviderType")]
            [Validation(Required=false)]
            public string ClusterProviderType { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("EnableLogging")]
            [Validation(Required=false)]
            public bool? EnableLogging { get; set; }

            [NameInMap("EnableMesh")]
            [Validation(Required=false)]
            public bool? EnableMesh { get; set; }

            [NameInMap("EnableMetis")]
            [Validation(Required=false)]
            public bool? EnableMetis { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("InstallType")]
            [Validation(Required=false)]
            public string InstallType { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("PodCidr")]
            [Validation(Required=false)]
            public string PodCidr { get; set; }

            [NameInMap("ServiceCidr")]
            [Validation(Required=false)]
            public string ServiceCidr { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("CellInfos")]
            [Validation(Required=false)]
            public List<ListAKSClustersResponseBodyListCellInfos> CellInfos { get; set; }
            public class ListAKSClustersResponseBodyListCellInfos : TeaModel {
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("SecuredGroupInfos")]
            [Validation(Required=false)]
            public List<ListAKSClustersResponseBodyListSecuredGroupInfos> SecuredGroupInfos { get; set; }
            public class ListAKSClustersResponseBodyListSecuredGroupInfos : TeaModel {
                [NameInMap("IaasProviderId")]
                [Validation(Required=false)]
                public string IaasProviderId { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("SecuredGroupIdentity")]
                [Validation(Required=false)]
                public string SecuredGroupIdentity { get; set; }

                [NameInMap("SecuredZoneId")]
                [Validation(Required=false)]
                public string SecuredZoneId { get; set; }

                [NameInMap("UtcCreate")]
                [Validation(Required=false)]
                public string UtcCreate { get; set; }

                [NameInMap("UtcModified")]
                [Validation(Required=false)]
                public string UtcModified { get; set; }

            }

            [NameInMap("ZoneInfos")]
            [Validation(Required=false)]
            public List<ListAKSClustersResponseBodyListZoneInfos> ZoneInfos { get; set; }
            public class ListAKSClustersResponseBodyListZoneInfos : TeaModel {
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("NetworkInfo")]
            [Validation(Required=false)]
            public ListAKSClustersResponseBodyListNetworkInfo NetworkInfo { get; set; }
            public class ListAKSClustersResponseBodyListNetworkInfo : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }
                [NameInMap("Segment")]
                [Validation(Required=false)]
                public string Segment { get; set; }
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }
            };

        }

    }

}
