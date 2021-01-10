// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateProductRequest : TeaModel {
        [NameInMap("ApiProduct")]
        [Validation(Required=false)]
        public string ApiProduct { get; set; }

        [NameInMap("ApiRevision")]
        [Validation(Required=false)]
        public string ApiRevision { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

        [NameInMap("ProductName")]
        [Validation(Required=false)]
        public string ProductName { get; set; }

        [NameInMap("NodeType")]
        [Validation(Required=false)]
        public int? NodeType { get; set; }

        [NameInMap("DataFormat")]
        [Validation(Required=false)]
        public int? DataFormat { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("AliyunCommodityCode")]
        [Validation(Required=false)]
        public string AliyunCommodityCode { get; set; }

        [NameInMap("Id2")]
        [Validation(Required=false)]
        public bool? Id2 { get; set; }

        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public long? CategoryId { get; set; }

        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        [NameInMap("NetType")]
        [Validation(Required=false)]
        public string NetType { get; set; }

        [NameInMap("JoinPermissionId")]
        [Validation(Required=false)]
        public string JoinPermissionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("AuthType")]
        [Validation(Required=false)]
        public string AuthType { get; set; }

        [NameInMap("CategoryKey")]
        [Validation(Required=false)]
        public string CategoryKey { get; set; }

        [NameInMap("PublishAuto")]
        [Validation(Required=false)]
        public bool? PublishAuto { get; set; }

        [NameInMap("ValidateType")]
        [Validation(Required=false)]
        public int? ValidateType { get; set; }

        [NameInMap("RealTenantId")]
        [Validation(Required=false)]
        public string RealTenantId { get; set; }

        [NameInMap("RealTripartiteKey")]
        [Validation(Required=false)]
        public string RealTripartiteKey { get; set; }

    }

}
