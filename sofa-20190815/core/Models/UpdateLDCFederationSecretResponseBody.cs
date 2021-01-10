// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLDCFederationSecretResponseBody : TeaModel {
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
        public UpdateLDCFederationSecretResponseBodySecret Secret { get; set; }
        public class UpdateLDCFederationSecretResponseBodySecret : TeaModel {
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
            public List<UpdateLDCFederationSecretResponseBodySecretAnnotations> Annotations { get; set; }
            public class UpdateLDCFederationSecretResponseBodySecretAnnotations : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("CellStatus")]
            [Validation(Required=false)]
            public List<UpdateLDCFederationSecretResponseBodySecretCellStatus> CellStatus { get; set; }
            public class UpdateLDCFederationSecretResponseBodySecretCellStatus : TeaModel {
                public string Cell { get; set; }
                public string Cluster { get; set; }
                public string Status { get; set; }
            }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<UpdateLDCFederationSecretResponseBodySecretData> Data { get; set; }
            public class UpdateLDCFederationSecretResponseBodySecretData : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<UpdateLDCFederationSecretResponseBodySecretLabels> Labels { get; set; }
            public class UpdateLDCFederationSecretResponseBodySecretLabels : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("Overrides")]
            [Validation(Required=false)]
            public List<UpdateLDCFederationSecretResponseBodySecretOverrides> Overrides { get; set; }
            public class UpdateLDCFederationSecretResponseBodySecretOverrides : TeaModel {
                public string Name { get; set; }
                public string NameOverride { get; set; }
                public List<UpdateLDCFederationSecretResponseBodySecretOverridesData> Data { get; set; }
                public class UpdateLDCFederationSecretResponseBodySecretOverridesData : TeaModel {
                    public string Key { get; set; }
                    public string Value { get; set; }
                }
            }
        };

    }

}
