// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileProtectEventRequest : TeaModel {
        /// <summary>
        /// <para>The event ID.</para>
        /// <para>This parameter is required. If it is not provided, the API returns HTTP 400 with the error code -101. You can call the ListFileProtectEvent operation to obtain a valid event ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
