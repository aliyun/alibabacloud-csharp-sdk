// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListDataSourceTypesResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDataSourceTypesResponseBodyData> Data { get; set; }
        public class ListDataSourceTypesResponseBodyData : TeaModel {
            /// <summary>
            /// The code of the third-party cloud service.
            /// </summary>
            [NameInMap("CloudCode")]
            [Validation(Required=false)]
            public string CloudCode { get; set; }

            /// <summary>
            /// The type of the data source. Valid values:
            /// 
            /// *   obs: Huawei Cloud Object Storage Service (OBS)
            /// *   wafApi: download API of Tencent Cloud Web Application Firewall (WAF)
            /// *   ckafka: Tencent Cloud Kafka (CKafka)
            /// </summary>
            [NameInMap("DataSourceType")]
            [Validation(Required=false)]
            public string DataSourceType { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
