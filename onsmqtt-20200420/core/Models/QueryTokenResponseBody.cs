// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OnsMqtt20200420.Models
{
    public class QueryTokenResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique ID that the system generates for the request. This parameter is a common parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5C8AADD0-6A95-436D-AFA0-3405CCE3****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the queried token. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: indicates the token is valid.</description></item>
        /// <item><description><b>false</b>: indicates the token is invalid.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("TokenStatus")]
        [Validation(Required=false)]
        public bool? TokenStatus { get; set; }

    }

}
