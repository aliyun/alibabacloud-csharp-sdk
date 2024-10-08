// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class DeleteDocumentRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("docIds")]
        [Validation(Required=false)]
        public List<string> DocIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3akzl28vap</para>
        /// </summary>
        [NameInMap("libraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

    }

}
