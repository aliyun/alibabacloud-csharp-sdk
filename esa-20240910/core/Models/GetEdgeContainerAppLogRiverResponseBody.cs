// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetEdgeContainerAppLogRiverResponseBody : TeaModel {
        /// <summary>
        /// <para>The log path of the container. It must be an absolute path that starts with a forward slash (/). You can use asterisks (\*) and question marks (?) as wildcards.</para>
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
        /// <para>0AEDAF20-4DDF-4165-8750-47FF9C1929C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the standard output of the container is collected.</para>
        /// </summary>
        [NameInMap("Stdout")]
        [Validation(Required=false)]
        public bool? Stdout { get; set; }

    }

}
