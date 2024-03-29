// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20160801.Models
{
    public class DescribeSubscriptionInstanceStatusResponseBody : TeaModel {
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
        public DescribeSubscriptionInstanceStatusResponseBodySourceEndpoint SourceEndpoint { get; set; }
        public class DescribeSubscriptionInstanceStatusResponseBodySourceEndpoint : TeaModel {
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
        public DescribeSubscriptionInstanceStatusResponseBodySubscriptionDataType SubscriptionDataType { get; set; }
        public class DescribeSubscriptionInstanceStatusResponseBodySubscriptionDataType : TeaModel {
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
        public DescribeSubscriptionInstanceStatusResponseBodySubscriptionObject SubscriptionObject { get; set; }
        public class DescribeSubscriptionInstanceStatusResponseBodySubscriptionObject : TeaModel {
            [NameInMap("SynchronousObject")]
            [Validation(Required=false)]
            public List<DescribeSubscriptionInstanceStatusResponseBodySubscriptionObjectSynchronousObject> SynchronousObject { get; set; }
            public class DescribeSubscriptionInstanceStatusResponseBodySubscriptionObjectSynchronousObject : TeaModel {
                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                [NameInMap("TableList")]
                [Validation(Required=false)]
                public DescribeSubscriptionInstanceStatusResponseBodySubscriptionObjectSynchronousObjectTableList TableList { get; set; }
                public class DescribeSubscriptionInstanceStatusResponseBodySubscriptionObjectSynchronousObjectTableList : TeaModel {
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
