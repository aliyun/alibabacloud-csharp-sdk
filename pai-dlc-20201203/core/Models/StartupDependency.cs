// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class StartupDependency : TeaModel {
        /// <summary>
        /// <para>The minimum number of dependent roles that must reach the expected phase to be considered satisfied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinReplicas")]
        [Validation(Required=false)]
        public string MinReplicas { get; set; }

        /// <summary>
        /// <para>The phase that dependent roles must reach to be considered satisfied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ServiceReady</para>
        /// </summary>
        [NameInMap("OnPhase")]
        [Validation(Required=false)]
        public string OnPhase { get; set; }

        /// <summary>
        /// <para>The type of the dependent role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Worker</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
