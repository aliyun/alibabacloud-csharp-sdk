// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateLDCFederationImagepullsecretResponseBody : TeaModel {
        [NameInMap("Secret")]
        [Validation(Required=false)]
        public CreateLDCFederationImagepullsecretResponseBodySecret Secret { get; set; }
        public class CreateLDCFederationImagepullsecretResponseBodySecret : TeaModel {
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
            public List<CreateLDCFederationImagepullsecretResponseBodySecretData> Data { get; set; }
            public class CreateLDCFederationImagepullsecretResponseBodySecretData : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<CreateLDCFederationImagepullsecretResponseBodySecretLabels> Labels { get; set; }
            public class CreateLDCFederationImagepullsecretResponseBodySecretLabels : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("Annotations")]
            [Validation(Required=false)]
            public List<CreateLDCFederationImagepullsecretResponseBodySecretAnnotations> Annotations { get; set; }
            public class CreateLDCFederationImagepullsecretResponseBodySecretAnnotations : TeaModel {
                public string Key { get; set; }
                public string Value { get; set; }
            }
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }
            [NameInMap("Overrides")]
            [Validation(Required=false)]
            public List<CreateLDCFederationImagepullsecretResponseBodySecretOverrides> Overrides { get; set; }
            public class CreateLDCFederationImagepullsecretResponseBodySecretOverrides : TeaModel {
                public string NameOverride { get; set; }
                public List<CreateLDCFederationImagepullsecretResponseBodySecretOverridesData> Data { get; set; }
                public class CreateLDCFederationImagepullsecretResponseBodySecretOverridesData : TeaModel {
                    public string Key { get; set; }
                    public string Value { get; set; }
                }
                public string Name { get; set; }
            }
            [NameInMap("CellStatus")]
            [Validation(Required=false)]
            public List<CreateLDCFederationImagepullsecretResponseBodySecretCellStatus> CellStatus { get; set; }
            public class CreateLDCFederationImagepullsecretResponseBodySecretCellStatus : TeaModel {
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
