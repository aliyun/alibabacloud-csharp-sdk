// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListClusterInstalledServiceResponseBody : TeaModel {
        [NameInMap("ClusterInstalledServiceList")]
        [Validation(Required=false)]
        public ListClusterInstalledServiceResponseBodyClusterInstalledServiceList ClusterInstalledServiceList { get; set; }
        public class ListClusterInstalledServiceResponseBodyClusterInstalledServiceList : TeaModel {
            [NameInMap("ClusterInstalledService")]
            [Validation(Required=false)]
            public List<ListClusterInstalledServiceResponseBodyClusterInstalledServiceListClusterInstalledService> ClusterInstalledService { get; set; }
            public class ListClusterInstalledServiceResponseBodyClusterInstalledServiceListClusterInstalledService : TeaModel {
                [NameInMap("ServiceActionList")]
                [Validation(Required=false)]
                public ListClusterInstalledServiceResponseBodyClusterInstalledServiceListClusterInstalledServiceServiceActionList ServiceActionList { get; set; }
                public class ListClusterInstalledServiceResponseBodyClusterInstalledServiceListClusterInstalledServiceServiceActionList : TeaModel {
                    [NameInMap("ServiceAction")]
                    [Validation(Required=false)]
                    public List<ListClusterInstalledServiceResponseBodyClusterInstalledServiceListClusterInstalledServiceServiceActionListServiceAction> ServiceAction { get; set; }
                    public class ListClusterInstalledServiceResponseBodyClusterInstalledServiceListClusterInstalledServiceServiceActionListServiceAction : TeaModel {
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

                [NameInMap("ServiceEcmVersion")]
                [Validation(Required=false)]
                public string ServiceEcmVersion { get; set; }

                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                [NameInMap("ServiceVersion")]
                [Validation(Required=false)]
                public string ServiceVersion { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                [NameInMap("abnormalNum")]
                [Validation(Required=false)]
                public int? AbnormalNum { get; set; }

                [NameInMap("comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                [NameInMap("needRestartNum")]
                [Validation(Required=false)]
                public int? NeedRestartNum { get; set; }

                [NameInMap("notStartedNum")]
                [Validation(Required=false)]
                public int? NotStartedNum { get; set; }

                [NameInMap("onlyClient")]
                [Validation(Required=false)]
                public bool? OnlyClient { get; set; }

                [NameInMap("serviceStatus")]
                [Validation(Required=false)]
                public string ServiceStatus { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
