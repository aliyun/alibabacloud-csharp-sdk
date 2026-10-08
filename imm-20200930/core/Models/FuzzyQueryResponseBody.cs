// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class FuzzyQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of file information.</para>
        /// </summary>
        [NameInMap("Files")]
        [Validation(Required=false)]
        public List<File> Files { get; set; }

        /// <summary>
        /// <para>The token used for pagination when the total number of files exceeds the value of MaxResults.</para>
        /// <para>When you list file information next time, set NextToken to this value to return the remaining results.</para>
        /// <para>This parameter is returned only when not all files are returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTIzNDU2Nzg6aW1tdGVzdDpleGFtcGxlYnVja2V0OmRhdGFzZXQwMDE6b3NzOi8vZXhhbXBsZWJ1Y2tldC9zYW1wbGVvYmplY3QxLmpwZw==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1B3D5E0A-D8B8-4DA0-8127-ED32C851****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of matched records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalHits")]
        [Validation(Required=false)]
        public long? TotalHits { get; set; }

    }

}
