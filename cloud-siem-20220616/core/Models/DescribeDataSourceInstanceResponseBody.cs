// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeDataSourceInstanceResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDataSourceInstanceResponseBodyData Data { get; set; }
        public class DescribeDataSourceInstanceResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the cloud account.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// The code of the cloud service provider. Valid values:
            /// 
            /// *   qcloud: Tencent Cloud
            /// *   aliyun: Alibaba Cloud
            /// *   hcloud: Huawei Cloud
            /// </summary>
            [NameInMap("CloudCode")]
            [Validation(Required=false)]
            public string CloudCode { get; set; }

            /// <summary>
            /// The ID of the data source. The ID is an MD5 hash value that is calculated by the threat analysis feature based on specific parameters.
            /// </summary>
            [NameInMap("DataSourceInstanceId")]
            [Validation(Required=false)]
            public string DataSourceInstanceId { get; set; }

            /// <summary>
            /// The parameters of the data source.
            /// </summary>
            [NameInMap("DataSourceInstanceParams")]
            [Validation(Required=false)]
            public List<DescribeDataSourceInstanceResponseBodyDataDataSourceInstanceParams> DataSourceInstanceParams { get; set; }
            public class DescribeDataSourceInstanceResponseBodyDataDataSourceInstanceParams : TeaModel {
                /// <summary>
                /// The code of the parameter.
                /// </summary>
                [NameInMap("ParaCode")]
                [Validation(Required=false)]
                public string ParaCode { get; set; }

                /// <summary>
                /// The value of the parameter.
                /// </summary>
                [NameInMap("ParaValue")]
                [Validation(Required=false)]
                public string ParaValue { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
