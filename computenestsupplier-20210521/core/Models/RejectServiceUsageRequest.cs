// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class RejectServiceUsageRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10CM943JP0EN9D51H</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Reject comments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Thanks for your application, please add your industry information.</para>
        /// </summary>
        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

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
        /// <para>The share type of the service. Default value: SharedAccount. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SharedAccount: The service is shared by multiple accounts.</description></item>
        /// <item><description>Reseller: The service is distributed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SharedAccount</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        /// <summary>
        /// <para>User ali uid.</para>
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
