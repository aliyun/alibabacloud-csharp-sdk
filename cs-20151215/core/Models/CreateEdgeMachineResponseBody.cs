// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class CreateEdgeMachineResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud-native box.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc0725ddf688744979cd98445f67e****</para>
        /// </summary>
        [NameInMap("edge_machine_id")]
        [Validation(Required=false)]
        public string EdgeMachineId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;request_id&quot;: &quot;6e7b377a-c5ed-4388-8026-689e1b34****&quot;,</para>
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
