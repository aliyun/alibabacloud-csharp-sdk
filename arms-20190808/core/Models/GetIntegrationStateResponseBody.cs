// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetIntegrationStateResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. 200 means success, other status codes are exceptions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The prompt information of the returned result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A9C645C-C83F-4C9D-8CCB-29BEC9E1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The integration state of Prometheus dashboards and collection rules. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The Prometheus dashboards and collection rules that monitor the software are integrated.</description></item>
        /// <item><description><c>false</c>: The Prometheus dashboards and collection rules that monitor the software are not integrated.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public bool? State { get; set; }

    }

}
