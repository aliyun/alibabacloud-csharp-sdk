// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class Row : TeaModel {
        /// <summary>
        /// <para>Column data for each row.</para>
        /// </summary>
        [NameInMap("Columns")]
        [Validation(Required=false)]
        public List<Column> Columns { get; set; }

    }

}
