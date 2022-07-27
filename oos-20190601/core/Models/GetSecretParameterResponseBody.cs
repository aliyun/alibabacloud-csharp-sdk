// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetSecretParameterResponseBody : TeaModel {
        [NameInMap("Parameter")]
        [Validation(Required=false)]
        public GetSecretParameterResponseBodyParameter Parameter { get; set; }
        public class GetSecretParameterResponseBodyParameter : TeaModel {
            [NameInMap("Constraints")]
            [Validation(Required=false)]
            public string Constraints { get; set; }
            [NameInMap("CreatedBy")]
            [Validation(Required=false)]
            public string CreatedBy { get; set; }
            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }
            [NameInMap("ParameterVersion")]
            [Validation(Required=false)]
            public int? ParameterVersion { get; set; }
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }
            [NameInMap("ShareType")]
            [Validation(Required=false)]
            public string ShareType { get; set; }
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public Dictionary<string, string> Tags { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("UpdatedBy")]
            [Validation(Required=false)]
            public string UpdatedBy { get; set; }
            [NameInMap("UpdatedDate")]
            [Validation(Required=false)]
            public string UpdatedDate { get; set; }
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
