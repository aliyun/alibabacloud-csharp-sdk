// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListLDCFederationNamespaceResponseBody : TeaModel {
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
        public List<ListLDCFederationNamespaceResponseBodyData> Data { get; set; }
        public class ListLDCFederationNamespaceResponseBodyData : TeaModel {
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
            public List<ListLDCFederationNamespaceResponseBodyDataAnnotations> Annotations { get; set; }
            public class ListLDCFederationNamespaceResponseBodyDataAnnotations : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("ClusterStateMap")]
            [Validation(Required=false)]
            public List<ListLDCFederationNamespaceResponseBodyDataClusterStateMap> ClusterStateMap { get; set; }
            public class ListLDCFederationNamespaceResponseBodyDataClusterStateMap : TeaModel {
                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

            }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<ListLDCFederationNamespaceResponseBodyDataLabels> Labels { get; set; }
            public class ListLDCFederationNamespaceResponseBodyDataLabels : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
