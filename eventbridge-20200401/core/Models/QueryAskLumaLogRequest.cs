// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class QueryAskLumaLogRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>eyJ0cyI6MTcxN...</para>
        /// </summary>
        [NameInMap("After")]
        [Validation(Required=false)]
        public string After { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>demo-luma-agent</para>
        /// </summary>
        [NameInMap("AgentName")]
        [Validation(Required=false)]
        public string AgentName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

    }

}
