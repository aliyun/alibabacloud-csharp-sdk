// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateAKSSecretImagepullResponseBody : TeaModel {
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("Annotations")]
        [Validation(Required=false)]
        public List<CreateAKSSecretImagepullResponseBodyAnnotations> Annotations { get; set; }
        public class CreateAKSSecretImagepullResponseBodyAnnotations : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CreationTimeStamp")]
        [Validation(Required=false)]
        public string CreationTimeStamp { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<CreateAKSSecretImagepullResponseBodyData> Data { get; set; }
        public class CreateAKSSecretImagepullResponseBodyData : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<CreateAKSSecretImagepullResponseBodyLabels> Labels { get; set; }
        public class CreateAKSSecretImagepullResponseBodyLabels : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
