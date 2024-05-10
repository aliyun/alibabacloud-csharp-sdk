// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class BindHybridProxyRequest : TeaModel {
        /// <summary>
        /// The name of the proxy cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// The UUIDs of servers that you want to add to Security Center over the proxy server.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("YundunUuids")]
        [Validation(Required=false)]
        public List<string> YundunUuids { get; set; }

    }

}
