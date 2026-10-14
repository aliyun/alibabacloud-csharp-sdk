// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeHistoryEventsRequest : TeaModel {
        /// <summary>
        /// <para>The list of event levels.</para>
        /// </summary>
        [NameInMap("EventLevels")]
        [Validation(Required=false)]
        public List<string> EventLevels { get; set; }

        /// <summary>
        /// <para>The list of event statuses.</para>
        /// </summary>
        [NameInMap("EventStatus")]
        [Validation(Required=false)]
        public List<string> EventStatus { get; set; }

        /// <summary>
        /// <para>The list of event types.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EventTypes")]
        [Validation(Required=false)]
        public List<string> EventTypes { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of resource IDs.</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public List<string> ResourceIds { get; set; }

    }

}
