// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class UpdateControlPlaneLogConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to collect control plane logs to Simple Log Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The time to live (TTL) period of the collected logs. Unit: day.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("LogTTLInDay")]
        [Validation(Required=false)]
        public int? LogTTLInDay { get; set; }

        /// <summary>
        /// <para>The name of the Simple Log Service project to which control plane logs are collected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aia-asm-deva-sh</para>
        /// </summary>
        [NameInMap("Project")]
        [Validation(Required=false)]
        public string Project { get; set; }

        /// <summary>
        /// <para>The ID of the Service Mesh (ASM) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c20667db760fe4ee6910220136624****</para>
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
