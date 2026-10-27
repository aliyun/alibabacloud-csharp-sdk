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
        /// <remarks>
        /// <para>You can call the <a href="~~ListFileProtectEvent~~">ListFileProtectEvent</a> operation to retrieve this parameter.
        /// This parameter is required. If it is not provided, the API returns HTTP 400 with error code -101.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

    }

}
