// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class NodeOperationParameters : TeaModel {
        /// <summary>
        /// <para>Node cordon parameter settings</para>
        /// </summary>
        [NameInMap("CordonParameters")]
        [Validation(Required=false)]
        public NodeCordonParameters CordonParameters { get; set; }

        /// <summary>
        /// <para>Node drain task instance parameter settings</para>
        /// </summary>
        [NameInMap("DrainParameters")]
        [Validation(Required=false)]
        public NodeDrainParameters DrainParameters { get; set; }

        /// <summary>
        /// <para>Node uncordon parameter settings</para>
        /// </summary>
        [NameInMap("UncordonParameters")]
        [Validation(Required=false)]
        public NodeUncordonParameters UncordonParameters { get; set; }

    }

}
