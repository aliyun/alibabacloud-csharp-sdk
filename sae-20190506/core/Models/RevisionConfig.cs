// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class RevisionConfig : TeaModel {
        /// <summary>
        /// <para>The container configurations. You can deploy only one container for each application. The maximum length of this array is 1.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Containers")]
        [Validation(Required=false)]
        public List<Container> Containers { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Application Real-Time Monitoring Service (ARMS) monitoring. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b><c>true</c></b>: Enables the ARMS monitoring.</description></item>
        /// <item><description><b><c>false</c></b>: Disables the ARMS monitoring.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableArmsMetrics")]
        [Validation(Required=false)]
        public bool? EnableArmsMetrics { get; set; }

        /// <summary>
        /// <para>The network configurations.</para>
        /// <remarks>
        /// <para> This parameter is used to configure network settings for a version of the application.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("WebNetworkConfig")]
        [Validation(Required=false)]
        public WebNetworkConfig WebNetworkConfig { get; set; }

    }

}
