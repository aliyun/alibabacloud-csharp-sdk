// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class InstallClusterAddonsRequest : TeaModel {
        /// <summary>
        /// <para>请求体参数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>ags-metrics-collector</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public List<InstallClusterAddonsRequestBody> Body { get; set; }
        public class InstallClusterAddonsRequestBody : TeaModel {
            /// <summary>
            /// <para>组件自定义参数，使用JSON字符串编码。</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;IngressDashboardEnabled\&quot;:\&quot;true\&quot;,\&quot;sls_project_name\&quot;:\&quot;your_sls_project_name\&quot;}</para>
            /// </summary>
            [NameInMap("config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>组件名称。您可以通过<a href="https://help.aliyun.com/document_detail/2667939.html">ListAddons</a>接口查询可用组件的信息，包括组件名称及版本等。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>logtail-ds</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>组件版本。您可以通过<a href="https://help.aliyun.com/document_detail/2667939.html">ListAddons</a>接口查询可用组件的信息，包括组件名称及版本等。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1.7.3.0-aliyun</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

    }

}
