// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class UpdateAlgorithmRequest : TeaModel {
        /// <summary>
        /// <para>The algorithm description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Large language model training.</para>
        /// </summary>
        [NameInMap("AlgorithmDescription")]
        [Validation(Required=false)]
        public string AlgorithmDescription { get; set; }

        /// <summary>
        /// <para>The display name of the algorithm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>LLM Train</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

    }

}
