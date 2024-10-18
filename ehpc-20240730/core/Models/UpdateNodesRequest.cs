// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class UpdateNodesRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The information about the compute nodes that you want to update.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<UpdateNodesRequestInstances> Instances { get; set; }
        public class UpdateNodesRequestInstances : TeaModel {
            /// <summary>
            /// <para>The instance ID of the compute node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1bzqq1ddeemuddn****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable deletion protection for the compute node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("KeepAlive")]
            [Validation(Required=false)]
            public bool? KeepAlive { get; set; }

        }

    }

}
