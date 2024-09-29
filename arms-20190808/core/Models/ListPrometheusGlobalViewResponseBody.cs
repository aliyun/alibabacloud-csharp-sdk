// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListPrometheusGlobalViewResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. Description 200 means success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The list of global aggregation instances. The value of this parameter is a string in the JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ {groupName: &quot;the name of the global aggregation instance&quot;, clusterId: &quot;global-v2-clusterid&quot;, endpoint: &quot;cn-hangzhou&quot;}, // ..... more items ]</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>More information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request. You can use the ID to query logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DBDCE95A-A0DD-5FC5-97CC-EEFC3D814385</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
