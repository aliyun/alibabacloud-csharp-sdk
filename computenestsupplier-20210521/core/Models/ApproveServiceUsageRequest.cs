// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ApproveServiceUsageRequest : TeaModel {
        /// <summary>
        /// <para>A client token that ensures the idempotence of the request. Generate a unique value from your client for each request. The token can contain only ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10CM943JP0EN9D51H</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The approval comments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Welcome to ComputeNest service</para>
        /// </summary>
        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
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
        /// <para>service-39f4f251e94843xxxxxx</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The service sharing type. The default value is SharedAccount. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SharedAccount: The regular sharing type.</para>
        /// </description></item>
        /// <item><description><para>Reseller: The reseller sharing type.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SharedAccount</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        /// <summary>
        /// <para>The UID of the user\&quot;s Alibaba Cloud account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127383705958xxxx</para>
        /// </summary>
        [NameInMap("UserAliUid")]
        [Validation(Required=false)]
        public long? UserAliUid { get; set; }

    }

}
