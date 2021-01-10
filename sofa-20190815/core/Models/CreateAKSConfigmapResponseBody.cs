// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CreateAKSConfigmapResponseBody : TeaModel {
        [NameInMap("Annotations")]
        [Validation(Required=false)]
        public List<CreateAKSConfigmapResponseBodyAnnotations> Annotations { get; set; }
        public class CreateAKSConfigmapResponseBodyAnnotations : TeaModel {
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
        public List<CreateAKSConfigmapResponseBodyData> Data { get; set; }
        public class CreateAKSConfigmapResponseBodyData : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<CreateAKSConfigmapResponseBodyLabels> Labels { get; set; }
        public class CreateAKSConfigmapResponseBodyLabels : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

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
