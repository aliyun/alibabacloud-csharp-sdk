// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetDashboardShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The language. Valid values: zh (Chinese) and en (English).</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("acceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>API ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-c9uuekzmia8q2****</para>
        /// </summary>
        [NameInMap("apiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// <para>The filter configurations.</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public string FilterShrink { get; set; }

        /// <summary>
        /// <para>The dashboard name.</para>
        /// <list type="bullet">
        /// <item><description>LOG: access logs</description></item>
        /// <item><description>PLUGIN: plug-in logs</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PLUGIN</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The plug-in type ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pls-dn82a9djd8z****</para>
        /// </summary>
        [NameInMap("pluginClassId")]
        [Validation(Required=false)]
        public string PluginClassId { get; set; }

        /// <summary>
        /// <para>The plug-in ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>inner-ai-search-cvd3mcum1hks660icn10</para>
        /// </summary>
        [NameInMap("pluginId")]
        [Validation(Required=false)]
        public string PluginId { get; set; }

        /// <summary>
        /// <para>The route ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>route-xxx</para>
        /// </summary>
        [NameInMap("routeId")]
        [Validation(Required=false)]
        public string RouteId { get; set; }

        /// <summary>
        /// <para>The dashboard source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SLS: Simple Log Service</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SLS</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The AI service identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>outbound|443||ds.ai</para>
        /// </summary>
        [NameInMap("upstreamCluster")]
        [Validation(Required=false)]
        public string UpstreamCluster { get; set; }

    }

}
