// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class CCMVersionsValue : TeaModel {
        /// <summary>
        /// <para>The status of the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>time_out</c>: The query times out.</description></item>
        /// <item><description><c>failed</c>: The query fails.</description></item>
        /// <item><description><c>Empty string</c>: The query is successful.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>time_out</para>
        /// </summary>
        [NameInMap("QueryState")]
        [Validation(Required=false)]
        public string QueryState { get; set; }

        /// <summary>
        /// <para>The CCM version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2.0.1</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>Indicates whether Classic Load Balancer (CLB) graceful shutdown is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SLBGracefulDrainSupported")]
        [Validation(Required=false)]
        public bool? SLBGracefulDrainSupported { get; set; }

        /// <summary>
        /// <para>The ID of the cluster instance on the data plane.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cfbb81b9b51a44b299349xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The additional information that is returned when the query fails. This parameter is empty if the query is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>timeout error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <term><b>Obsolete</b></term>
        [NameInMap("SLBGracefulDrainSupport")]
        [Validation(Required=false)]
        [Obsolete]
        public bool? SLBGracefulDrainSupport { get; set; }

    }

}
