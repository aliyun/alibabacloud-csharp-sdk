// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class GetTablesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the table. If this parameter is left empty, information about all tables is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>item</para>
        /// </summary>
        [NameInMap("tableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

    }

}
