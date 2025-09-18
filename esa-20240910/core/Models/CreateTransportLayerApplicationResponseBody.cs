// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateTransportLayerApplicationResponseBody : TeaModel {
        /// <summary>
        /// <para>Layer 4 application ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>165503967****</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public long? ApplicationId { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9e5448c7-edaf-49aa-9887-0fcd0832306c</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
