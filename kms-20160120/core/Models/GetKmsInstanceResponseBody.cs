// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetKmsInstanceResponseBody : TeaModel {
        [NameInMap("KmsInstance")]
        [Validation(Required=false)]
        public GetKmsInstanceResponseBodyKmsInstance KmsInstance { get; set; }
        public class GetKmsInstanceResponseBodyKmsInstance : TeaModel {
            [NameInMap("BindVpcs")]
            [Validation(Required=false)]
            public GetKmsInstanceResponseBodyKmsInstanceBindVpcs BindVpcs { get; set; }
            public class GetKmsInstanceResponseBodyKmsInstanceBindVpcs : TeaModel {
                [NameInMap("BindVpc")]
                [Validation(Required=false)]
                public List<GetKmsInstanceResponseBodyKmsInstanceBindVpcsBindVpc> BindVpc { get; set; }
                public class GetKmsInstanceResponseBodyKmsInstanceBindVpcsBindVpc : TeaModel {
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    [NameInMap("VpcId")]
                    [Validation(Required=false)]
                    public string VpcId { get; set; }

                    [NameInMap("VpcOwnerId")]
                    [Validation(Required=false)]
                    public string VpcOwnerId { get; set; }

                }

            }

            [NameInMap("CaCertificateChainPem")]
            [Validation(Required=false)]
            public string CaCertificateChainPem { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public string EndDate { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("KeyNum")]
            [Validation(Required=false)]
            public long? KeyNum { get; set; }

            [NameInMap("SecretNum")]
            [Validation(Required=false)]
            public string SecretNum { get; set; }

            [NameInMap("Spec")]
            [Validation(Required=false)]
            public long? Spec { get; set; }

            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("VpcNum")]
            [Validation(Required=false)]
            public long? VpcNum { get; set; }

            [NameInMap("VswitchIds")]
            [Validation(Required=false)]
            public string VswitchIds { get; set; }

            [NameInMap("ZoneIds")]
            [Validation(Required=false)]
            public string ZoneIds { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
