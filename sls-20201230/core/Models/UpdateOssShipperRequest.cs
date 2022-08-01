// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateOssShipperRequest : TeaModel {
        [NameInMap("shipperName")]
        [Validation(Required=false)]
        public string ShipperName { get; set; }

        [NameInMap("targetConfiguration")]
        [Validation(Required=false)]
        public UpdateOssShipperRequestTargetConfiguration TargetConfiguration { get; set; }
        public class UpdateOssShipperRequestTargetConfiguration : TeaModel {
            [NameInMap("bufferInterval")]
            [Validation(Required=false)]
            public int? BufferInterval { get; set; }
            [NameInMap("bufferSize")]
            [Validation(Required=false)]
            public int? BufferSize { get; set; }
            [NameInMap("compressType")]
            [Validation(Required=false)]
            public string CompressType { get; set; }
            [NameInMap("enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }
            [NameInMap("ossBucket")]
            [Validation(Required=false)]
            public string OssBucket { get; set; }
            [NameInMap("ossPrefix")]
            [Validation(Required=false)]
            public string OssPrefix { get; set; }
            [NameInMap("pathFormat")]
            [Validation(Required=false)]
            public string PathFormat { get; set; }
            [NameInMap("roleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }
            [NameInMap("storage")]
            [Validation(Required=false)]
            public UpdateOssShipperRequestTargetConfigurationStorage Storage { get; set; }
            public class UpdateOssShipperRequestTargetConfigurationStorage : TeaModel {
                [NameInMap("detail")]
                [Validation(Required=false)]
                public Dictionary<string, object> Detail { get; set; }

                [NameInMap("format")]
                [Validation(Required=false)]
                public string Format { get; set; }

            }
            [NameInMap("timeZone")]
            [Validation(Required=false)]
            public string TimeZone { get; set; }
        };

        [NameInMap("targetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

    }

}
