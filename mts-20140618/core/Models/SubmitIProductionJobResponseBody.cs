// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitIProductionJobResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>39f8e0bc005e4f309379701645f4****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5210DBB0-E327-4D45-ADBC-0B83C8796E26</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{ &quot;Code&quot;:&quot;Success&quot;, &quot;Details&quot;:[], &quot;FunctionName&quot;:&quot;ImageCartoonize&quot;, &quot;JobId&quot;:&quot;39f8e0bc005e4f309379701645f4****&quot;, &quot;Message&quot;:&quot;success&quot;, &quot;State&quot;:&quot;Success&quot;, &quot;Type&quot;:&quot;IProduction&quot; }</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public string Result { get; set; }

    }

}
