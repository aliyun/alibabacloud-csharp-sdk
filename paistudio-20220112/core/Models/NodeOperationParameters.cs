// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class NodeOperationParameters : TeaModel {
        /// <summary>
        /// <para>The parameter settings for disabling node scheduling.</para>
        /// </summary>
        [NameInMap("CordonParameters")]
        [Validation(Required=false)]
        public NodeCordonParameters CordonParameters { get; set; }

        /// <summary>
        /// <para>The parameter settings for draining task instances from a node.</para>
        /// </summary>
        [NameInMap("DrainParameters")]
        [Validation(Required=false)]
        public NodeDrainParameters DrainParameters { get; set; }

        /// <summary>
        /// <para>The parameters for changing disk capacity.</para>
        /// </summary>
        [NameInMap("ResizeDiskParameters")]
        [Validation(Required=false)]
        public ResizeDiskParameters ResizeDiskParameters { get; set; }

        /// <summary>
        /// <para>The parameter settings for enabling node scheduling.</para>
        /// </summary>
        [NameInMap("UncordonParameters")]
        [Validation(Required=false)]
        public NodeUncordonParameters UncordonParameters { get; set; }

    }

}
