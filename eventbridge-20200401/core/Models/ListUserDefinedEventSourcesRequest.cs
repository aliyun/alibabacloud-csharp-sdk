// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListUserDefinedEventSourcesRequest : TeaModel {
        /// <summary>
        /// <para>The name of the event bus.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testBus</para>
        /// </summary>
        [NameInMap("EventBusName")]
        [Validation(Required=false)]
        public string EventBusName { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return per request. You can use this parameter with NextToken to paginate results. The maximum value is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// <para>The prefix of the event source name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("NamePrefix")]
        [Validation(Required=false)]
        public string NamePrefix { get; set; }

        /// <summary>
        /// <para>The token returned when Limit is specified and additional results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
