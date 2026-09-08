// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class CacheService : TeaModel {
        /// <summary>
        /// <para>The list of data source cache information connected to the cache service. Each element corresponds to a data source and its access port.</para>
        /// </summary>
        [NameInMap("CacheInfos")]
        [Validation(Required=false)]
        public List<CacheInfo> CacheInfos { get; set; }

        /// <summary>
        /// <para>The cache service ID. This is the unique identifier of the cache service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cachea1b2c3d4e5f</para>
        /// </summary>
        [NameInMap("CacheServiceId")]
        [Validation(Required=false)]
        public string CacheServiceId { get; set; }

        /// <summary>
        /// <para>The ID of the cluster where the cache service resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c1a2b3c4d5e6f7a8b9c0d1e2f3a4b5c6</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The ID of the resource quota that created the cache service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quota1a2b3c4d5e6</para>
        /// </summary>
        [NameInMap("CreatedBy")]
        [Validation(Required=false)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// <para>The time when the cache service was created, in UTC in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-08-10T03:17:31Z</para>
        /// </summary>
        [NameInMap("GmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        /// <summary>
        /// <para>Indicates whether the service discovery of the cache service uses shard mode.</para>
        /// </summary>
        [NameInMap("IsSharded")]
        [Validation(Required=false)]
        public bool? IsSharded { get; set; }

        /// <summary>
        /// <para>The type of RDMA network interface controller used by the cache service. This parameter is returned only when SupportRDMA is set to true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>eic: EIC network interface controller.</description></item>
        /// <item><description>mlx: Mellanox network interface controller.</description></item>
        /// </list>
        /// <para>This parameter is empty when RDMA is not enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eic</para>
        /// </summary>
        [NameInMap("NetworkType")]
        [Validation(Required=false)]
        public string NetworkType { get; set; }

        /// <summary>
        /// <para>The ID of the resource quota to which the cache service belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>quota1a2b3c4d5e6</para>
        /// </summary>
        [NameInMap("QuotaId")]
        [Validation(Required=false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// <para>The current status of the cache service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the cache service supports access through RDMA networks.</para>
        /// </summary>
        [NameInMap("SupportRDMA")]
        [Validation(Required=false)]
        public string SupportRDMA { get; set; }

        /// <summary>
        /// <para>The list of client quota IDs that are allowed to access the cache service.</para>
        /// </summary>
        [NameInMap("SupportedClientQuotaIds")]
        [Validation(Required=false)]
        public List<string> SupportedClientQuotaIds { get; set; }

        /// <summary>
        /// <para>The tenant ID to which the cache service belongs, which is the Alibaba Cloud account ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890123456</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The ID of the user who created the cache service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789012345678</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The VPC network information of the cache service, including the VPC, vSwitch, and security group configurations.</para>
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public UserVpc UserVpc { get; set; }

    }

}
