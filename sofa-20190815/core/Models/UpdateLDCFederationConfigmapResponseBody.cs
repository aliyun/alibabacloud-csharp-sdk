// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLDCFederationConfigmapResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Configmap")]
        [Validation(Required=false)]
        public UpdateLDCFederationConfigmapResponseBodyConfigmap Configmap { get; set; }
        public class UpdateLDCFederationConfigmapResponseBodyConfigmap : TeaModel {
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
            public List<UpdateLDCFederationConfigmapResponseBodyConfigmapAnnotations> Annotations { get; set; }
            public class UpdateLDCFederationConfigmapResponseBodyConfigmapAnnotations : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("CellStatus")]
            [Validation(Required=false)]
            public List<UpdateLDCFederationConfigmapResponseBodyConfigmapCellStatus> CellStatus { get; set; }
            public class UpdateLDCFederationConfigmapResponseBodyConfigmapCellStatus : TeaModel {
                public string Cell { get; set; }
                public string Cluster { get; set; }
                public string Status { get; set; }
            }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<UpdateLDCFederationConfigmapResponseBodyConfigmapData> Data { get; set; }
            public class UpdateLDCFederationConfigmapResponseBodyConfigmapData : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<UpdateLDCFederationConfigmapResponseBodyConfigmapLabels> Labels { get; set; }
            public class UpdateLDCFederationConfigmapResponseBodyConfigmapLabels : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("Overrides")]
            [Validation(Required=false)]
            public List<UpdateLDCFederationConfigmapResponseBodyConfigmapOverrides> Overrides { get; set; }
            public class UpdateLDCFederationConfigmapResponseBodyConfigmapOverrides : TeaModel {
                public string Name { get; set; }
                public string NameOverride { get; set; }
                public List<UpdateLDCFederationConfigmapResponseBodyConfigmapOverridesData> Data { get; set; }
                public class UpdateLDCFederationConfigmapResponseBodyConfigmapOverridesData : TeaModel {
                    public string Key { get; set; }
                    public string Value { get; set; }
                }
            }
        };

    }

}
