// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class EnableEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The type of the endpoint. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>public</b>: indicates a public endpoint. (Only public endpoint is supported.)</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

    }

}
