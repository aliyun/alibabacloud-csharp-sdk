// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ConfigureSubscriptionInstanceRequest : TeaModel {
        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public ConfigureSubscriptionInstanceRequestSourceEndpoint SourceEndpoint { get; set; }
        public class ConfigureSubscriptionInstanceRequestSourceEndpoint : TeaModel {
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }
            [NameInMap("InstanceID")]
            [Validation(Required=false)]
            public string InstanceID { get; set; }
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }
            [NameInMap("OracleSID")]
            [Validation(Required=false)]
            public string OracleSID { get; set; }
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }
            [NameInMap("OwnerID")]
            [Validation(Required=false)]
            public string OwnerID { get; set; }
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }
        };

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
        };

        [NameInMap("SubscriptionInstance")]
        [Validation(Required=false)]
        public ConfigureSubscriptionInstanceRequestSubscriptionInstance SubscriptionInstance { get; set; }
        public class ConfigureSubscriptionInstanceRequestSubscriptionInstance : TeaModel {
            [NameInMap("VPCId")]
            [Validation(Required=false)]
            public string VPCId { get; set; }
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }
        };

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SubscriptionInstanceId")]
        [Validation(Required=false)]
        public string SubscriptionInstanceId { get; set; }

        [NameInMap("SubscriptionInstanceName")]
        [Validation(Required=false)]
        public string SubscriptionInstanceName { get; set; }

        [NameInMap("SubscriptionObject")]
        [Validation(Required=false)]
        public string SubscriptionObject { get; set; }

        [NameInMap("SubscriptionInstanceNetworkType")]
        [Validation(Required=false)]
        public string SubscriptionInstanceNetworkType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

    }

}
