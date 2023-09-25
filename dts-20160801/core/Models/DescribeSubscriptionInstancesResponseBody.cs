// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20160801.Models
{
    public class DescribeSubscriptionInstancesResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("SubscriptionInstances")]
        [Validation(Required=false)]
        public DescribeSubscriptionInstancesResponseBodySubscriptionInstances SubscriptionInstances { get; set; }
        public class DescribeSubscriptionInstancesResponseBodySubscriptionInstances : TeaModel {
            [NameInMap("SubscriptionInstance")]
            [Validation(Required=false)]
            public List<DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstance> SubscriptionInstance { get; set; }
            public class DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstance : TeaModel {
                [NameInMap("BeginTimestamp")]
                [Validation(Required=false)]
                public string BeginTimestamp { get; set; }

                [NameInMap("ConsumptionCheckpoint")]
                [Validation(Required=false)]
                public string ConsumptionCheckpoint { get; set; }

                [NameInMap("ConsumptionClient")]
                [Validation(Required=false)]
                public string ConsumptionClient { get; set; }

                [NameInMap("EndTimestamp")]
                [Validation(Required=false)]
                public string EndTimestamp { get; set; }

                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                [NameInMap("SourceEndpoint")]
                [Validation(Required=false)]
                public DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSourceEndpoint SourceEndpoint { get; set; }
                public class DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSourceEndpoint : TeaModel {
                    [NameInMap("InstanceID")]
                    [Validation(Required=false)]
                    public string InstanceID { get; set; }

                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("SubscriptionDataType")]
                [Validation(Required=false)]
                public DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionDataType SubscriptionDataType { get; set; }
                public class DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionDataType : TeaModel {
                    [NameInMap("DDL")]
                    [Validation(Required=false)]
                    public bool? DDL { get; set; }

                    [NameInMap("DML")]
                    [Validation(Required=false)]
                    public bool? DML { get; set; }

                }

                [NameInMap("SubscriptionInstanceID")]
                [Validation(Required=false)]
                public string SubscriptionInstanceID { get; set; }

                [NameInMap("SubscriptionInstanceName")]
                [Validation(Required=false)]
                public string SubscriptionInstanceName { get; set; }

                [NameInMap("SubscriptionObject")]
                [Validation(Required=false)]
                public DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionObject SubscriptionObject { get; set; }
                public class DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionObject : TeaModel {
                    [NameInMap("SynchronousObject")]
                    [Validation(Required=false)]
                    public List<DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionObjectSynchronousObject> SynchronousObject { get; set; }
                    public class DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionObjectSynchronousObject : TeaModel {
                        [NameInMap("DatabaseName")]
                        [Validation(Required=false)]
                        public string DatabaseName { get; set; }

                        [NameInMap("TableList")]
                        [Validation(Required=false)]
                        public DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionObjectSynchronousObjectTableList TableList { get; set; }
                        public class DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionObjectSynchronousObjectTableList : TeaModel {
                            [NameInMap("Table")]
                            [Validation(Required=false)]
                            public List<string> Table { get; set; }

                        }

                        [NameInMap("WholeDatabase")]
                        [Validation(Required=false)]
                        public string WholeDatabase { get; set; }

                    }

                }

            }

        }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
