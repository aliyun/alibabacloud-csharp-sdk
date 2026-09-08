// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ContainerInfo : TeaModel {
        /// <summary>
        /// <para>The name of the main container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pytorch</para>
        /// </summary>
        [NameInMap("MainContainer")]
        [Validation(Required=false)]
        public string MainContainer { get; set; }

        /// <summary>
        /// <para>The list of sidecar container names.</para>
        /// </summary>
        [NameInMap("SidecarContainers")]
        [Validation(Required=false)]
        public List<string> SidecarContainers { get; set; }

    }

}
