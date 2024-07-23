// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ListChunksRequest : TeaModel {
        [NameInMap("Fields")]
        [Validation(Required=false)]
        public List<string> Fields { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>file_5f03dfea56da4050ab68d61871fc4cb3_10151493</para>
        /// </summary>
        [NameInMap("Filed")]
        [Validation(Required=false)]
        public string Filed { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>otoru9en4v</para>
        /// </summary>
        [NameInMap("IndexId")]
        [Validation(Required=false)]
        public string IndexId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
