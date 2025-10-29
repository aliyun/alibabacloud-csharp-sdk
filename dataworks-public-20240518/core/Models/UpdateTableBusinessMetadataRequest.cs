// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateTableBusinessMetadataRequest : TeaModel {
        /// <summary>
        /// <para>The table ID. You can refer to the format of the table ID returned by the ListTables operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>maxcompute-table:123456XXX::test_project::test_tbl
        /// dlf-table:123456XXX:test_catalog:test_db::test_tbl
        /// hms-table:c-abc123xxx::test_db::test_tbl
        /// holo-table:h-abc123xxx::test_db:test_schema:test_tbl</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The usage notes. The rich text format is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <h2>introduction</h2>
        /// </summary>
        [NameInMap("Readme")]
        [Validation(Required=false)]
        public string Readme { get; set; }

    }

}
