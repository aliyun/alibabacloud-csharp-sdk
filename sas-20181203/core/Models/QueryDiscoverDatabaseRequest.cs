// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryDiscoverDatabaseRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the scan task.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~StartDiscoverDatabaseTask~~">StartDiscoverDatabaseTask</a> operation to query the ID of the task.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7f7b051f-7d1c-46da-b253-a03f3a27****</para>
        /// </summary>
        [NameInMap("CreateMark")]
        [Validation(Required=false)]
        public string CreateMark { get; set; }

    }

}
