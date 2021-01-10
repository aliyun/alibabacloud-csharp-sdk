// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLDCFederationConfigmapResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Configmap")]
        [Validation(Required=false)]
        public CreateLDCFederationConfigmapResponseBodyConfigmap Configmap { get; set; }
        public class CreateLDCFederationConfigmapResponseBodyConfigmap : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("CreateTimeStamp")]
            [Validation(Required=false)]
            public string CreateTimeStamp { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<CreateLDCFederationConfigmapResponseBodyConfigmapData> Data { get; set; }
            public class CreateLDCFederationConfigmapResponseBodyConfigmapData : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<CreateLDCFederationConfigmapResponseBodyConfigmapLabels> Labels { get; set; }
            public class CreateLDCFederationConfigmapResponseBodyConfigmapLabels : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("CellStatus")]
            [Validation(Required=false)]
            public List<CreateLDCFederationConfigmapResponseBodyConfigmapCellStatus> CellStatus { get; set; }
            public class CreateLDCFederationConfigmapResponseBodyConfigmapCellStatus : TeaModel {
                public string Status { get; set; }
                public string Cluster { get; set; }
                public string Cell { get; set; }
            }
            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public List<CreateLDCFederationConfigmapResponseBodyConfigmapAnnotations> Annotations { get; set; }
            public class CreateLDCFederationConfigmapResponseBodyConfigmapAnnotations : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
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
            [NameInMap("Overrides")]
            [Validation(Required=false)]
            public List<CreateLDCFederationConfigmapResponseBodyConfigmapOverrides> Overrides { get; set; }
            public class CreateLDCFederationConfigmapResponseBodyConfigmapOverrides : TeaModel {
                public string NameOverride { get; set; }
                public List<CreateLDCFederationConfigmapResponseBodyConfigmapOverridesData> Data { get; set; }
                public class CreateLDCFederationConfigmapResponseBodyConfigmapOverridesData : TeaModel {
                    public string Key { get; set; }
                    public string Value { get; set; }
                }
                public string Name { get; set; }
            }
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }
        };

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
