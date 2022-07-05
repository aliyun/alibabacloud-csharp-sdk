// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class OssExternalStore : TeaModel {
        /// <summary>
        /// 名称
        /// </summary>
        [NameInMap("externalStoreName")]
        [Validation(Required=false)]
        public string ExternalStoreName { get; set; }

        /// <summary>
        /// 参数
        /// </summary>
        [NameInMap("parameter")]
        [Validation(Required=false)]
        public OssExternalStoreParameter Parameter { get; set; }
        public class OssExternalStoreParameter : TeaModel {
            [NameInMap("accessKey")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }
            [NameInMap("accessid")]
            [Validation(Required=false)]
            public string Accessid { get; set; }
            [NameInMap("bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }
        };

        /// <summary>
        /// 类型。这里固定为 oss
        /// </summary>
        [NameInMap("storeType")]
        [Validation(Required=false)]
        public string StoreType { get; set; }

    }

}
