// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLDCFederationNamespaceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateLDCFederationNamespaceResponseBodyData Data { get; set; }
        public class UpdateLDCFederationNamespaceResponseBodyData : TeaModel {
            [NameInMap("CreateTimeStamp")]
            [Validation(Required=false)]
            public string CreateTimeStamp { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }
            [NameInMap("Clusters")]
            [Validation(Required=false)]
            public List<string> Clusters { get; set; }
            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public List<UpdateLDCFederationNamespaceResponseBodyDataAnnotations> Annotations { get; set; }
            public class UpdateLDCFederationNamespaceResponseBodyDataAnnotations : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("ClusterStateMap")]
            [Validation(Required=false)]
            public List<UpdateLDCFederationNamespaceResponseBodyDataClusterStateMap> ClusterStateMap { get; set; }
            public class UpdateLDCFederationNamespaceResponseBodyDataClusterStateMap : TeaModel {
                public string ClusterName { get; set; }
                public string State { get; set; }
            }
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<UpdateLDCFederationNamespaceResponseBodyDataLabels> Labels { get; set; }
            public class UpdateLDCFederationNamespaceResponseBodyDataLabels : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
        };

    }

}
