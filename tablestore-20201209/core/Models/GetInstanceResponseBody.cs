// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tablestore20201209.Models
{
    public class GetInstanceResponseBody : TeaModel {
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("InstanceDescription")]
        [Validation(Required=false)]
        public string InstanceDescription { get; set; }

        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        [NameInMap("InstanceSpecification")]
        [Validation(Required=false)]
        public string InstanceSpecification { get; set; }

        [NameInMap("InstanceStatus")]
        [Validation(Required=false)]
        public string InstanceStatus { get; set; }

        [NameInMap("Network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        [NameInMap("NetworkSourceACL")]
        [Validation(Required=false)]
        public List<string> NetworkSourceACL { get; set; }

        [NameInMap("NetworkTypeACL")]
        [Validation(Required=false)]
        public List<string> NetworkTypeACL { get; set; }

        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string Policy { get; set; }

        [NameInMap("PolicyVersion")]
        [Validation(Required=false)]
        public long? PolicyVersion { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("SPInstanceId")]
        [Validation(Required=false)]
        public string SPInstanceId { get; set; }

        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        [NameInMap("TableQuota")]
        [Validation(Required=false)]
        public int? TableQuota { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetInstanceResponseBodyTags> Tags { get; set; }
        public class GetInstanceResponseBodyTags : TeaModel {
            [NameInMap("TagKey")]
            [Validation(Required=false)]
            public string TagKey { get; set; }

            [NameInMap("TagValue")]
            [Validation(Required=false)]
            public string TagValue { get; set; }

        }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("VCUQuota")]
        [Validation(Required=false)]
        public int? VCUQuota { get; set; }

    }

}
