// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class QueryMigrateRegionListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou:test</para>
        /// </summary>
        [NameInMap("LogicalRegionId")]
        [Validation(Required=false)]
        public string LogicalRegionId { get; set; }

    }

}
