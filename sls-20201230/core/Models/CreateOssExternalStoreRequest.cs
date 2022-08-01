// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateOssExternalStoreRequest : TeaModel {
        [NameInMap("externalStoreName")]
        [Validation(Required=false)]
        public string ExternalStoreName { get; set; }

        [NameInMap("parameter")]
        [Validation(Required=false)]
        public CreateOssExternalStoreRequestParameter Parameter { get; set; }
        public class CreateOssExternalStoreRequestParameter : TeaModel {
            [NameInMap("accessid")]
            [Validation(Required=false)]
            public string Accessid { get; set; }
            [NameInMap("accesskey")]
            [Validation(Required=false)]
            public string Accesskey { get; set; }
            [NameInMap("bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }
            [NameInMap("columns")]
            [Validation(Required=false)]
            public List<CreateOssExternalStoreRequestParameterColumns> Columns { get; set; }
            public class CreateOssExternalStoreRequestParameterColumns : TeaModel {
                public string Name { get; set; }
                public string Type { get; set; }
            }
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }
            [NameInMap("objects")]
            [Validation(Required=false)]
            public List<string> Objects { get; set; }
        };

        [NameInMap("storeType")]
        [Validation(Required=false)]
        public string StoreType { get; set; }

    }

}
