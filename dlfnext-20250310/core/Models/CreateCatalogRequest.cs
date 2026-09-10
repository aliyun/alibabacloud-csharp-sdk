// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DlfNext20250310.Models
{
    public class CreateCatalogRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether the catalog is a shared data catalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isShared")]
        [Validation(Required=false)]
        public bool? IsShared { get; set; }

        /// <summary>
        /// <para>The name of the data catalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>catalog_demo</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The configuration parameter struct.</para>
        /// </summary>
        [NameInMap("options")]
        [Validation(Required=false)]
        public Dictionary<string, string> Options { get; set; }

        /// <summary>
        /// <para>The share ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>share-xxxx</para>
        /// </summary>
        [NameInMap("shareId")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        /// <summary>
        /// <para>The type of the data catalog.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PAIMON</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
