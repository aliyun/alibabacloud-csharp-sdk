// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class GetDefaultKmsInstanceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>kst-hzz65f176a0ogplgq****</para>
        /// </summary>
        [NameInMap("DefaultKmsInstanceId")]
        [Validation(Required=false)]
        public string DefaultKmsInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bbc4e9ab-c76f-48ca-9c2a-8535772117e2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
