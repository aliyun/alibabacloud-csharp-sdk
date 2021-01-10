// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLDCFederationNamespaceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateLDCFederationNamespaceResponseBodyData Data { get; set; }
        public class CreateLDCFederationNamespaceResponseBodyData : TeaModel {
            [NameInMap("CreateTimeStamp")]
            [Validation(Required=false)]
            public string CreateTimeStamp { get; set; }
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<CreateLDCFederationNamespaceResponseBodyDataLabels> Labels { get; set; }
            public class CreateLDCFederationNamespaceResponseBodyDataLabels : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public List<CreateLDCFederationNamespaceResponseBodyDataAnnotations> Annotations { get; set; }
            public class CreateLDCFederationNamespaceResponseBodyDataAnnotations : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("ClusterStateMap")]
            [Validation(Required=false)]
            public List<CreateLDCFederationNamespaceResponseBodyDataClusterStateMap> ClusterStateMap { get; set; }
            public class CreateLDCFederationNamespaceResponseBodyDataClusterStateMap : TeaModel {
                public string State { get; set; }
                public string ClusterName { get; set; }
            }
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }
            [NameInMap("Clusters")]
            [Validation(Required=false)]
            public List<string> Clusters { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
        };

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
