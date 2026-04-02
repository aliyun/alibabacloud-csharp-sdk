// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class Funagent : TeaModel {
        [NameInMap("adminName")]
        [Validation(Required=false)]
        public string AdminName { get; set; }

        /// <summary>
        /// <para>敏感；响应中应脱敏</para>
        /// </summary>
        [NameInMap("adminSecret")]
        [Validation(Required=false)]
        public string AdminSecret { get; set; }

        [NameInMap("cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>ISO 8601</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        [NameInMap("dbConnections")]
        [Validation(Required=false)]
        public int? DbConnections { get; set; }

        [NameInMap("dbHost")]
        [Validation(Required=false)]
        public string DbHost { get; set; }

        [NameInMap("dbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>敏感；响应中应脱敏</para>
        /// </summary>
        [NameInMap("dbPassword")]
        [Validation(Required=false)]
        public string DbPassword { get; set; }

        [NameInMap("dbPort")]
        [Validation(Required=false)]
        public int? DbPort { get; set; }

        [NameInMap("dbType")]
        [Validation(Required=false)]
        public string DbType { get; set; }

        [NameInMap("dbUsername")]
        [Validation(Required=false)]
        public string DbUsername { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("endpoint")]
        [Validation(Required=false)]
        public string Endpoint { get; set; }

        /// <summary>
        /// <para>UUID 字符串</para>
        /// </summary>
        [NameInMap("funagentId")]
        [Validation(Required=false)]
        public string FunagentId { get; set; }

        [NameInMap("funagentName")]
        [Validation(Required=false)]
        public string FunagentName { get; set; }

        [NameInMap("imageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        [NameInMap("memory")]
        [Validation(Required=false)]
        public int? Memory { get; set; }

        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("replicas")]
        [Validation(Required=false)]
        public int? Replicas { get; set; }

        [NameInMap("securityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>ISO 8601</para>
        /// </summary>
        [NameInMap("updatedAt")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>与存储一致时为 JSON 字符串</para>
        /// </summary>
        [NameInMap("vswitchIds")]
        [Validation(Required=false)]
        public string VswitchIds { get; set; }

    }

}
