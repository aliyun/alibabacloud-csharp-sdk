// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListPromptsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of prompts.</para>
        /// </summary>
        [NameInMap("Prompts")]
        [Validation(Required=false)]
        public List<Prompt> Prompts { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D5BFFEE3-6025-443F-8A03-02D619B5C4B9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned under the current request conditions. This parameter is optional and may not be returned by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
