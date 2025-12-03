// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DFS20180620.Models
{
    public class CreateQosPolicyRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("FederationId")]
        [Validation(Required=false)]
        public string FederationId { get; set; }

        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        [NameInMap("FlowIds")]
        [Validation(Required=false)]
        public List<int?> FlowIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("InputRegionId")]
        [Validation(Required=false)]
        public string InputRegionId { get; set; }

        [NameInMap("MaxIOBandWidth")]
        [Validation(Required=false)]
        public long? MaxIOBandWidth { get; set; }

        [NameInMap("MaxIOps")]
        [Validation(Required=false)]
        public long? MaxIOps { get; set; }

        [NameInMap("MaxMetaQps")]
        [Validation(Required=false)]
        public long? MaxMetaQps { get; set; }

        [NameInMap("ReqTags")]
        [Validation(Required=false)]
        public List<string> ReqTags { get; set; }

        [NameInMap("ZoneIds")]
        [Validation(Required=false)]
        public List<string> ZoneIds { get; set; }

    }

}
