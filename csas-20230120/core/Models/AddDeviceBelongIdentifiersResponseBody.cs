// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class AddDeviceBelongIdentifiersResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the records actually added in the batch, returned in the input order of the added items. Skipped duplicates are not included in the array. An empty list is returned if no records are added in the batch.</para>
        /// </summary>
        [NameInMap("IdentifierIds")]
        [Validation(Required=false)]
        public List<string> IdentifierIds { get; set; }

        /// <summary>
        /// <para>The request ID. You can use this ID to locate the API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7A92B549-EC82-5F79-8301-63711AFC9DCE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
