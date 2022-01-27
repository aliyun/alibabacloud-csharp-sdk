// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class GetRegisteredServicesRequest : TeaModel {
        [NameInMap("GuestClusters")]
        [Validation(Required=false)]
        public string GuestClusters { get; set; }

        [NameInMap("GuestLimits")]
        [Validation(Required=false)]
        public string GuestLimits { get; set; }

        [NameInMap("GuestMarkers")]
        [Validation(Required=false)]
        public string GuestMarkers { get; set; }

        [NameInMap("MeshLimit")]
        [Validation(Required=false)]
        public long? MeshLimit { get; set; }

        [NameInMap("MeshMarker")]
        [Validation(Required=false)]
        public string MeshMarker { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
