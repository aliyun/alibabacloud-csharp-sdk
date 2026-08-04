// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListForwardStrategiesRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page in paging query. Valid values: 1 to 10000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of access destination instance IDs.</para>
        /// </summary>
        [NameInMap("DestinationIds")]
        [Validation(Required=false)]
        public List<string> DestinationIds { get; set; }

        /// <summary>
        /// <para>The type of the access destination. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Connector</b>: connector.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Connector</para>
        /// </summary>
        [NameInMap("DestinationType")]
        [Validation(Required=false)]
        public string DestinationType { get; set; }

        /// <summary>
        /// <para>The list of forwarding rule IDs.</para>
        /// </summary>
        [NameInMap("ForwardIds")]
        [Validation(Required=false)]
        public List<string> ForwardIds { get; set; }

        /// <summary>
        /// <para>The name of the forwarding rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs_rand_str_acs</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of entries per page in paging query. Valid values: 1 to 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

    }

}
