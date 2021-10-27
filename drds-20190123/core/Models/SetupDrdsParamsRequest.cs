// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class SetupDrdsParamsRequest : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<SetupDrdsParamsRequestData> Data { get; set; }
        public class SetupDrdsParamsRequestData : TeaModel {
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            [NameInMap("ParamRanges")]
            [Validation(Required=false)]
            public string ParamRanges { get; set; }

            [NameInMap("ParamType")]
            [Validation(Required=false)]
            public string ParamType { get; set; }

            [NameInMap("ParamValue")]
            [Validation(Required=false)]
            public string ParamValue { get; set; }

            [NameInMap("ParamVariableName")]
            [Validation(Required=false)]
            public string ParamVariableName { get; set; }

        }

        [NameInMap("DrdsInstanceId")]
        [Validation(Required=false)]
        public string DrdsInstanceId { get; set; }

        [NameInMap("ParamLevel")]
        [Validation(Required=false)]
        public string ParamLevel { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
