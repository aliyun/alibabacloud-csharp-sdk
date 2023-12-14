// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeDataSourceInstanceResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDataSourceInstanceResponseBodyData Data { get; set; }
        public class DescribeDataSourceInstanceResponseBodyData : TeaModel {
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("CloudCode")]
            [Validation(Required=false)]
            public string CloudCode { get; set; }

            [NameInMap("DataSourceInstanceId")]
            [Validation(Required=false)]
            public string DataSourceInstanceId { get; set; }

            [NameInMap("DataSourceInstanceParams")]
            [Validation(Required=false)]
            public List<DescribeDataSourceInstanceResponseBodyDataDataSourceInstanceParams> DataSourceInstanceParams { get; set; }
            public class DescribeDataSourceInstanceResponseBodyDataDataSourceInstanceParams : TeaModel {
                [NameInMap("ParaCode")]
                [Validation(Required=false)]
                public string ParaCode { get; set; }

                [NameInMap("ParaValue")]
                [Validation(Required=false)]
                public string ParaValue { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
