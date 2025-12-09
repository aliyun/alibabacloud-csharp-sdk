// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GenerateClusterScannerWebhookYamlRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the container cluster.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeGroupedContainerInstances~~">DescribeGroupedContainerInstances</a> API to obtain this parameter from the ClusterId field.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c3aaf6c8085f84791882eef200cd2****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Indicates whether the incremental scan switch is enabled. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Not enabled</description></item>
        /// <item><description><b>1</b>: Enabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("WebhookOpen")]
        [Validation(Required=false)]
        public int? WebhookOpen { get; set; }

    }

}
