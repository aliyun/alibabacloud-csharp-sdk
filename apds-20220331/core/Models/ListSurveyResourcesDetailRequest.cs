// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Apds20220331.Models
{
    public class ListSurveyResourcesDetailRequest : TeaModel {
        [NameInMap("ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        [NameInMap("jobId")]
        [Validation(Required=false)]
        public long? JobId { get; set; }

        [NameInMap("projectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("subProjectId")]
        [Validation(Required=false)]
        public long? SubProjectId { get; set; }

        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
