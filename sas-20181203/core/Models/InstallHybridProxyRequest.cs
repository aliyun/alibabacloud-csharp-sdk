// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class InstallHybridProxyRequest : TeaModel {
        /// <summary>
        /// <para>The cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>proxy-test</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The installation code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Z9c8SA</para>
        /// </summary>
        [NameInMap("InstallCode")]
        [Validation(Required=false)]
        public string InstallCode { get; set; }

        /// <summary>
        /// <para>The UUIDs of the proxy servers.</para>
        /// </summary>
        [NameInMap("YundunUuids")]
        [Validation(Required=false)]
        public List<string> YundunUuids { get; set; }

    }

}
