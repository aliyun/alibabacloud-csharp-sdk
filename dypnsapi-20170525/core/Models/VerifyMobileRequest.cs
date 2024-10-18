// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dypnsapi20170525.Models
{
    public class VerifyMobileRequest : TeaModel {
        /// <summary>
        /// <para>The token obtained by the SDK for your app.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Dfafdafad542****</para>
        /// </summary>
        [NameInMap("AccessCode")]
        [Validation(Required=false)]
        public string AccessCode { get; set; }

        /// <summary>
        /// <para>The external ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The phone number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13800****00</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
