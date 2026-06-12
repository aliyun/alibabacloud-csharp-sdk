// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class RejectServiceUsageRequest : TeaModel {
        /// <summary>
        /// <para>A client-generated token that ensures the idempotence of a request. Make sure that the token is unique for each request. The token can contain only ASCII characters.</para>
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
        /// <para>Thank you for your application. Please fill in the correct information.</para>
        /// </summary>
        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The service ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>service-2117508c874c41xxxxxx</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The service sharing type. The default value is SharedAccount. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SharedAccount: The common sharing type.</para>
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
        /// <para>The ID of the user\&quot;s Alibaba Cloud account.</para>
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
