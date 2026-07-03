// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeEntityInfoRequest : TeaModel {
        /// <summary>
        /// <para>The logical ID of the entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("EntityId")]
        [Validation(Required=false)]
        public long? EntityId { get; set; }

        /// <summary>
        /// <para>The feature value of the entity. You can perform a fuzzy search for the entity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test22.php</para>
        /// </summary>
        [NameInMap("EntityIdentity")]
        [Validation(Required=false)]
        public string EntityIdentity { get; set; }

        /// <summary>
        /// <para>The globally unique UUID of the event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>85ea4241-798f-4684-a876-65d4f0c3****</para>
        /// </summary>
        [NameInMap("IncidentUuid")]
        [Validation(Required=false)]
        public string IncidentUuid { get; set; }

        /// <summary>
        /// <para>The region of the Data Management center. Select a region based on the region where your assets are located. Valid values:</para>
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
        /// <para>The user ID of the member. The administrator can use this ID to switch to the view of this member.</para>
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
        /// <item><description><para>0: the view of the current Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>1: the view of all accounts that belong to the enterprise.</para>
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
        /// <para>The ID of the SOAR response policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>577bbf90-a770-44a7-8154-586aa2d318fa</para>
        /// </summary>
        [NameInMap("SophonTaskId")]
        [Validation(Required=false)]
        public string SophonTaskId { get; set; }

    }

}
