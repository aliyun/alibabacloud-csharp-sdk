// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchGetEdgeInstanceDriverConfigsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("DriverConfigList")]
        [Validation(Required=false)]
        public List<BatchGetEdgeInstanceDriverConfigsResponseBodyDriverConfigList> DriverConfigList { get; set; }
        public class BatchGetEdgeInstanceDriverConfigsResponseBodyDriverConfigList : TeaModel {
            [NameInMap("DriverId")]
            [Validation(Required=false)]
            public string DriverId { get; set; }

            [NameInMap("ConfigList")]
            [Validation(Required=false)]
            public List<BatchGetEdgeInstanceDriverConfigsResponseBodyDriverConfigListConfigList> ConfigList { get; set; }
            public class BatchGetEdgeInstanceDriverConfigsResponseBodyDriverConfigListConfigList : TeaModel {
                [NameInMap("ConfigId")]
                [Validation(Required=false)]
                public string ConfigId { get; set; }

                [NameInMap("Format")]
                [Validation(Required=false)]
                public string Format { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

            }

        }

    }

}
