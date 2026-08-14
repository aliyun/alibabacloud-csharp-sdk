// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class CreateMailAddressRequest : TeaModel {
        /// <summary>
        /// <para>The sender address.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Account+@+domain</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The type of the address to create. Valid values:
        /// EXTERNAL: The domain name of the address to create has not been created in this system.
        /// INTERNAL: The domain name of the address to create has already been created in this system.</para>
        /// </summary>
        [NameInMap("AddressType")]
        [Validation(Required=false)]
        public string AddressType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The reply-to address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1***@example.net</para>
        /// </summary>
        [NameInMap("ReplyAddress")]
        [Validation(Required=false)]
        public string ReplyAddress { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The type of email. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>batch: batch email</para>
        /// </description></item>
        /// <item><description><para>trigger: triggered email</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>batch</para>
        /// </summary>
        [NameInMap("Sendtype")]
        [Validation(Required=false)]
        public string Sendtype { get; set; }

    }

}
