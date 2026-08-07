// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class ListScriptProfileTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>实例ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>NLU引擎类型</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEEBOT</para>
        /// </summary>
        [NameInMap("NluEngine")]
        [Validation(Required=false)]
        public string NluEngine { get; set; }

    }

}
