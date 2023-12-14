// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeDataSourceParametersResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeDataSourceParametersResponseBodyData> Data { get; set; }
        public class DescribeDataSourceParametersResponseBodyData : TeaModel {
            [NameInMap("CanEditted")]
            [Validation(Required=false)]
            public int? CanEditted { get; set; }

            [NameInMap("CloudCode")]
            [Validation(Required=false)]
            public string CloudCode { get; set; }

            [NameInMap("DataSourceType")]
            [Validation(Required=false)]
            public string DataSourceType { get; set; }

            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            [NameInMap("FormatCheck")]
            [Validation(Required=false)]
            public string FormatCheck { get; set; }

            [NameInMap("Hit")]
            [Validation(Required=false)]
            public string Hit { get; set; }

            [NameInMap("ParaCode")]
            [Validation(Required=false)]
            public string ParaCode { get; set; }

            [NameInMap("ParaLevel")]
            [Validation(Required=false)]
            public int? ParaLevel { get; set; }

            [NameInMap("ParaName")]
            [Validation(Required=false)]
            public string ParaName { get; set; }

            [NameInMap("ParaType")]
            [Validation(Required=false)]
            public string ParaType { get; set; }

            [NameInMap("ParamValue")]
            [Validation(Required=false)]
            public List<DescribeDataSourceParametersResponseBodyDataParamValue> ParamValue { get; set; }
            public class DescribeDataSourceParametersResponseBodyDataParamValue : TeaModel {
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Required")]
            [Validation(Required=false)]
            public int? Required { get; set; }

            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
