// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetOptionValueForProjectResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned In the example, cuNumber is a custom key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;cuNumber&quot;:&quot;0&quot;}</para>
        /// </summary>
        [NameInMap("OptionValue")]
        [Validation(Required=false)]
        public string OptionValue { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E6F0DBDD-5AD****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
