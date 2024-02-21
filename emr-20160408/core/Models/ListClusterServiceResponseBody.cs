// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListClusterServiceResponseBody : TeaModel {
        [NameInMap("ClusterServiceList")]
        [Validation(Required=false)]
        public ListClusterServiceResponseBodyClusterServiceList ClusterServiceList { get; set; }
        public class ListClusterServiceResponseBodyClusterServiceList : TeaModel {
            [NameInMap("ClusterService")]
            [Validation(Required=false)]
            public List<ListClusterServiceResponseBodyClusterServiceListClusterService> ClusterService { get; set; }
            public class ListClusterServiceResponseBodyClusterServiceListClusterService : TeaModel {
                [NameInMap("AbnormalNum")]
                [Validation(Required=false)]
                public int? AbnormalNum { get; set; }

                [NameInMap("ClientType")]
                [Validation(Required=false)]
                public bool? ClientType { get; set; }

                [NameInMap("HealthStatus")]
                [Validation(Required=false)]
                public string HealthStatus { get; set; }

                [NameInMap("InstallStatus")]
                [Validation(Required=false)]
                public bool? InstallStatus { get; set; }

                [NameInMap("NeedRestartInfo")]
                [Validation(Required=false)]
                public string NeedRestartInfo { get; set; }

                [NameInMap("NeedRestartNum")]
                [Validation(Required=false)]
                public int? NeedRestartNum { get; set; }

                [NameInMap("NotStartInfo")]
                [Validation(Required=false)]
                public string NotStartInfo { get; set; }

                [NameInMap("ServiceActionList")]
                [Validation(Required=false)]
                public ListClusterServiceResponseBodyClusterServiceListClusterServiceServiceActionList ServiceActionList { get; set; }
                public class ListClusterServiceResponseBodyClusterServiceListClusterServiceServiceActionList : TeaModel {
                    [NameInMap("ServiceAction")]
                    [Validation(Required=false)]
                    public List<ListClusterServiceResponseBodyClusterServiceListClusterServiceServiceActionListServiceAction> ServiceAction { get; set; }
                    public class ListClusterServiceResponseBodyClusterServiceListClusterServiceServiceActionListServiceAction : TeaModel {
                        [NameInMap("ActionName")]
                        [Validation(Required=false)]
                        public string ActionName { get; set; }

                        [NameInMap("Command")]
                        [Validation(Required=false)]
                        public string Command { get; set; }

                        [NameInMap("ComponentName")]
                        [Validation(Required=false)]
                        public string ComponentName { get; set; }

                        [NameInMap("DisplayName")]
                        [Validation(Required=false)]
                        public string DisplayName { get; set; }

                        [NameInMap("ServiceName")]
                        [Validation(Required=false)]
                        public string ServiceName { get; set; }

                    }

                }

                [NameInMap("ServiceDisplayName")]
                [Validation(Required=false)]
                public string ServiceDisplayName { get; set; }

                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                [NameInMap("ServiceStatus")]
                [Validation(Required=false)]
                public string ServiceStatus { get; set; }

                [NameInMap("ServiceVersion")]
                [Validation(Required=false)]
                public string ServiceVersion { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("StoppedNum")]
                [Validation(Required=false)]
                public int? StoppedNum { get; set; }

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
