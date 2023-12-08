// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DdosDiversion20230701.Models
{
    public class ListInstanceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListInstanceResponseBodyData> Data { get; set; }
        public class ListInstanceResponseBodyData : TeaModel {
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<ListInstanceResponseBodyDataInstances> Instances { get; set; }
            public class ListInstanceResponseBodyDataInstances : TeaModel {
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("GmtExpire")]
                [Validation(Required=false)]
                public string GmtExpire { get; set; }

                [NameInMap("GmtModify")]
                [Validation(Required=false)]
                public string GmtModify { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("SaleId")]
                [Validation(Required=false)]
                public string SaleId { get; set; }

                [NameInMap("Spec")]
                [Validation(Required=false)]
                public ListInstanceResponseBodyDataInstancesSpec Spec { get; set; }
                public class ListInstanceResponseBodyDataInstancesSpec : TeaModel {
                    [NameInMap("Coverage")]
                    [Validation(Required=false)]
                    public string Coverage { get; set; }

                    [NameInMap("DiversionType")]
                    [Validation(Required=false)]
                    public string DiversionType { get; set; }

                    [NameInMap("Edition")]
                    [Validation(Required=false)]
                    public string Edition { get; set; }

                    [NameInMap("IdcNumbers")]
                    [Validation(Required=false)]
                    public string IdcNumbers { get; set; }

                    [NameInMap("InitialInstallation")]
                    [Validation(Required=false)]
                    public string InitialInstallation { get; set; }

                    [NameInMap("InitialQty")]
                    [Validation(Required=false)]
                    public string InitialQty { get; set; }

                    [NameInMap("IpSubnetNums")]
                    [Validation(Required=false)]
                    public string IpSubnetNums { get; set; }

                    [NameInMap("MitigationAnalysis")]
                    [Validation(Required=false)]
                    public string MitigationAnalysis { get; set; }

                    [NameInMap("MitigationAnalysisCapacity")]
                    [Validation(Required=false)]
                    public string MitigationAnalysisCapacity { get; set; }

                    [NameInMap("MitigationCapacity")]
                    [Validation(Required=false)]
                    public string MitigationCapacity { get; set; }

                    [NameInMap("MitigationNums")]
                    [Validation(Required=false)]
                    public string MitigationNums { get; set; }

                    [NameInMap("NormalBandwidth")]
                    [Validation(Required=false)]
                    public string NormalBandwidth { get; set; }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("Num")]
            [Validation(Required=false)]
            public long? Num { get; set; }

            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
