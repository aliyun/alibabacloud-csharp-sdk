// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateMonitorGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the API group. This ID is generated by the system and is unique globally.</para>
        /// 
        /// <b>Example:</b>
        /// <para>187421794</para>
        /// </summary>
        [NameInMap("MonitorGroupId")]
        [Validation(Required=false)]
        public long? MonitorGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5D7136F7-9D67-5D4D-8418-6A512CCEE3A2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
