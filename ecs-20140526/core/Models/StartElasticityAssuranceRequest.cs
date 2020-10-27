// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class StartElasticityAssuranceRequest : TeaModel {
        [NameInMap("RegionId")]
        [Validation(Required=true)]
        public string RegionId { get; set; }

        [NameInMap("PrivatePoolOptions")]
        [Validation(Required=false)]
        public StartElasticityAssuranceRequestPrivatePoolOptions PrivatePoolOptions { get; set; }
        public class StartElasticityAssuranceRequestPrivatePoolOptions : TeaModel {
            [NameInMap("Id")]
            [Validation(Required=true)]
            public string Id { get; set; }
        };

    }

}
