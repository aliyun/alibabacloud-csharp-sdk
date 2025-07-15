// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class QueryRtcAsrTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The result of the request. If success is returned, the request was successful. If an error message is returned, the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D8ADAB55-1BB8-5C01-8434-C45D353BB1FD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The HTTP status code. HTTP status code 2000 indicates that the request was successful. Other HTTP status codes indicate that the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public long? RetCode { get; set; }

        /// <summary>
        /// <para>The results returned for the tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tasks { get; set; }

    }

}
