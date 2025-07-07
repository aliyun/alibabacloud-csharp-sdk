// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class ModifyDiskReplicaGroupRequest : TeaModel {
        /// <summary>
        /// <para>The bandwidth value. Unit: Kbit/s.</para>
        /// <remarks>
        /// <para> This parameter is not publicly available.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public long? Bandwidth { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the replication pair-consistent group. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("EnableRtc")]
        [Validation(Required=false)]
        public bool? EnableRtc { get; set; }

        /// <summary>
        /// <para>The name of the replication pair-consistent group. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with <c>http://</c> or <c>https://</c>. It can contain letters, digits, colons (:), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>myreplicagrouptest</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The RPO of the replication pair-consistent group. Unit: seconds. Valid value: 900.</para>
        /// 
        /// <b>Example:</b>
        /// <para>900</para>
        /// </summary>
        [NameInMap("RPO")]
        [Validation(Required=false)]
        public long? RPO { get; set; }

        /// <summary>
        /// <para>The region ID of the replication pair-consistent group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the replication pair-consistent group. You can call the <a href="https://help.aliyun.com/document_detail/426614.html">DescribeDiskReplicaGroups</a> operation to query the IDs of replication pair-consistent groups.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-myreplica****</para>
        /// </summary>
        [NameInMap("ReplicaGroupId")]
        [Validation(Required=false)]
        public string ReplicaGroupId { get; set; }

    }

}
