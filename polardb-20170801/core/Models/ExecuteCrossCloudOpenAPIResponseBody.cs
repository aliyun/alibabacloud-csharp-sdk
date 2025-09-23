// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ExecuteCrossCloudOpenAPIResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;ProxyData&quot;: &quot;{\&quot;DBCluster\&quot;:[{\&quot;AliyunRegionId\&quot;:\&quot;cn-beijing\&quot;,\&quot;CloudProvider\&quot;:\&quot;huawei\&quot;,\&quot;CreateTime\&quot;:\&quot;2024-11-25T14:49:10Z\&quot;,\&quot;CrossCloudRegionId\&quot;:\&quot;cn-east-3\&quot;,\&quot;DBClusterDescription\&quot;:\&quot;\&quot;,\&quot;DBClusterId\&quot;:\&quot;pc-2zej3qvf5fg******\&quot;,\&quot;DBClusterStatus\&quot;:\&quot;Creating\&quot;,\&quot;DBType\&quot;:\&quot;polardb_mysql\&quot;,\&quot;DBVersion\&quot;:\&quot;8.0\&quot;,\&quot;ProjectId\&quot;:\&quot;pj-bp1m8oh1k68******\&quot;},{\&quot;AliyunRegionId\&quot;:\&quot;cn-beijing\&quot;,\&quot;CloudProvider\&quot;:\&quot;huawei\&quot;,\&quot;CreateTime\&quot;:\&quot;2024-11-25T14:59:10Z\&quot;,\&quot;CrossCloudRegionId\&quot;:\&quot;cn-east-3\&quot;,\&quot;DBClusterDescription\&quot;:\&quot;\&quot;,\&quot;DBClusterId\&quot;:\&quot;pc-2ze29994l17******\&quot;,\&quot;DBClusterStatus\&quot;:\&quot;Running\&quot;,\&quot;DBType\&quot;:\&quot;polardb_mysql\&quot;,\&quot;DBVersion\&quot;:\&quot;8.0\&quot;,\&quot;ProjectId\&quot;:\&quot;pj-bp1m8oh1k68******\&quot;}]}&quot;,&quot;RequestId&quot;: &quot;E56531A4-E552-40BA-9C58-137B80******&quot;}</para>
        /// </summary>
        [NameInMap("ProxyData")]
        [Validation(Required=false)]
        public string ProxyData { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E56531A4-E552-40BA-9C58-137B80******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
