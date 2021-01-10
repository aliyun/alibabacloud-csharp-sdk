// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLDCFederationSecretResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Secret")]
        [Validation(Required=false)]
        public GetLDCFederationSecretResponseBodySecret Secret { get; set; }
        public class GetLDCFederationSecretResponseBodySecret : TeaModel {
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
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("Clusters")]
            [Validation(Required=false)]
            public List<string> Clusters { get; set; }
            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public List<GetLDCFederationSecretResponseBodySecretAnnotations> Annotations { get; set; }
            public class GetLDCFederationSecretResponseBodySecretAnnotations : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("CellStatus")]
            [Validation(Required=false)]
            public List<GetLDCFederationSecretResponseBodySecretCellStatus> CellStatus { get; set; }
            public class GetLDCFederationSecretResponseBodySecretCellStatus : TeaModel {
                public string Cell { get; set; }
                public string Cluster { get; set; }
                public string Status { get; set; }
            }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<GetLDCFederationSecretResponseBodySecretData> Data { get; set; }
            public class GetLDCFederationSecretResponseBodySecretData : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<GetLDCFederationSecretResponseBodySecretLabels> Labels { get; set; }
            public class GetLDCFederationSecretResponseBodySecretLabels : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("Overrides")]
            [Validation(Required=false)]
            public List<GetLDCFederationSecretResponseBodySecretOverrides> Overrides { get; set; }
            public class GetLDCFederationSecretResponseBodySecretOverrides : TeaModel {
                public string Name { get; set; }
                public string NameOverride { get; set; }
                public List<GetLDCFederationSecretResponseBodySecretOverridesData> Data { get; set; }
                public class GetLDCFederationSecretResponseBodySecretOverridesData : TeaModel {
                    public string Key { get; set; }
                    public string Value { get; set; }
                }
            }
        };

    }

}
