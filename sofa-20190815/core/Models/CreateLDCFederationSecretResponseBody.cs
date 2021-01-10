// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLDCFederationSecretResponseBody : TeaModel {
        [NameInMap("Secret")]
        [Validation(Required=false)]
        public CreateLDCFederationSecretResponseBodySecret Secret { get; set; }
        public class CreateLDCFederationSecretResponseBodySecret : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("CreateTimeStamp")]
            [Validation(Required=false)]
            public string CreateTimeStamp { get; set; }
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<CreateLDCFederationSecretResponseBodySecretData> Data { get; set; }
            public class CreateLDCFederationSecretResponseBodySecretData : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<CreateLDCFederationSecretResponseBodySecretLabels> Labels { get; set; }
            public class CreateLDCFederationSecretResponseBodySecretLabels : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public List<CreateLDCFederationSecretResponseBodySecretAnnotations> Annotations { get; set; }
            public class CreateLDCFederationSecretResponseBodySecretAnnotations : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }
            [NameInMap("Overrides")]
            [Validation(Required=false)]
            public List<CreateLDCFederationSecretResponseBodySecretOverrides> Overrides { get; set; }
            public class CreateLDCFederationSecretResponseBodySecretOverrides : TeaModel {
                public string NameOverride { get; set; }
                public List<CreateLDCFederationSecretResponseBodySecretOverridesData> Data { get; set; }
                public class CreateLDCFederationSecretResponseBodySecretOverridesData : TeaModel {
                    public string Key { get; set; }
                    public string Value { get; set; }
                }
                public string Name { get; set; }
            }
            [NameInMap("CellStatus")]
            [Validation(Required=false)]
            public List<CreateLDCFederationSecretResponseBodySecretCellStatus> CellStatus { get; set; }
            public class CreateLDCFederationSecretResponseBodySecretCellStatus : TeaModel {
                public string Status { get; set; }
                public string Cluster { get; set; }
                public string Cell { get; set; }
            }
            [NameInMap("Clusters")]
            [Validation(Required=false)]
            public List<string> Clusters { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

    }

}
