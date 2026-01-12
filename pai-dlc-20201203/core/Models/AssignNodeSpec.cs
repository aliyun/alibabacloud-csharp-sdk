// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class AssignNodeSpec : TeaModel {
        [NameInMap("AntiAffinityHyperNodes")]
        [Validation(Required=false)]
        public List<HyperNodeSpec> AntiAffinityHyperNodes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>lingjxxxxxxxx</para>
        /// </summary>
        [NameInMap("AntiAffinityNodeNames")]
        [Validation(Required=false)]
        public string AntiAffinityNodeNames { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAssignNode")]
        [Validation(Required=false)]
        public bool? EnableAssignNode { get; set; }

        [NameInMap("HyperNodes")]
        [Validation(Required=false)]
        public List<HyperNodeSpec> HyperNodes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>lingjxxxxxxxx</para>
        /// </summary>
        [NameInMap("NodeNames")]
        [Validation(Required=false)]
        public string NodeNames { get; set; }

    }

}
