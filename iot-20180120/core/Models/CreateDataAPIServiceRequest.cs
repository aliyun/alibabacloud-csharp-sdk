// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class CreateDataAPIServiceRequest : TeaModel {
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        [NameInMap("OriginSql")]
        [Validation(Required=false)]
        public string OriginSql { get; set; }

        [NameInMap("RequestParam")]
        [Validation(Required=false)]
        public List<CreateDataAPIServiceRequestRequestParam> RequestParam { get; set; }
        public class CreateDataAPIServiceRequestRequestParam : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("Example")]
            [Validation(Required=false)]
            public string Example { get; set; }

            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

        }

        [NameInMap("Desc")]
        [Validation(Required=false)]
        public string Desc { get; set; }

        [NameInMap("ResponseParam")]
        [Validation(Required=false)]
        public List<CreateDataAPIServiceRequestResponseParam> ResponseParam { get; set; }
        public class CreateDataAPIServiceRequestResponseParam : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            [NameInMap("Example")]
            [Validation(Required=false)]
            public string Example { get; set; }

            [NameInMap("Required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

        }

        [NameInMap("TemplateSql")]
        [Validation(Required=false)]
        public string TemplateSql { get; set; }

        [NameInMap("ApiPath")]
        [Validation(Required=false)]
        public string ApiPath { get; set; }

        [NameInMap("IotInstanceId")]
        [Validation(Required=false)]
        public string IotInstanceId { get; set; }

    }

}
