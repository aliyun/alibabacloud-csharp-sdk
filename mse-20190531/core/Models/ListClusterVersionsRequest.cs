// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListClusterVersionsRequest : TeaModel {
        /// <summary>
        /// <para>The language of the returned information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese.</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The cluster type. Valid values: ZooKeeper, Nacos-Ans, and Eureka.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Nacos-Ans</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>mse_dev</c>: Developer Edition.</description></item>
        /// <item><description><c>mse_pro</c>: Professional Edition (default).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mse_pro</para>
        /// </summary>
        [NameInMap("MseVersion")]
        [Validation(Required=false)]
        public string MseVersion { get; set; }

    }

}
