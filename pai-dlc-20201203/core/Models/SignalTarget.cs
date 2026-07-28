// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class SignalTarget : TeaModel {
        /// <summary>
        /// <para>The pod name. Required when Scope is set to pods.</para>
        /// </summary>
        [NameInMap("PodNames")]
        [Validation(Required=false)]
        public List<string> PodNames { get; set; }

        /// <summary>
        /// <para>The role information. Required when Scope is set to roles.</para>
        /// </summary>
        [NameInMap("Roles")]
        [Validation(Required=false)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// <para>The send scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pods</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}
