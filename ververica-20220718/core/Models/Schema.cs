// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class Schema : TeaModel {
        /// <summary>
        /// <para>The information about columns.</para>
        /// </summary>
        [NameInMap("columns")]
        [Validation(Required=false)]
        public List<TableColumn> Columns { get; set; }

        /// <summary>
        /// <para>The information about the primary key.</para>
        /// </summary>
        [NameInMap("primaryKey")]
        [Validation(Required=false)]
        public PrimaryKey PrimaryKey { get; set; }

        /// <summary>
        /// <para>The watermark information.</para>
        /// </summary>
        [NameInMap("watermarkSpecs")]
        [Validation(Required=false)]
        public List<WatermarkSpec> WatermarkSpecs { get; set; }

    }

}
