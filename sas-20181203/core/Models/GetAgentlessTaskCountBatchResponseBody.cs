// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAgentlessTaskCountBatchResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistics grouped by resource UUID. The key of the map is the resource UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;3bb30859-b3b5-4f28-868f-b0892c98****&quot;:{&quot;RiskMachine&quot;:1,&quot;ScanMachine&quot;:1}}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public Dictionary<string, DataValue> Data { get; set; }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D03DD0FD-6041-5107-AC00-383E28F1****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
