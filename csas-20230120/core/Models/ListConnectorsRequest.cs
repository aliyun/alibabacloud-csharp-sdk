// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListConnectorsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the connectors. You can enter up to 100 connector IDs.</para>
        /// </summary>
        [NameInMap("ConnectorIds")]
        [Validation(Required=false)]
        public List<string> ConnectorIds { get; set; }

        /// <summary>
        /// <para>The page number of the current page for paging in a paged query. Valid values: 1 to 10000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The name of the connector. The name must be 1 to 128 characters in length, and can contain Chinese characters, uppercase and lowercase letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>connector_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The Settings for the number of entries per page for paging in a paged query. Valid values: 1 to 1000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The connection status of the connector. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Online</b>: online.</description></item>
        /// <item><description><b>Offline</b>: offline.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Online</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The instance status of the connector. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enabled</b>: enabled.</description></item>
        /// <item><description><b>Disabled</b>: shutdown.</description></item>
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
