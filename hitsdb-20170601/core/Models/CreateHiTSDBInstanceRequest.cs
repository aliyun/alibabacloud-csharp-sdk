/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20170601.Models
{
    public class CreateHiTSDBInstanceRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public string AppKey { get; set; }

        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("InstanceAlias")]
        [Validation(Required=false)]
        public string InstanceAlias { get; set; }

        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        [NameInMap("InstanceStorage")]
        [Validation(Required=false)]
        public string InstanceStorage { get; set; }

        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        [NameInMap("MaxTimelineLimit")]
        [Validation(Required=false)]
        public string MaxTimelineLimit { get; set; }

        [NameInMap("InstanceTps")]
        [Validation(Required=false)]
        public string InstanceTps { get; set; }

        [NameInMap("EngineType")]
        [Validation(Required=false)]
        public string EngineType { get; set; }

        [NameInMap("MaxSeriesPerDatabase")]
        [Validation(Required=false)]
        public string MaxSeriesPerDatabase { get; set; }

        [NameInMap("MaxDatabaseLimit")]
        [Validation(Required=false)]
        public string MaxDatabaseLimit { get; set; }

        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        [NameInMap("TSDBVersion")]
        [Validation(Required=false)]
        public string TSDBVersion { get; set; }

        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
