// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class GrantSagInstanceToCcnResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the permission policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sgc-6z21oj0vjjrx6s****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6E1674AC-083C-4031-B047-7A66E418E0C6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
