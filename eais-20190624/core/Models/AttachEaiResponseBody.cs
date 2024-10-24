// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eais20190624.Models
{
    public class AttachEaiResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>i-wz93g6pyat2g7t7o****</para>
        /// </summary>
        [NameInMap("ClientInstanceId")]
        [Validation(Required=false)]
        public string ClientInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eais-sz8t15a7gt7z7j7i****</para>
        /// </summary>
        [NameInMap("ElasticAcceleratedInstanceId")]
        [Validation(Required=false)]
        public string ElasticAcceleratedInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C3BCB7DA-BEB6-4982-A765-6EA61EC84474</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
