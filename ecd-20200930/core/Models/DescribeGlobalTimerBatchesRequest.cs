// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeGlobalTimerBatchesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the scheduled task group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccg-i1ruuudp92qpj****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token for the next query. An empty value indicates that there are no more results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f84eb48b699f0a4883</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <list type="bullet">
        /// <item><description>Shanghai</description></item>
        /// <item><description>Singapore</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public List<string> ResourceTypes { get; set; }

        /// <summary>
        /// <para>The region ID used for searching. Filters cloud desktop information for the specified region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SearchRegionId")]
        [Validation(Required=false)]
        public string SearchRegionId { get; set; }

        /// <summary>
        /// <para>The type of task to query. Only scheduled tasks have batch information available.</para>
        /// <list type="bullet">
        /// <item><description>TimerBoot: scheduled startup</description></item>
        /// <item><description>TimerShutdown: scheduled shutdown</description></item>
        /// <item><description>TimerReboot: scheduled restart</description></item>
        /// <item><description>TimerReset: scheduled reset</description></item>
        /// <item><description>TimerMaintenance: scheduled maintenance</description></item>
        /// <item><description>TimerHibernate: scheduled hibernation</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TimerType")]
        [Validation(Required=false)]
        public string TimerType { get; set; }

    }

}
