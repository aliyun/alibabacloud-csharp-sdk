// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class AddServiceSharedAccountsRequest : TeaModel {
        /// <summary>
        /// <para>A unique identifier that you provide to ensure the idempotence of the request. The token can contain only ASCII characters and cannot be longer than 64 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BBBAAfu+XtuBE55iRLHEYYuojI4=</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

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
        /// <para>service-63b8a060e9d54cxxxxxx</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The shared accounts and their permissions.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SharedAccounts")]
        [Validation(Required=false)]
        public List<AddServiceSharedAccountsRequestSharedAccounts> SharedAccounts { get; set; }
        public class AddServiceSharedAccountsRequestSharedAccounts : TeaModel {
            /// <summary>
            /// <para>The permission type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Deployable: The service can be deployed.</para>
            /// </description></item>
            /// <item><description><para>Accessible: The service can be accessed.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Accessible</para>
            /// </summary>
            [NameInMap("Permission")]
            [Validation(Required=false)]
            public string Permission { get; set; }

            /// <summary>
            /// <para>The UID of the Alibaba Cloud account.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("UserAliUid")]
            [Validation(Required=false)]
            public string UserAliUid { get; set; }

        }

        /// <summary>
        /// <para>The service sharing type. The default value is SharedAccount. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SharedAccount: The service is shared with a specified account.</para>
        /// </description></item>
        /// <item><description><para>Reseller: The service is shared with a reseller.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SharedAccount</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
