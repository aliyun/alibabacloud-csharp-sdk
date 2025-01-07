// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UnBindHybridProxyRequest : TeaModel {
        /// <summary>
        /// <para>The cluster name.</para>
        /// <remarks>
        /// <para>This parameter is deprecated.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>proxy-test</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The UUIDs of servers that you want to add to Security Center over the proxy server.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("YundunUuids")]
        [Validation(Required=false)]
        public List<string> YundunUuids { get; set; }

    }

}
