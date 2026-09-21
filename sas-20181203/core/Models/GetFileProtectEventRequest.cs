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
        /// <para>This parameter is required. If this parameter is not specified, the API returns HTTP 400 with error code -101. You can call ListFileProtectEvent to obtain valid event IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
