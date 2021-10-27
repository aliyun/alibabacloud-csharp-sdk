// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsDbInstanceResponseBody : TeaModel {
        [NameInMap("DbInstance")]
        [Validation(Required=false)]
        public DescribeDrdsDbInstanceResponseBodyDbInstance DbInstance { get; set; }
        public class DescribeDrdsDbInstanceResponseBodyDbInstance : TeaModel {
            [NameInMap("ConnectUrl")]
            [Validation(Required=false)]
            public string ConnectUrl { get; set; }
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }
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
            [NameInMap("ReadOnlyInstances")]
            [Validation(Required=false)]
            public DescribeDrdsDbInstanceResponseBodyDbInstanceReadOnlyInstances ReadOnlyInstances { get; set; }
            public class DescribeDrdsDbInstanceResponseBodyDbInstanceReadOnlyInstances : TeaModel {
                [NameInMap("ReadOnlyInstance")]
                [Validation(Required=false)]
                public List<DescribeDrdsDbInstanceResponseBodyDbInstanceReadOnlyInstancesReadOnlyInstance> ReadOnlyInstance { get; set; }
                public class DescribeDrdsDbInstanceResponseBodyDbInstanceReadOnlyInstancesReadOnlyInstance : TeaModel {
                    [NameInMap("ConnectUrl")]
                    [Validation(Required=false)]
                    public string ConnectUrl { get; set; }

                    [NameInMap("DBInstanceId")]
                    [Validation(Required=false)]
                    public string DBInstanceId { get; set; }

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
                    public string RemainDays { get; set; }

                    [NameInMap("VersionAction")]
                    [Validation(Required=false)]
                    public int? VersionAction { get; set; }

                }

            }
            [NameInMap("ReadWeight")]
            [Validation(Required=false)]
            public int? ReadWeight { get; set; }
            [NameInMap("RemainDays")]
            [Validation(Required=false)]
            public string RemainDays { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
