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
        /// <para>You must specify at least one of StatusList and ClusterIdList. If neither is specified, the API returns HTTP 400 with the error code InvalidParam.</para>
        /// <para>Before calling this operation, make sure that an ACK cluster exists. You can obtain the cluster ID by calling the <a href="https://api.aliyun.com/document/CS/2015-12-15/DescribeClusters">DescribeClusters</a> operation of Container Service.</para>
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
        /// <item><description><b>online</b>: Running.</description></item>
        /// <item><description><b>offline</b>: Offline.</description></item>
        /// <item><description><b>not_installed</b>: Not installed.</description></item>
        /// </list>
        /// <para>You must specify at least one of StatusList and ClusterIdList. If neither is specified, the API returns HTTP 400 with the error code InvalidParam.</para>
        /// </summary>
        [NameInMap("StatusList")]
        [Validation(Required=false)]
        public List<string> StatusList { get; set; }

    }

}
