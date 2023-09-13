// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eventbridge20200401.Models
{
    public class ListEventStreamingsRequest : TeaModel {
        /// <summary>
        /// The maximum number of entries to be returned in a call. You can use this parameter and NextToken to implement paging. A maximum of 100 entries can be returned in a call.
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The name of the event stream that you want to query.
        /// </summary>
        [NameInMap("NamePrefix")]
        [Validation(Required=false)]
        public string NamePrefix { get; set; }

        /// <summary>
        /// If you configure Limit and excess return values exist, this parameter is returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ARN of the event target.
        /// </summary>
        [NameInMap("SinkArn")]
        [Validation(Required=false)]
        public string SinkArn { get; set; }

        /// <summary>
        /// The Alibaba Cloud Resource Name (ARN) of the event source.
        /// </summary>
        [NameInMap("SourceArn")]
        [Validation(Required=false)]
        public string SourceArn { get; set; }

    }

}
