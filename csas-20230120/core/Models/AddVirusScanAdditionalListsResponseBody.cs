// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class AddVirusScanAdditionalListsResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of the added list entries. The order of the IDs is the same as the order of the entries in the AdditionalLists parameter of the request.</para>
        /// </summary>
        [NameInMap("ListIds")]
        [Validation(Required=false)]
        public List<string> ListIds { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3D7EC0AF-DB2A-5D9C-90EC-F090A6BAAEA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
