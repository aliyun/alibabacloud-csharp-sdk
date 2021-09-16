// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSubscriptionInstancesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("SubscriptionInstances")]
        [Validation(Required=false)]
        public DescribeSubscriptionInstancesResponseBodySubscriptionInstances SubscriptionInstances { get; set; }
        public class DescribeSubscriptionInstancesResponseBodySubscriptionInstances : TeaModel {
            [NameInMap("SubscriptionInstance")]
            [Validation(Required=false)]
            public List<DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstance> SubscriptionInstance { get; set; }
            public class DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstance : TeaModel {
                public string Status { get; set; }
                public string ErrorMessage { get; set; }
                public string PayType { get; set; }
                public string ConsumptionClient { get; set; }
                public string ConsumptionCheckpoint { get; set; }
                public string EndTimestamp { get; set; }
                public string InstanceCreateTime { get; set; }
                public string BeginTimestamp { get; set; }
                public string SubscribeTopic { get; set; }
                public string SubscriptionInstanceName { get; set; }
                public string SubscriptionInstanceID { get; set; }
                public string JobCreateTime { get; set; }
                public DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionObject SubscriptionObject { get; set; }
                public class DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionObject : TeaModel {
                    [NameInMap("SynchronousObject")]
                    [Validation(Required=false)]
                    public List<DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionObjectSynchronousObject> SynchronousObject { get; set; }
                    public class DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionObjectSynchronousObject : TeaModel {
                        [NameInMap("DatabaseName")]
                        [Validation(Required=false)]
                        public string DatabaseName { get; set; }

                        [NameInMap("WholeDatabase")]
                        [Validation(Required=false)]
                        public string WholeDatabase { get; set; }

                        [NameInMap("TableList")]
                        [Validation(Required=false)]
                        public DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionObjectSynchronousObjectTableList TableList { get; set; }
                        public class DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionObjectSynchronousObjectTableList : TeaModel {
                            [NameInMap("Table")]
                            [Validation(Required=false)]
                            public List<string> Table { get; set; }
                        };

                    }

                }
                public DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceTags Tags { get; set; }
                public class DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceTagsTag> Tag { get; set; }
                    public class DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSourceEndpoint SourceEndpoint { get; set; }
                public class DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSourceEndpoint : TeaModel {
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    [NameInMap("InstanceID")]
                    [Validation(Required=false)]
                    public string InstanceID { get; set; }

                }
                public DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionDataType SubscriptionDataType { get; set; }
                public class DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionDataType : TeaModel {
                    [NameInMap("DML")]
                    [Validation(Required=false)]
                    public bool? DML { get; set; }

                    [NameInMap("DDL")]
                    [Validation(Required=false)]
                    public bool? DDL { get; set; }

                }
                public DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionHost SubscriptionHost { get; set; }
                public class DescribeSubscriptionInstancesResponseBodySubscriptionInstancesSubscriptionInstanceSubscriptionHost : TeaModel {
                    [NameInMap("VPCHost")]
                    [Validation(Required=false)]
                    public string VPCHost { get; set; }

                    [NameInMap("PublicHost")]
                    [Validation(Required=false)]
                    public string PublicHost { get; set; }

                    [NameInMap("PrivateHost")]
                    [Validation(Required=false)]
                    public string PrivateHost { get; set; }

                }
            }
        };

    }

}
