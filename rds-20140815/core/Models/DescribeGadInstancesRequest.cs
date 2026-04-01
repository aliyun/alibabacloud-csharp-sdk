// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeGadInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the global active database cluster.</para>
        /// <list type="bullet">
        /// <item><description>If you leave this parameter empty, this operation returns the details about all global active database clusters that are created within your Alibaba Cloud account.</description></item>
        /// <item><description>If you specify this parameter, this operation returns the details about the global active database cluster that you specify.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify this parameter when you call this operation for the first time, the IDs of all clusters that are created by using the current account are returned. Then, you can specify the cluster ID to view the cluster details.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gad-rm-bp1npi2j8********</para>
        /// </summary>
        [NameInMap("GadInstanceName")]
        [Validation(Required=false)]
        public string GadInstanceName { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy*****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
