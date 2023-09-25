// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20160801.Models
{
    public class ConfigureSubscriptionInstanceRequest : TeaModel {
        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public ConfigureSubscriptionInstanceRequestSourceEndpoint SourceEndpoint { get; set; }
        public class ConfigureSubscriptionInstanceRequestSourceEndpoint : TeaModel {
            [NameInMap("InstanceID")]
            [Validation(Required=false)]
            public string InstanceID { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("OwnerID")]
            [Validation(Required=false)]
            public string OwnerID { get; set; }

            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        [NameInMap("SubscriptionDataType")]
        [Validation(Required=false)]
        public ConfigureSubscriptionInstanceRequestSubscriptionDataType SubscriptionDataType { get; set; }
        public class ConfigureSubscriptionInstanceRequestSubscriptionDataType : TeaModel {
            [NameInMap("DDL")]
            [Validation(Required=false)]
            public bool? DDL { get; set; }

            [NameInMap("DML")]
            [Validation(Required=false)]
            public bool? DML { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("SubscriptionInstanceId")]
        [Validation(Required=false)]
        public string SubscriptionInstanceId { get; set; }

        [NameInMap("SubscriptionInstanceName")]
        [Validation(Required=false)]
        public string SubscriptionInstanceName { get; set; }

        [NameInMap("SubscriptionObject")]
        [Validation(Required=false)]
        public string SubscriptionObject { get; set; }

    }

}
