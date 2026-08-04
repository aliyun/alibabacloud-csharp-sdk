// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListConnectorsRequest : TeaModel {
        /// <summary>
        /// <para>An array of up to 100 ConnectorIDs.</para>
        /// </summary>
        [NameInMap("ConnectorIds")]
        [Validation(Required=false)]
        public List<string> ConnectorIds { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Valid values: 1 to 10,000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The name of the connector. The name must be 1 to 128 characters long and can contain letters, Chinese characters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>connector_name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 1,000.</para>
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
        /// <item><description><para><b>Online</b></para>
        /// </description></item>
        /// <item><description><para><b>Offline</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Online</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The state of the connector instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Enabled</b></para>
        /// </description></item>
        /// <item><description><para><b>Disabled</b></para>
        /// </description></item>
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
