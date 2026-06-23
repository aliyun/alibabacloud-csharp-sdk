// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DianJin20240628.Models
{
    public class GetParseResultRequest : TeaModel {
        /// <summary>
        /// <para>The document ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>873648346573245</para>
        /// </summary>
        [NameInMap("docId")]
        [Validation(Required=false)]
        public string DocId { get; set; }

        /// <summary>
        /// <para>The document library ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sjdgdsfg</para>
        /// </summary>
        [NameInMap("libraryId")]
        [Validation(Required=false)]
        public string LibraryId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the result as a URL. If true, the parsing result is in resultUrl, and result is empty. If false, the parsing result is in result, and resultUrl is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("useUrlResult")]
        [Validation(Required=false)]
        public bool? UseUrlResult { get; set; }

    }

}
