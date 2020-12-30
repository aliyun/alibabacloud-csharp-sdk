// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDrdsParamsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeDrdsParamsResponseBodyList> List { get; set; }
        public class DescribeDrdsParamsResponseBodyList : TeaModel {
            [NameInMap("ParamDefaultValue")]
            [Validation(Required=false)]
            public string ParamDefaultValue { get; set; }

            [NameInMap("ParamLevel")]
            [Validation(Required=false)]
            public string ParamLevel { get; set; }

            [NameInMap("ParamName")]
            [Validation(Required=false)]
            public string ParamName { get; set; }

            [NameInMap("ParamType")]
            [Validation(Required=false)]
            public string ParamType { get; set; }

            [NameInMap("ParamValue")]
            [Validation(Required=false)]
            public string ParamValue { get; set; }

            [NameInMap("NeedRestart")]
            [Validation(Required=false)]
            public bool? NeedRestart { get; set; }

            [NameInMap("ParamRanges")]
            [Validation(Required=false)]
            public string ParamRanges { get; set; }

            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }

            [NameInMap("ParamEnglishName")]
            [Validation(Required=false)]
            public string ParamEnglishName { get; set; }

            [NameInMap("ParamDesc")]
            [Validation(Required=false)]
            public string ParamDesc { get; set; }

            [NameInMap("ParamVariableName")]
            [Validation(Required=false)]
            public string ParamVariableName { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
