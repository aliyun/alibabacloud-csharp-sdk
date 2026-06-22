// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cams20200606.Models
{
    public class QueryChatappPhoneNumbersRequest : TeaModel {
        /// <summary>
        /// <para>The Space ID of the ISV sub-customer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>29348393884****</para>
        /// </summary>
        [NameInMap("CustSpaceId")]
        [Validation(Required=false)]
        public string CustSpaceId { get; set; }

        /// <summary>
        /// <para>The verification code of the Independent Software Vendor (ISV). This code is used to verify if the user is authorized by the ISV.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aksik93kdkkxmwol9****</para>
        /// </summary>
        [NameInMap("IsvCode")]
        [Validation(Required=false)]
        public string IsvCode { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The status of the phone number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VERIFIED</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
