// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class UpdateSharedAccountPermissionRequest : TeaModel {
        /// <summary>
        /// <para>A client token to ensure the idempotence of the request. Generate a unique value for this parameter on your client. The client token can contain only ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10CM943JP0EN9D51H</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The permission type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Deployable: The service can be deployed.</para>
        /// </description></item>
        /// <item><description><para>Accessible: The service can be accessed.</para>
        /// </description></item>
        /// <item><description><para>AccessibleIncludeBeta: All versions of the service, including beta versions, can be accessed.</para>
        /// </description></item>
        /// <item><description><para>DeployableIncludeBeta: All versions of the service, including beta versions, can be deployed.</para>
        /// </description></item>
        /// <item><description><para>Authorized: The service is authorized. This value is used for distribution scenarios.</para>
        /// </description></item>
        /// <item><description><para>Unauthorized: The service is not authorized. This value is used for distribution scenarios.</para>
        /// </description></item>
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
        /// <para>The service ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-0d6e1d846e4c4axxxxxx</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The type of service sharing. The default value is SharedAccount. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SharedAccount: Regular sharing.</para>
        /// </description></item>
        /// <item><description><para>Reseller: Distribution sharing.</para>
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
        /// <para>The whitelisted account with which the service is shared.</para>
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
