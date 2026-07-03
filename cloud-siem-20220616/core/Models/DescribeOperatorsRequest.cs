// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeOperatorsRequest : TeaModel {
        /// <summary>
        /// <para>The region of the Data Management center for threat analysis. Select a region based on your asset location. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Assets in the Chinese mainland and China (Hong Kong).</para>
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
        /// <para>The user ID of the member. An administrator can use this parameter to switch to the perspective of this member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113091674488****</para>
        /// </summary>
        [NameInMap("RoleFor")]
        [Validation(Required=false)]
        public long? RoleFor { get; set; }

        /// <summary>
        /// <para>The view type.</para>
        /// <list type="bullet">
        /// <item><description><para>0: The view of the current Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>1: The view of all accounts that are managed by your enterprise.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RoleType")]
        [Validation(Required=false)]
        public int? RoleType { get; set; }

        /// <summary>
        /// <para>The scenario for the operator. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If you leave this parameter empty, the default scenario is used.</para>
        /// </description></item>
        /// <item><description><para>AGGREGATE: The aggregate function scenario.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AGGREGATE</para>
        /// </summary>
        [NameInMap("SceneType")]
        [Validation(Required=false)]
        public string SceneType { get; set; }

    }

}
