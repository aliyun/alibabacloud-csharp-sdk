// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20171016.Models
{
    public class DescribeRdsListResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeRdsListResponseBodyData Data { get; set; }
        public class DescribeRdsListResponseBodyData : TeaModel {
            [NameInMap("RdsInstance")]
            [Validation(Required=false)]
            public List<DescribeRdsListResponseBodyDataRdsInstance> RdsInstance { get; set; }
            public class DescribeRdsListResponseBodyDataRdsInstance : TeaModel {
                public string ConnectUrl { get; set; }
                public string DbType { get; set; }
                public int? InstanceId { get; set; }
                public string InstanceName { get; set; }
                public string InstanceStatus { get; set; }
                public int? Port { get; set; }
                public DescribeRdsListResponseBodyDataRdsInstanceReadOnlyChildren ReadOnlyChildren { get; set; }
                public class DescribeRdsListResponseBodyDataRdsInstanceReadOnlyChildren : TeaModel {
                    [NameInMap("Child")]
                    [Validation(Required=false)]
                    public List<DescribeRdsListResponseBodyDataRdsInstanceReadOnlyChildrenChild> Child { get; set; }
                    public class DescribeRdsListResponseBodyDataRdsInstanceReadOnlyChildrenChild : TeaModel {
                        [NameInMap("ConnectUrl")]
                        [Validation(Required=false)]
                        public string ConnectUrl { get; set; }

                        [NameInMap("DbType")]
                        [Validation(Required=false)]
                        public string DbType { get; set; }

                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        [NameInMap("InstanceName")]
                        [Validation(Required=false)]
                        public string InstanceName { get; set; }

                        [NameInMap("InstanceStatus")]
                        [Validation(Required=false)]
                        public string InstanceStatus { get; set; }

                        [NameInMap("ReadWeight")]
                        [Validation(Required=false)]
                        public int? ReadWeight { get; set; }

                        [NameInMap("port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                    }

                }
                public int? ReadWeight { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
