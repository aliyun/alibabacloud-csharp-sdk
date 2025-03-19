// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetDashboardRequest : TeaModel {
        /// <summary>
        /// <para>zh: Chinese
        /// en: English</para>
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
        /// <para>Filter configuration</para>
        /// </summary>
        [NameInMap("filter")]
        [Validation(Required=false)]
        public GetDashboardRequestFilter Filter { get; set; }
        public class GetDashboardRequestFilter : TeaModel {
            /// <summary>
            /// <para>Route name</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-route</para>
            /// </summary>
            [NameInMap("routeName")]
            [Validation(Required=false)]
            public string RouteName { get; set; }

        }

        /// <summary>
        /// <para>Dashboard name:</para>
        /// <list type="bullet">
        /// <item><description>LOG: Access log</description></item>
        /// <item><description>PLUGIN: Plugin log</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PLUGIN</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Plugin ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pls-dn82a9djd8z****</para>
        /// </summary>
        [NameInMap("pluginClassId")]
        [Validation(Required=false)]
        public string PluginClassId { get; set; }

        /// <summary>
        /// <para>Dashboard source:</para>
        /// <list type="bullet">
        /// <item><description>SLS: Log dashboard</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SLS</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
