// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class CreatePxfsTenantRequest : TeaModel {
        /// <summary>
        /// <para>The PolarDB-X instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-xxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The capacity quota.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>107374182400</para>
        /// </summary>
        [NameInMap("QuotaBytes")]
        [Validation(Required=false)]
        public long? QuotaBytes { get; set; }

        /// <summary>
        /// <para>The file count quota.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000</para>
        /// </summary>
        [NameInMap("QuotaFiles")]
        [Validation(Required=false)]
        public long? QuotaFiles { get; set; }

        /// <summary>
        /// <para>The request rate limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("RateLimitRps")]
        [Validation(Required=false)]
        public long? RateLimitRps { get; set; }

        /// <summary>
        /// <para>The write bandwidth limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>104857600</para>
        /// </summary>
        [NameInMap("RateLimitWbps")]
        [Validation(Required=false)]
        public long? RateLimitWbps { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the tenant.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tenant-001</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The name of the tenant.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agent-files</para>
        /// </summary>
        [NameInMap("TenantName")]
        [Validation(Required=false)]
        public string TenantName { get; set; }

    }

}
