// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListConnectorsRequest : TeaModel {
        /// <summary>
        /// <para>Collection of Connector IDs. Up to 100 Connector IDs can be entered.</para>
        /// </summary>
        [NameInMap("ConnectorIds")]
        [Validation(Required=false)]
        public List<string> ConnectorIds { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paginated query. Range: 1~10000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Connector name. Length: 1~128 characters, supporting Chinese and both uppercase and lowercase English letters, and can include numbers, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>connector_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of items per page in a paginated query. Range: 1~1000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Connector connection status. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>Online</b>: Online.</description></item>
        /// <item><description><b>Offline</b>: Offline.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Online</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Connector instance status. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: Enabled.</description></item>
        /// <item><description><b>Disabled</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("SwitchStatus")]
        [Validation(Required=false)]
        public string SwitchStatus { get; set; }

    }

}
