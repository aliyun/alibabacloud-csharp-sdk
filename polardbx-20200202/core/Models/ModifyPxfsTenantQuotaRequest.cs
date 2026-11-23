// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class ModifyPxfsTenantQuotaRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-htri0ori2r****</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The storage capacity quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>107374182400</para>
        /// </summary>
        [NameInMap("QuotaBytes")]
        [Validation(Required=false)]
        public long? QuotaBytes { get; set; }

        /// <summary>
        /// <para>The file count quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000000</para>
        /// </summary>
        [NameInMap("QuotaFiles")]
        [Validation(Required=false)]
        public long? QuotaFiles { get; set; }

        /// <summary>
        /// <para>The maximum request rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("RateLimitRps")]
        [Validation(Required=false)]
        public long? RateLimitRps { get; set; }

        /// <summary>
        /// <para>The maximum write bandwidth.</para>
        /// 
        /// <b>Example:</b>
        /// <para>104857600</para>
        /// </summary>
        [NameInMap("RateLimitWbps")]
        [Validation(Required=false)]
        public long? RateLimitWbps { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tenant-001</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
