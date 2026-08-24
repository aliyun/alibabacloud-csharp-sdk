// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class AddDataAgentMemoryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Diamond pricing analysis requires examining the skewness and outliers of the distribution of each feature.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DMSUnit")]
        [Validation(Required=false)]
        public string DMSUnit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2037**********23</para>
        /// </summary>
        [NameInMap("FromId")]
        [Validation(Required=false)]
        public string FromId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fact_specifications</para>
        /// </summary>
        [NameInMap("Label")]
        [Validation(Required=false)]
        public string Label { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("MemFrom")]
        [Validation(Required=false)]
        public string MemFrom { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fc5ice**********ac6e</para>
        /// </summary>
        [NameInMap("SessionUuid")]
        [Validation(Required=false)]
        public string SessionUuid { get; set; }

    }

}
