// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class LineageTask : TeaModel {
        [NameInMap("Attributes")]
        [Validation(Required=false)]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>custom-sql</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
