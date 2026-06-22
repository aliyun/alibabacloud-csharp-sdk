// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeInstanceVulStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The vulnerability type of the Serverless asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>sca</b>: middleware vulnerability</para>
        /// </description></item>
        /// <item><description><para><b>app</b>: scanner vulnerability</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Serverless assets currently support only application vulnerability scanning.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>sca,app</para>
        /// </summary>
        [NameInMap("Types")]
        [Validation(Required=false)]
        public string Types { get; set; }

        /// <summary>
        /// <para>The UUID of the asset instance to query.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to obtain this parameter.</para>
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
