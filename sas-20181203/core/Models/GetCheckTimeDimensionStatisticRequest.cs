// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckTimeDimensionStatisticRequest : TeaModel {
        /// <summary>
        /// <para>The end time in UNIX timestamp format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1672285044000</para>
        /// </summary>
        [NameInMap("EndTimeStamp")]
        [Validation(Required=false)]
        public long? EndTimeStamp { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the member accounts in the resource folder belong.</para>
        /// <remarks>
        /// <para>You can invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123456</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The start time in UNIX timestamp format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1672385044000</para>
        /// </summary>
        [NameInMap("StartTimeStamp")]
        [Validation(Required=false)]
        public long? StartTimeStamp { get; set; }

        /// <summary>
        /// <para>The data statistics type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CheckPassRate</b>: The pass rate of check items.</description></item>
        /// <item><description><b>AssetPassRate</b>: The pass rate of assets.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AssetPassRate</para>
        /// </summary>
        [NameInMap("StatisticType")]
        [Validation(Required=false)]
        public string StatisticType { get; set; }

        /// <summary>
        /// <para>The list of cloud providers.</para>
        /// </summary>
        [NameInMap("Vendors")]
        [Validation(Required=false)]
        public List<string> Vendors { get; set; }

    }

}
