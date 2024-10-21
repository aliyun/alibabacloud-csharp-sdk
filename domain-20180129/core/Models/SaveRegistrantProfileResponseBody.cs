// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Domain20180129.Models
{
    public class SaveRegistrantProfileResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3600000</para>
        /// </summary>
        [NameInMap("RegistrantProfileId")]
        [Validation(Required=false)]
        public long? RegistrantProfileId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>D09B153B-294D-42F1-BB61-F1C72136DFD3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
