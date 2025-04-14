// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetTableRequest : TeaModel {
        /// <summary>
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
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeBusinessMetadata")]
        [Validation(Required=false)]
        public bool? IncludeBusinessMetadata { get; set; }

    }

}
