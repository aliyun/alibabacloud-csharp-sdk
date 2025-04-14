// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class LineageEntity : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;key1&quot;:&quot;value1&quot;}</para>
        /// </summary>
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>maxcompute-table:123456::test_project::test_tbl</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test_tbl</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
