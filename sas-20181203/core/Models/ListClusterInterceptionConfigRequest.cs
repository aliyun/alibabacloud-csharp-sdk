// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListClusterInterceptionConfigRequest : TeaModel {
        /// <summary>
        /// <para>The status of the container firewall feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>-1</b>: unknown</description></item>
        /// <item><description><b>0</b>: abnormal</description></item>
        /// <item><description><b>1</b>: normal</description></item>
        /// <item><description><b>2</b>: normal to be confirmed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ClusterCNNFStatus")]
        [Validation(Required=false)]
        public int? ClusterCNNFStatus { get; set; }

        /// <summary>
        /// <para>The ID of the cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeContainerInstances~~">DescribeContainerInstances</a> operation to query the IDs of clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>c22143730ab6e40b09ec7c1c51d4d****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The name of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
