// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateEdgeContainerAppLogRiverResponseBody : TeaModel {
        /// <summary>
        /// <para>The log path of the container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/root/hello.log</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>42DE97FA-45D2-5615-9A31-55D9EC0D7563</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the standard output of the container is collected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Stdout")]
        [Validation(Required=false)]
        public bool? Stdout { get; set; }

    }

}
