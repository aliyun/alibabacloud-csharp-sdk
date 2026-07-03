// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class UpdateAutomateResponseConfigStatusRequest : TeaModel {
        /// <summary>
        /// <para>A JSON array of automated response rule IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[123,345]</para>
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        /// <summary>
        /// <para>The enabling status of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: enabled</para>
        /// </description></item>
        /// <item><description><para>false: disabled</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("InUse")]
        [Validation(Required=false)]
        public bool? InUse { get; set; }

        /// <summary>
        /// <para>The region where the Data Management center for threat analysis is deployed. You must select a region based on the region where your assets are located. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cn-hangzhou: Your assets are in the Chinese mainland or China (Hong Kong).</para>
        /// </description></item>
        /// <item><description><para>ap-southeast-1: Your assets are in a region outside China.</para>
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
        /// <para>The ID of the member account that the administrator wants to access.</para>
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
        /// <item><description><para>1: The view of all accounts that belong to the enterprise.</para>
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
