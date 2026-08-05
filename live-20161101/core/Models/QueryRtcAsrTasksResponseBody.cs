// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class QueryRtcAsrTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the result. A value of \<c>success\\</c> indicates that the call is successful. If the call fails, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D8ADAB55-1BB8-5C01-8434-C45D353BB1FD</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status code. A value of 2000 indicates that the call is successful. Other values indicate that an error occurred.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("RetCode")]
        [Validation(Required=false)]
        public long? RetCode { get; set; }

        /// <summary>
        /// <para>The result set of tasks.</para>
        /// </summary>
        [NameInMap("Tasks")]
        [Validation(Required=false)]
        public Dictionary<string, object> Tasks { get; set; }

    }

}
