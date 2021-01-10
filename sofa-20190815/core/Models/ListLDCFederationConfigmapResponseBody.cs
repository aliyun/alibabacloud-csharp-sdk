// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListLDCFederationConfigmapResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Configmaps")]
        [Validation(Required=false)]
        public List<ListLDCFederationConfigmapResponseBodyConfigmaps> Configmaps { get; set; }
        public class ListLDCFederationConfigmapResponseBodyConfigmaps : TeaModel {
            [NameInMap("CreateTimeStamp")]
            [Validation(Required=false)]
            public string CreateTimeStamp { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Clusters")]
            [Validation(Required=false)]
            public List<string> Clusters { get; set; }

            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public List<ListLDCFederationConfigmapResponseBodyConfigmapsAnnotations> Annotations { get; set; }
            public class ListLDCFederationConfigmapResponseBodyConfigmapsAnnotations : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("CellStatus")]
            [Validation(Required=false)]
            public List<ListLDCFederationConfigmapResponseBodyConfigmapsCellStatus> CellStatus { get; set; }
            public class ListLDCFederationConfigmapResponseBodyConfigmapsCellStatus : TeaModel {
                [NameInMap("Cell")]
                [Validation(Required=false)]
                public string Cell { get; set; }

                [NameInMap("Cluster")]
                [Validation(Required=false)]
                public string Cluster { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListLDCFederationConfigmapResponseBodyConfigmapsData> Data { get; set; }
            public class ListLDCFederationConfigmapResponseBodyConfigmapsData : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<ListLDCFederationConfigmapResponseBodyConfigmapsLabels> Labels { get; set; }
            public class ListLDCFederationConfigmapResponseBodyConfigmapsLabels : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Overrides")]
            [Validation(Required=false)]
            public List<ListLDCFederationConfigmapResponseBodyConfigmapsOverrides> Overrides { get; set; }
            public class ListLDCFederationConfigmapResponseBodyConfigmapsOverrides : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("NameOverride")]
                [Validation(Required=false)]
                public string NameOverride { get; set; }

                [NameInMap("Data")]
                [Validation(Required=false)]
                public List<ListLDCFederationConfigmapResponseBodyConfigmapsOverridesData> Data { get; set; }
                public class ListLDCFederationConfigmapResponseBodyConfigmapsOverridesData : TeaModel {
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

}
