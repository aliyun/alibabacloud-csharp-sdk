// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class DeploymentTarget : TeaModel {
        /// <summary>
        /// <para>The name of the perjob deployment target.</para>
        /// 
        /// <b>Example:</b>
        /// <para>deployment target</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The namespace name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namespace</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The resource quota.</para>
        /// </summary>
        [NameInMap("quota")]
        [Validation(Required=false)]
        public ResourceQuota Quota { get; set; }

    }

}
