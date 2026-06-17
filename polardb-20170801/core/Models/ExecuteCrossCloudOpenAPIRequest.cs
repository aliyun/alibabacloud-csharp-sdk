// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ExecuteCrossCloudOpenAPIRequest : TeaModel {
        /// <summary>
        /// <para>The information required to call the cross-cloud OpenAPI.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Action&quot;:&quot;DescribeDBClusters&quot;}</para>
        /// </summary>
        [NameInMap("ProxyInfo")]
        [Validation(Required=false)]
        public string ProxyInfo { get; set; }

    }

}
