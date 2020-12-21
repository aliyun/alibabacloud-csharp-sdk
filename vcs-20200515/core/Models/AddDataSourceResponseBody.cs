// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class AddDataSourceResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public AddDataSourceResponseBodyData Data { get; set; }
        public class AddDataSourceResponseBodyData : TeaModel {
            [NameInMap("KafkaTopic")]
            [Validation(Required=false)]
            public string KafkaTopic { get; set; }
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }
            [NameInMap("OssPath")]
            [Validation(Required=false)]
            public string OssPath { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
