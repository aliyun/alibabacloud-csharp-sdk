// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeResourcesDeleteProtectionResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("statusCode")]
        [Validation(Required=false)]
        public int? StatusCode { get; set; }

        [NameInMap("body")]
        [Validation(Required=false)]
        public List<DescribeResourcesDeleteProtectionResponseBody> Body { get; set; }
        public class DescribeResourcesDeleteProtectionResponseBody : TeaModel {
            /// <summary>
            /// <para>The name of the resource.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace to which the resource belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The type of resource for which deletion protection is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>namespaces</para>
            /// </summary>
            [NameInMap("resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// <para>Indicates whether deletion protection is enabled.</para>
            /// <list type="bullet">
            /// <item><description>true: deletion protection is enabled.</description></item>
            /// <item><description>false: deletion protection is disabled.</description></item>
            /// </list>
            /// <para>Default value: false</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("protection")]
            [Validation(Required=false)]
            public bool? Protection { get; set; }

        }

    }

}
