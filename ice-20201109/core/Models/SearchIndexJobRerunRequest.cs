// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchIndexJobRerunRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the media asset. Separate multiple IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>b48fb04483915d4f2cd8</b></b></b>,<b><b><b>c48fb37407365d4f2cd8</b></b></b></para>
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The search library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-1</para>
        /// </summary>
        [NameInMap("SearchLibName")]
        [Validation(Required=false)]
        public string SearchLibName { get; set; }

        /// <summary>
        /// <para>The type of the job. Separate multiple types with commas (,).</para>
        /// <list type="bullet">
        /// <item><description>aiLabel: smart tagging.</description></item>
        /// <item><description>face: face recognition.</description></item>
        /// <item><description>mm: large visual model.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AiLabel,Face,Mm</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public string Task { get; set; }

    }

}
