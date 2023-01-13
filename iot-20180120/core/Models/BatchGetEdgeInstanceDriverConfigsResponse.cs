// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class BatchGetEdgeInstanceDriverConfigsResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("DriverConfigList")]
        [Validation(Required=true)]
        public List<BatchGetEdgeInstanceDriverConfigsResponseDriverConfigList> DriverConfigList { get; set; }
        public class BatchGetEdgeInstanceDriverConfigsResponseDriverConfigList : TeaModel {
            [NameInMap("DriverId")]
            [Validation(Required=true)]
            public string DriverId { get; set; }

            [NameInMap("ConfigList")]
            [Validation(Required=true)]
            public List<BatchGetEdgeInstanceDriverConfigsResponseDriverConfigListConfigList> ConfigList { get; set; }
            public class BatchGetEdgeInstanceDriverConfigsResponseDriverConfigListConfigList : TeaModel {
                [NameInMap("ConfigId")]
                [Validation(Required=true)]
                public string ConfigId { get; set; }

                [NameInMap("Content")]
                [Validation(Required=true)]
                public string Content { get; set; }

                [NameInMap("Format")]
                [Validation(Required=true)]
                public string Format { get; set; }

                [NameInMap("Key")]
                [Validation(Required=true)]
                public string Key { get; set; }

            }

        }

    }

}
