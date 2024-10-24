// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eais20190624.Models
{
    public class CreateEaiEcsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>i-bp1hjrvleawl4ogb****</para>
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
        /// <para>F5FEB9AA-C108-577C-AB3D-D13524AF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
