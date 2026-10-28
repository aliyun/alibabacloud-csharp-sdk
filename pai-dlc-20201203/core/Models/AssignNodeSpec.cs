// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class AssignNodeSpec : TeaModel {
        /// <summary>
        /// <para>The list of hyper nodes to avoid during scheduling.</para>
        /// </summary>
        [NameInMap("AntiAffinityHyperNodes")]
        [Validation(Required=false)]
        public List<HyperNodeSpec> AntiAffinityHyperNodes { get; set; }

        /// <summary>
        /// <para>AntiAffinityNodeNames</para>
        /// 
        /// <b>Example:</b>
        /// <para>lingjxxxxxxxx</para>
        /// </summary>
        [NameInMap("AntiAffinityNodeNames")]
        [Validation(Required=false)]
        public string AntiAffinityNodeNames { get; set; }

        /// <summary>
        /// <para>EnableAssignNode</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableAssignNode")]
        [Validation(Required=false)]
        public bool? EnableAssignNode { get; set; }

        /// <summary>
        /// <para>The list of hyper nodes to schedule to.</para>
        /// </summary>
        [NameInMap("HyperNodes")]
        [Validation(Required=false)]
        public List<HyperNodeSpec> HyperNodes { get; set; }

        /// <summary>
        /// <para>NodeNames</para>
        /// 
        /// <b>Example:</b>
        /// <para>lingjxxxxxxxx</para>
        /// </summary>
        [NameInMap("NodeNames")]
        [Validation(Required=false)]
        public string NodeNames { get; set; }

    }

}
