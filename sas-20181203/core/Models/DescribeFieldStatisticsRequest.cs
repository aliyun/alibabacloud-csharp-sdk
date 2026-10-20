// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeFieldStatisticsRequest : TeaModel {
        /// <summary>
        /// <para>The type of asset to query. If you do not specify an asset type, the statistics information of all types of assets is queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ecs</b>: server</description></item>
        /// <item><description><b>cloud_product</b>: cloud service</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("MachineTypes")]
        [Validation(Required=false)]
        public string MachineTypes { get; set; }

        /// <summary>
        /// <para>The ID of the region where the server resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the main account of the member accounts in the resource folder.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain the value of this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1232428423234****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

    }

}
