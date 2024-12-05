// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchengine20211025.Models
{
    public class ListIndexesRequest : TeaModel {
        [NameInMap("catalog")]
        [Validation(Required=false)]
        public string Catalog { get; set; }

        [NameInMap("database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// <para>Specifies whether the OpenSearch Vector Search Edition instance is of the new version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("newMode")]
        [Validation(Required=false)]
        public bool? NewMode { get; set; }

        [NameInMap("table")]
        [Validation(Required=false)]
        public string Table { get; set; }

    }

}
