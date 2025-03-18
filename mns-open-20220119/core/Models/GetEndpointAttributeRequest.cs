// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class GetEndpointAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The type of the endpoint. Value:</para>
        /// <list type="bullet">
        /// <item><description><b>public</b>: indicates public endpoint. (Only the public is supported.)</description></item>
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
