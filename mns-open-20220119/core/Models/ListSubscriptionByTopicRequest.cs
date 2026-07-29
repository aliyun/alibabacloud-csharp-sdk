// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mns_open20220119.Models
{
    public class ListSubscriptionByTopicRequest : TeaModel {
        [NameInMap("EndpointType")]
        [Validation(Required=false)]
        public string EndpointType { get; set; }

        [NameInMap("EndpointValue")]
        [Validation(Required=false)]
        public string EndpointValue { get; set; }

        /// <summary>
        /// <para>The page number of the results to return.
        /// Valid values: 1 to 100000000.
        /// If the value is less than 1, the system uses 1. If the value is greater than 100000000, the system uses 100000000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.
        /// Valid values: 10 to 50.
        /// If the value is less than 10, the system uses 10. If the value is greater than 50, the system uses 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The subscription name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo-subscription</para>
        /// </summary>
        [NameInMap("SubscriptionName")]
        [Validation(Required=false)]
        public string SubscriptionName { get; set; }

        /// <summary>
        /// <para>The topic name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("TopicName")]
        [Validation(Required=false)]
        public string TopicName { get; set; }

    }

}
