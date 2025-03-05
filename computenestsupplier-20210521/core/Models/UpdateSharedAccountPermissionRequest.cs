// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class UpdateSharedAccountPermissionRequest : TeaModel {
        /// <summary>
        /// <para>Client token, used to ensure the idempotence of requests. Generate a unique value for this parameter from your client to ensure it is unique across different requests. ClientToken supports only ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10CM943JP0EN9D51H</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Permission type. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>Deployable: Can be deployed.</description></item>
        /// <item><description>Accessible: Can be accessed.</description></item>
        /// <item><description>AccessibleIncludeBeta: Can access all versions, including Beta versions.</description></item>
        /// <item><description>DeployableIncludeBeta: Can deploy all versions, including Beta versions.</description></item>
        /// <item><description>Authorized: Authorized (for reselling scenarios)</description></item>
        /// <item><description>Unauthorized: Unauthorized (for reselling scenarios)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Deployable</para>
        /// </summary>
        [NameInMap("Permission")]
        [Validation(Required=false)]
        public string Permission { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Service ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-0d6e1d846e4c4axxxxxx</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>Service sharing type, with a default value of SharedAccount. Available options:</para>
        /// <list type="bullet">
        /// <item><description><para>SharedAccount: Regular sharing type.</para>
        /// </description></item>
        /// <item><description><para>Reseller: Reselling sharing type.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SharedAccount</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>Whitelist account for service sharing.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1563457855xxxxxx</para>
        /// </summary>
        [NameInMap("UserAliUid")]
        [Validation(Required=false)]
        public long? UserAliUid { get; set; }

    }

}
