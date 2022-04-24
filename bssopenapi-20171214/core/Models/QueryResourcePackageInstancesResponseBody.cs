// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryResourcePackageInstancesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryResourcePackageInstancesResponseBodyData Data { get; set; }
        public class QueryResourcePackageInstancesResponseBodyData : TeaModel {
            [NameInMap("HostId")]
            [Validation(Required=false)]
            public string HostId { get; set; }
            [NameInMap("Instances")]
            [Validation(Required=false)]
            public QueryResourcePackageInstancesResponseBodyDataInstances Instances { get; set; }
            public class QueryResourcePackageInstancesResponseBodyDataInstances : TeaModel {
                [NameInMap("Instance")]
                [Validation(Required=false)]
                public List<QueryResourcePackageInstancesResponseBodyDataInstancesInstance> Instance { get; set; }
                public class QueryResourcePackageInstancesResponseBodyDataInstancesInstance : TeaModel {
                    [NameInMap("ApplicableProducts")]
                    [Validation(Required=false)]
                    public QueryResourcePackageInstancesResponseBodyDataInstancesInstanceApplicableProducts ApplicableProducts { get; set; }
                    public class QueryResourcePackageInstancesResponseBodyDataInstancesInstanceApplicableProducts : TeaModel {
                        [NameInMap("Product")]
                        [Validation(Required=false)]
                        public List<string> Product { get; set; }
                    };

                    [NameInMap("DeductType")]
                    [Validation(Required=false)]
                    public string DeductType { get; set; }

                    [NameInMap("EffectiveTime")]
                    [Validation(Required=false)]
                    public string EffectiveTime { get; set; }

                    [NameInMap("ExpiryTime")]
                    [Validation(Required=false)]
                    public string ExpiryTime { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("PackageType")]
                    [Validation(Required=false)]
                    public string PackageType { get; set; }

                    [NameInMap("Region")]
                    [Validation(Required=false)]
                    public string Region { get; set; }

                    [NameInMap("RemainingAmount")]
                    [Validation(Required=false)]
                    public string RemainingAmount { get; set; }

                    [NameInMap("RemainingAmountUnit")]
                    [Validation(Required=false)]
                    public string RemainingAmountUnit { get; set; }

                    [NameInMap("Remark")]
                    [Validation(Required=false)]
                    public string Remark { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    [NameInMap("TotalAmount")]
                    [Validation(Required=false)]
                    public string TotalAmount { get; set; }

                    [NameInMap("TotalAmountUnit")]
                    [Validation(Required=false)]
                    public string TotalAmountUnit { get; set; }

                }

            }
            [NameInMap("PageNum")]
            [Validation(Required=false)]
            public string PageNum { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
