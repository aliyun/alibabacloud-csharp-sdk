// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class GetTrafficControlTaskRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>All</para>
        /// </summary>
        [NameInMap("ControlTargetFilter")]
        [Validation(Required=false)]
        public string ControlTargetFilter { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Daily</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pairec-1324***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Latest</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
