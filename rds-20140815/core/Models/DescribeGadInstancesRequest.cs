// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeGadInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the GAD cluster.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the IDs of all GAD clusters under the current account are returned.</description></item>
        /// <item><description>If you specify this parameter, the details of the specified cluster are returned.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can leave this parameter empty in the first call to obtain the IDs of all GAD clusters under the current account, and then specify a cluster ID to view the details of the cluster.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gad-rm-bp1npi2j8****</para>
        /// </summary>
        [NameInMap("GadInstanceName")]
        [Validation(Required=false)]
        public string GadInstanceName { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query the region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
