// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterScannerListRequest : TeaModel {
        /// <summary>
        /// <para>List of cluster IDs.</para>
        /// </summary>
        [NameInMap("ClusterIdList")]
        [Validation(Required=false)]
        public List<string> ClusterIdList { get; set; }

        /// <summary>
        /// <para>The language type for requests and responses.</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>List of scanner statuses. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>online</b>: Running</description></item>
        /// <item><description><b>offline</b>: Offline</description></item>
        /// <item><description><b>not_installed</b>: Not Installed</description></item>
        /// </list>
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<string> StatusList { get; set; }

    }

}
