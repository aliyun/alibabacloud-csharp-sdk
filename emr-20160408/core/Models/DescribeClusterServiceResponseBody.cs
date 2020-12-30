// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class DescribeClusterServiceResponseBody : TeaModel {
        [NameInMap("ServiceInfo")]
        [Validation(Required=false)]
        public DescribeClusterServiceResponseBodyServiceInfo ServiceInfo { get; set; }
        public class DescribeClusterServiceResponseBodyServiceInfo : TeaModel {
            [NameInMap("NeedRestartInfo")]
            [Validation(Required=false)]
            public string NeedRestartInfo { get; set; }
            [NameInMap("NeedRestartHostIdList")]
            [Validation(Required=false)]
            public DescribeClusterServiceResponseBodyServiceInfoNeedRestartHostIdList NeedRestartHostIdList { get; set; }
            public class DescribeClusterServiceResponseBodyServiceInfoNeedRestartHostIdList : TeaModel {
                [NameInMap("Service")]
                [Validation(Required=false)]
                public List<string> Service { get; set; }

            }
            [NameInMap("ClusterServiceSummaryList")]
            [Validation(Required=false)]
            public DescribeClusterServiceResponseBodyServiceInfoClusterServiceSummaryList ClusterServiceSummaryList { get; set; }
            public class DescribeClusterServiceResponseBodyServiceInfoClusterServiceSummaryList : TeaModel {
                [NameInMap("ClusterServiceSummary")]
                [Validation(Required=false)]
                public List<DescribeClusterServiceResponseBodyServiceInfoClusterServiceSummaryListClusterServiceSummary> ClusterServiceSummary { get; set; }
                public class DescribeClusterServiceResponseBodyServiceInfoClusterServiceSummaryListClusterServiceSummary : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                    [NameInMap("DesiredStoppedValue")]
                    [Validation(Required=false)]
                    public int? DesiredStoppedValue { get; set; }

                    [NameInMap("AlertInfo")]
                    [Validation(Required=false)]
                    public string AlertInfo { get; set; }

                    [NameInMap("Category")]
                    [Validation(Required=false)]
                    public string Category { get; set; }

                }

            }
            [NameInMap("ServiceActionList")]
            [Validation(Required=false)]
            public DescribeClusterServiceResponseBodyServiceInfoServiceActionList ServiceActionList { get; set; }
            public class DescribeClusterServiceResponseBodyServiceInfoServiceActionList : TeaModel {
                [NameInMap("ServiceAction")]
                [Validation(Required=false)]
                public List<DescribeClusterServiceResponseBodyServiceInfoServiceActionListServiceAction> ServiceAction { get; set; }
                public class DescribeClusterServiceResponseBodyServiceInfoServiceActionListServiceAction : TeaModel {
                    [NameInMap("DisplayName")]
                    [Validation(Required=false)]
                    public string DisplayName { get; set; }

                    [NameInMap("ComponentName")]
                    [Validation(Required=false)]
                    public string ComponentName { get; set; }

                    [NameInMap("Command")]
                    [Validation(Required=false)]
                    public string Command { get; set; }

                    [NameInMap("ActionName")]
                    [Validation(Required=false)]
                    public string ActionName { get; set; }

                    [NameInMap("ServiceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                }

            }
            [NameInMap("NeedRestartNum")]
            [Validation(Required=false)]
            public int? NeedRestartNum { get; set; }
            [NameInMap("NeedRestartComponentNameList")]
            [Validation(Required=false)]
            public DescribeClusterServiceResponseBodyServiceInfoNeedRestartComponentNameList NeedRestartComponentNameList { get; set; }
            public class DescribeClusterServiceResponseBodyServiceInfoNeedRestartComponentNameList : TeaModel {
                [NameInMap("Service")]
                [Validation(Required=false)]
                public List<string> Service { get; set; }

            }
            [NameInMap("ServiceVersion")]
            [Validation(Required=false)]
            public string ServiceVersion { get; set; }
            [NameInMap("ServiceStatus")]
            [Validation(Required=false)]
            public string ServiceStatus { get; set; }
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
