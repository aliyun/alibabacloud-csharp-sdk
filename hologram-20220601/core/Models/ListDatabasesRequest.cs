// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ListDatabasesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to list only foreign tables. If you set this parameter to \<c>true\\</c>, only foreign tables are listed. If you set this parameter to \<c>false\\</c> or do not specify it, all tables are listed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("external")]
        [Validation(Required=false)]
        public bool? External { get; set; }

    }

}
