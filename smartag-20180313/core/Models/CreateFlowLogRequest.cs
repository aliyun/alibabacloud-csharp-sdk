// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class CreateFlowLogRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ActiveAging")]
        [Validation(Required=false)]
        public int? ActiveAging { get; set; }

        [NameInMap("InactiveAging")]
        [Validation(Required=false)]
        public int? InactiveAging { get; set; }

        [NameInMap("OutputType")]
        [Validation(Required=false)]
        public string OutputType { get; set; }

        [NameInMap("SlsRegionId")]
        [Validation(Required=false)]
        public string SlsRegionId { get; set; }

        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("LogstoreName")]
        [Validation(Required=false)]
        public string LogstoreName { get; set; }

        [NameInMap("NetflowServerIp")]
        [Validation(Required=false)]
        public string NetflowServerIp { get; set; }

        [NameInMap("NetflowServerPort")]
        [Validation(Required=false)]
        public int? NetflowServerPort { get; set; }

        [NameInMap("NetflowVersion")]
        [Validation(Required=false)]
        public string NetflowVersion { get; set; }

    }

}
