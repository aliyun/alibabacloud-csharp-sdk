// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class EdgeClusterAddEdgeMachineResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud-native box.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0f4bf70a-caff-4b26-a679-fb0188a1****</para>
        /// </summary>
        [NameInMap("edge_machine_id")]
        [Validation(Required=false)]
        public string EdgeMachineId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0adf3a23-6841-41e8-9f55-7b290216c980</para>
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
