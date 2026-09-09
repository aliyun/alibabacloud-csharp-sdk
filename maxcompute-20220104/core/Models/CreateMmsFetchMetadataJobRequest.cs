// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class CreateMmsFetchMetadataJobRequest : TeaModel {
        /// <summary>
        /// <para>Updates metadata for the specified source database, schema, or dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("dbName")]
        [Validation(Required=false)]
        public string DbName { get; set; }

        /// <summary>
        /// <para>Updates metadata for the specified source tables.</para>
        /// </summary>
        [NameInMap("tableNames")]
        [Validation(Required=false)]
        public List<string> TableNames { get; set; }

    }

}
