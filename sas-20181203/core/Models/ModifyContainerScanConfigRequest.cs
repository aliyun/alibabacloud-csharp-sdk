// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyContainerScanConfigRequest : TeaModel {
        /// <summary>
        /// <para>The name of the container application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;logtail-ds\&quot;,\&quot;alicloud-monitor-controller\&quot;,\&quot;storage-snapshot-manager\&quot;]</para>
        /// </summary>
        [NameInMap("AppNames")]
        [Validation(Required=false)]
        public string AppNames { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeGroupedContainerInstances~~">DescribeGroupedContainerInstances</a> operation to query the IDs of clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cfb7a55a81f7246b5ac18845ea79a****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
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

    }

}
