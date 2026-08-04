// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class CacheService : TeaModel {
        /// <summary>
        /// <para>Information about each cache node in the service.</para>
        /// </summary>
        [NameInMap("CacheInfos")]
        [Validation(Required=false)]
        public List<CacheInfo> CacheInfos { get; set; }

        /// <summary>
        /// <para>The unique identifier of the CacheService.</para>
        /// </summary>
        [NameInMap("CacheServiceId")]
        [Validation(Required=false)]
        public string CacheServiceId { get; set; }

        /// <summary>
        /// <para>The ID of the PAI cluster where the CacheService is deployed.</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The user or entity that created the resource.</para>
        /// </summary>
        [NameInMap("CreatedBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// <para>The time (in UTC, ISO 8601 format) when the CacheService was created.</para>
        /// </summary>
        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        /// <summary>
        /// <para>Indicates whether the CacheService is sharded across multiple nodes.</para>
        /// </summary>
        [NameInMap("IsSharded")]
        [Validation(Required=false)]
        public bool? IsSharded { get; set; }

        /// <summary>
        /// <para>The network type of the CacheService. For example, <c>VPC</c>.</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The ID of the resource quota associated with the CacheService.</para>
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// <para>The current status of the CacheService. For example: <c>Creating</c>, <c>Available</c>, or <c>Deleting</c>.</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the CacheService supports RDMA.</para>
        /// </summary>
        [NameInMap("SupportRDMA")]
        [Validation(Required=false)]
        public string SupportRDMA { get; set; }

        /// <summary>
        /// <para>A list of quota IDs for clients that can connect to this CacheService.</para>
        /// </summary>
        [NameInMap("SupportedClientQuotaIds")]
        [Validation(Required=false)]
        public List<string> SupportedClientQuotaIds { get; set; }

        /// <summary>
        /// <para>The ID of the tenant that owns the CacheService.</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The ID of the user associated with the CacheService.</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The configuration of the user\&quot;s VPC where the CacheService is deployed.</para>
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public UserVpc UserVpc { get; set; }

    }

}
