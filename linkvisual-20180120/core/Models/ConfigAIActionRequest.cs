// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class ConfigAIActionRequest : TeaModel {
        [NameInMap("ApiProduct")]
        [Validation(Required=false)]
        public string ApiProduct { get; set; }

        [NameInMap("ApiRevision")]
        [Validation(Required=false)]
        public string ApiRevision { get; set; }

        [NameInMap("ActionId")]
        [Validation(Required=false)]
        public string ActionId { get; set; }

        [NameInMap("DataTypeConfigList")]
        [Validation(Required=false)]
        public List<ConfigAIActionRequestDataTypeConfigList> DataTypeConfigList { get; set; }
        public class ConfigAIActionRequestDataTypeConfigList : TeaModel {
            [NameInMap("Configs")]
            [Validation(Required=false)]
            public string Configs { get; set; }

            [NameInMap("DataType")]
            [Validation(Required=false)]
            public string DataType { get; set; }

        }

        [NameInMap("AlgoConfig")]
        [Validation(Required=false)]
        public string AlgoConfig { get; set; }

    }

}
