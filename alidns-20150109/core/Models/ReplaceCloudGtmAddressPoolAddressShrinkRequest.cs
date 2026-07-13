// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ReplaceCloudGtmAddressPoolAddressShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The response language. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh-CN</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en-US</b> (Default): English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en-US</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The unique ID of the address pool to update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pool-89618921167339****</para>
        /// </summary>
        [NameInMap("AddressPoolId")]
        [Validation(Required=false)]
        public string AddressPoolId { get; set; }

        /// <summary>
        /// <para>The list of addresses.</para>
        /// </summary>
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public string AddressesShrink { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Ensure the client token is unique for each request. The token can contain a maximum of 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ae05db4-10e7-11ef-b126-00163e24****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
