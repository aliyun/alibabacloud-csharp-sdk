// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClusterVulStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the container cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c471f0f61b9c04f8380556e922cf1****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The type of the vulnerabilities. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cve</b>: Linux software vulnerabilities</description></item>
        /// <item><description><b>app</b>: application vulnerabilities</description></item>
        /// <item><description><b>sca</b>: vulnerabilities that are detected based on software component analysis</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cve,app,sca</para>
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public string Types { get; set; }

    }

}
