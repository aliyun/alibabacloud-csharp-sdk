// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class ListClustersRequest : TeaModel {
        [NameInMap("ClusterTypeList")]
        [Validation(Required=false)]
        public List<string> ClusterTypeList { get; set; }

        [NameInMap("CreateType")]
        [Validation(Required=false)]
        public string CreateType { get; set; }

        [NameInMap("DefaultStatus")]
        [Validation(Required=false)]
        public bool? DefaultStatus { get; set; }

        [NameInMap("DepositType")]
        [Validation(Required=false)]
        public string DepositType { get; set; }

        [NameInMap("ExpiredTagList")]
        [Validation(Required=false)]
        public List<string> ExpiredTagList { get; set; }

        [NameInMap("IsDesc")]
        [Validation(Required=false)]
        public bool? IsDesc { get; set; }

        [NameInMap("MachineType")]
        [Validation(Required=false)]
        public string MachineType { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<string> StatusList { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListClustersRequestTag> Tag { get; set; }
        public class ListClustersRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
