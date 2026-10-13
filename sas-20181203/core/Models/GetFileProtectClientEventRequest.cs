// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileProtectClientEventRequest : TeaModel {
        /// <summary>
        /// <para>The unique ID of the alert event. This parameter is required. If it is not provided, the API returns an HTTP 400 error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>131231</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
