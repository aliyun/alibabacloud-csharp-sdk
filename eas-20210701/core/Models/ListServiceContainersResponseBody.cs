// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListServiceContainersResponseBody : TeaModel {
        /// <summary>
        /// <para>The containers of the service.</para>
        /// </summary>
        [NameInMap("Containers")]
        [Validation(Required=false)]
        public List<ContainerInfo> Containers { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>foo</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

    }

}
