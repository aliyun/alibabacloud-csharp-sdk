// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DeleteTraceAppResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The response in JSON format, including the HTTP status code, error code, response message, and trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{\\&quot;code\\&quot;:200,\\&quot;data\\&quot;:\\&quot;{\\\\\&quot;code\\\\\&quot;:200,\\\\\&quot;data\\\\\&quot;:true,\\\\\&quot;errorCode\\\\\&quot;:\\\\\&quot;The application is deleted\\\\\&quot;,\\\\\&quot;message\\\\\&quot;:\\\\\&quot;The application is deleted\\\\\&quot;,\\\\\&quot;success\\\\\&quot;:true,\\\\\&quot;traceId\\\\\&quot;:\\\\\&quot;0bc0594d15954826692915817e\<em>\</em>\<em>\</em>\\\\\&quot;}\\&quot;,\\&quot;errorCode\\&quot;:\\&quot;The application is deleted\\&quot;,\\&quot;message\\&quot;:\\&quot;The application is deleted\\&quot;,\\&quot;success\\&quot;:true,\\&quot;traceId\\&quot;:\\&quot;0ab2646915954826692568137d\<em>\</em>\<em>\</em>\\&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internal error. Please try again. Contact the DingTalk service account if the issue                              persists after multiple retries.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46355DD8-FC56-40C5-BFC6-269DE4F9****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <para>true: The request was successful.</para>
        /// <para>false: The request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
