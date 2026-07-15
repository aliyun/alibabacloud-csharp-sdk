// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HiMarketModelConfig : TeaModel {
        /// <summary>
        /// <para>The Model API configuration wrapper.</para>
        /// </summary>
        [NameInMap("modelAPIConfig")]
        [Validation(Required=false)]
        public HiMarketModelConfigModelAPIConfig ModelAPIConfig { get; set; }
        public class HiMarketModelConfigModelAPIConfig : TeaModel {
            /// <summary>
            /// <para>The list of AI protocols.</para>
            /// </summary>
            [NameInMap("aiProtocols")]
            [Validation(Required=false)]
            public List<string> AiProtocols { get; set; }

            /// <summary>
            /// <para>The model categorization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Text</para>
            /// </summary>
            [NameInMap("modelCategory")]
            [Validation(Required=false)]
            public string ModelCategory { get; set; }

            /// <summary>
            /// <para>The list of routing configurations.</para>
            /// </summary>
            [NameInMap("routes")]
            [Validation(Required=false)]
            public List<HiMarketHttpRoute> Routes { get; set; }

        }

    }

}
