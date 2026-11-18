// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20241111.Models
{
    public class AgentBaseQuery : TeaModel {
        /// <summary>
        /// <para>The natural language question used to retrieve nearby locations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Luxury hotels within 5 km of Lingyin Temple in Hangzhou</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

    }

}
