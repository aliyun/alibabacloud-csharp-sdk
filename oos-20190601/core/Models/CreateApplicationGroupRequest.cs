// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreateApplicationGroupRequest : TeaModel {
        [NameInMap("ApplicationName")]
        [Validation(Required=false)]
        public string ApplicationName { get; set; }

        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("CmsGroupId")]
        [Validation(Required=false)]
        public string CmsGroupId { get; set; }

        [NameInMap("DeployRegionId")]
        [Validation(Required=false)]
        public string DeployRegionId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ImportTagKey")]
        [Validation(Required=false)]
        public string ImportTagKey { get; set; }

        [NameInMap("ImportTagValue")]
        [Validation(Required=false)]
        public string ImportTagValue { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
