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
        /// <para>The token used to retrieve the next page of results. Set this parameter to the <c>NextToken</c> value from a previous response.</para>
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
        /// <item><description><para>China (Shanghai)</para>
        /// </description></item>
        /// <item><description><para>Singapore (Singapore)</para>
        /// </description></item>
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
        /// <para>The ID of the region where the cloud computers are located. This parameter filters the results to include only cloud computers in the specified region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SearchRegionId")]
        [Validation(Required=false)]
        public string SearchRegionId { get; set; }

        /// <summary>
        /// <para>The type of the scheduled task. This operation returns batch information for timer-based scheduled tasks only.</para>
        /// <list type="bullet">
        /// <item><description><para><c>TimerBoot</c>: scheduled startup</para>
        /// </description></item>
        /// <item><description><para><c>TimerShutdown</c>: scheduled shutdown</para>
        /// </description></item>
        /// <item><description><para><c>TimerReboot</c>: scheduled reboot</para>
        /// </description></item>
        /// <item><description><para><c>TimerReset</c>: scheduled reset</para>
        /// </description></item>
        /// <item><description><para><c>TimerMaintenance</c>: scheduled maintenance</para>
        /// </description></item>
        /// <item><description><para><c>TimerHibernate</c>: scheduled hibernation</para>
        /// </description></item>
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
