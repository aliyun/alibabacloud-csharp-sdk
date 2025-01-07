// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeInstanceVulStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The vulnerability type of the serverless instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>sca</b>: middleware vulnerabilities</description></item>
        /// <item><description><b>app</b>: application vulnerabilities detected by using a scanner</description></item>
        /// </list>
        /// <remarks>
        /// <para> Serverless instances allow you to detect only application vulnerabilities by using a scanner.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sca,app</para>
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public string Types { get; set; }

        /// <summary>
        /// <para>The UUID of the instance to query.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to query the UUID of the instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5b268326-273e-44fc-a0e3-9482435c****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
