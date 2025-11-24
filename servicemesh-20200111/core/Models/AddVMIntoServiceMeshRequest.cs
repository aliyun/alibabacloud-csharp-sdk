// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class AddVMIntoServiceMeshRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ECS instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-2ze90ts4e7dj3650****</para>
        /// </summary>
        [NameInMap("EcsId")]
        [Validation(Required=false)]
        public string EcsId { get; set; }

        /// <summary>
        /// <para>The ASM instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccb37ff104caf419fbf48fb38e6f3****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
