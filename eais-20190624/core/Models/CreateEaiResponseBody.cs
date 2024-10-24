// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eais20190624.Models
{
    public class CreateEaiResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>eais-sz8t15a7gt7z7j7i****</para>
        /// </summary>
        [NameInMap("ElasticAcceleratedInstanceId")]
        [Validation(Required=false)]
        public string ElasticAcceleratedInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A655AB0E-31BB-45AD-9255-FCE93F6*****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
