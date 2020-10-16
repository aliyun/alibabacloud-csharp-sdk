// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class AddDataSourceResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public AddDataSourceResponseData Data { get; set; }
        public class AddDataSourceResponseData : TeaModel {
            [NameInMap("DataSourceId")]
            [Validation(Required=true)]
            public string DataSourceId { get; set; }
            [NameInMap("KafkaTopic")]
            [Validation(Required=true)]
            public string KafkaTopic { get; set; }
            [NameInMap("OssPath")]
            [Validation(Required=true)]
            public string OssPath { get; set; }
        };

    }

}
