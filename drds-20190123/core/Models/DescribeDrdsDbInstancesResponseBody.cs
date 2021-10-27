// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsDbInstancesResponseBody : TeaModel {
        [NameInMap("DbInstances")]
        [Validation(Required=false)]
        public DescribeDrdsDbInstancesResponseBodyDbInstances DbInstances { get; set; }
        public class DescribeDrdsDbInstancesResponseBodyDbInstances : TeaModel {
            [NameInMap("DbInstance")]
            [Validation(Required=false)]
            public List<DescribeDrdsDbInstancesResponseBodyDbInstancesDbInstance> DbInstance { get; set; }
            public class DescribeDrdsDbInstancesResponseBodyDbInstancesDbInstance : TeaModel {
                public string ConnectUrl { get; set; }
                public string DBInstanceId { get; set; }
                public string DBInstanceStatus { get; set; }
                public string DbInstType { get; set; }
                public string DmInstanceId { get; set; }
                public string Engine { get; set; }
                public string EngineVersion { get; set; }
                public string ExpireTime { get; set; }
                public string NetworkType { get; set; }
                public string PayType { get; set; }
                public int? Port { get; set; }
                public string RdsInstType { get; set; }
                public DescribeDrdsDbInstancesResponseBodyDbInstancesDbInstanceReadOnlyInstances ReadOnlyInstances { get; set; }
                public class DescribeDrdsDbInstancesResponseBodyDbInstancesDbInstanceReadOnlyInstances : TeaModel {
                    [NameInMap("ReadOnlyInstance")]
                    [Validation(Required=false)]
                    public List<DescribeDrdsDbInstancesResponseBodyDbInstancesDbInstanceReadOnlyInstancesReadOnlyInstance> ReadOnlyInstance { get; set; }
                    public class DescribeDrdsDbInstancesResponseBodyDbInstancesDbInstanceReadOnlyInstancesReadOnlyInstance : TeaModel {
                        [NameInMap("ConnectUrl")]
                        [Validation(Required=false)]
                        public string ConnectUrl { get; set; }

                        [NameInMap("DBInstanceStatus")]
                        [Validation(Required=false)]
                        public string DBInstanceStatus { get; set; }

                        [NameInMap("DbInstType")]
                        [Validation(Required=false)]
                        public string DbInstType { get; set; }

                        [NameInMap("DmInstanceId")]
                        [Validation(Required=false)]
                        public string DmInstanceId { get; set; }

                        [NameInMap("Engine")]
                        [Validation(Required=false)]
                        public string Engine { get; set; }

                        [NameInMap("EngineVersion")]
                        [Validation(Required=false)]
                        public string EngineVersion { get; set; }

                        [NameInMap("ExpireTime")]
                        [Validation(Required=false)]
                        public string ExpireTime { get; set; }

                        [NameInMap("InstanceName")]
                        [Validation(Required=false)]
                        public string InstanceName { get; set; }

                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        [NameInMap("PayType")]
                        [Validation(Required=false)]
                        public string PayType { get; set; }

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        [NameInMap("RdsInstType")]
                        [Validation(Required=false)]
                        public string RdsInstType { get; set; }

                        [NameInMap("ReadWeight")]
                        [Validation(Required=false)]
                        public int? ReadWeight { get; set; }

                        [NameInMap("RemainDays")]
                        [Validation(Required=false)]
                        public int? RemainDays { get; set; }

                    }

                }
                public int? ReadWeight { get; set; }
                public int? RemainDays { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public string Total { get; set; }

    }

}
