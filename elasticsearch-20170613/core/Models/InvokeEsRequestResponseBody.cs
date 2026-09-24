// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class InvokeEsRequestResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>8E5A2C41-D96B-4308-AF72-5C0B14E6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The response content returned as-is from ES. The structure is determined by the ES API being called.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;esResult&quot;:{&quot;took&quot;:5,&quot;timed_out&quot;:false,&quot;hits&quot;:{&quot;total&quot;:{&quot;value&quot;:1,&quot;relation&quot;:&quot;eq&quot;},&quot;max_score&quot;:1.0,&quot;hits&quot;:[{&quot;_index&quot;:&quot;my-index&quot;,&quot;_id&quot;:&quot;1&quot;,&quot;_score&quot;:1.0,&quot;_source&quot;:{&quot;title&quot;:&quot;Wireless Bluetooth Headphones&quot;}}]}}}</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public object Result { get; set; }

    }

}
