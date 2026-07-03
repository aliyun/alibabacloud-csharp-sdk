// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeAutomateResponseConfigFeatureRequest : TeaModel {
        /// <summary>
        /// <para>The type of automated response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>event: event</para>
        /// </description></item>
        /// <item><description><para>alert: alert</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>event</para>
        /// </summary>
        [NameInMap("AutoResponseType")]
        [Validation(Required=false)]
        public string AutoResponseType { get; set; }

        /// <summary>
        /// <para>The region where the Data Management center of threat analysis is deployed. Select a region based on the location of your assets. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Assets in the Chinese mainland and Hong Kong (China).</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Assets outside China.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The user ID of the member. An administrator can use this parameter to switch to the perspective of the member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The type of view. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: the view of the current Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>1: the view of all accounts that are managed by the administrator account.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

    }

}
