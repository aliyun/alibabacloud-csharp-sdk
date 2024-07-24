// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class QueryHBaseHaDBRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bds-t4n3496whj23ia4k</para>
        /// </summary>
        [NameInMap("BdsId")]
        [Validation(Required=false)]
        public string BdsId { get; set; }

    }

}
