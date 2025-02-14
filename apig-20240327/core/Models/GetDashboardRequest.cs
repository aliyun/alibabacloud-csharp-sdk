// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetDashboardRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("acceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        [NameInMap("apiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        [NameInMap("filter")]
        [Validation(Required=false)]
        public GetDashboardRequestFilter Filter { get; set; }
        public class GetDashboardRequestFilter : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>test-route</para>
            /// </summary>
            [NameInMap("routeName")]
            [Validation(Required=false)]
            public string RouteName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PLUGIN</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pls-dn82a9djd8z****</para>
        /// </summary>
        [NameInMap("pluginClassId")]
        [Validation(Required=false)]
        public string PluginClassId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SLS</para>
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

    }

}
