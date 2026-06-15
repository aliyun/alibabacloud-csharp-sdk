// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ConfigSetCreateResponseBody : TeaModel {
        /// <summary>
        /// <para>The new configuration set ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXX</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The unique ID for the request. Provide this request ID when contacting support.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
