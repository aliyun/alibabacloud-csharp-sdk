// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListAgentsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>my-agent</para>
        /// </summary>
        [NameInMap("After")]
        [Validation(Required=false)]
        public string After { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public string Limit { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

    }

}
