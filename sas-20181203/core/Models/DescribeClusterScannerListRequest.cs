// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterScannerListRequest : TeaModel {
        /// <summary>
        /// <para>The list of cluster IDs.</para>
        /// </summary>
        [NameInMap("ClusterIdList")]
        [Validation(Required=false)]
        public List<string> ClusterIdList { get; set; }

        /// <summary>
        /// <para>The language type for the request and response messages.</para>
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
        /// <para>The list of scanner statuses. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>online</b>: running</description></item>
        /// <item><description><b>offline</b>: offline</description></item>
        /// <item><description><b>not_installed</b>: not installed</description></item>
        /// </list>
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<string> StatusList { get; set; }

    }

}
