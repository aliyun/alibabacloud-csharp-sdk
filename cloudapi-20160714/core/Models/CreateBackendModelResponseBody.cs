// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateBackendModelResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>4be6b110b7aa40b0bf0c83cc00b3bd86</para>
        /// </summary>
        [NameInMap("BackendModelId")]
        [Validation(Required=false)]
        public string BackendModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>64411ECF-FAF7-5E3C-BA7B-E4A1F15A28CA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
