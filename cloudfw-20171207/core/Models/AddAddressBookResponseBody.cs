// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class AddAddressBookResponseBody : TeaModel {
        /// <summary>
        /// <para>The UUID of the returned address book.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f04ac7ce-628b-4cb7-be61-310222b7****</para>
        /// </summary>
        [NameInMap("GroupUuid")]
        [Validation(Required=false)]
        public string GroupUuid { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
