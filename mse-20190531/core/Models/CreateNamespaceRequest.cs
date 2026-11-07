// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class CreateNamespaceRequest : TeaModel {
        /// <summary>
        /// <para>The language in which you want the results to be displayed. Valid values: zh (default): Chinese. en: English</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The description of the namespace that you want to create for Microservices Governance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test namespace 1.</para>
        /// </summary>
        [NameInMap("Describe")]
        [Validation(Required=false)]
        public string Describe { get; set; }

        /// <summary>
        /// <para>The name of the namespace that you want to create for Microservices Governance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myNamespace</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The tag.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateNamespaceRequestTag> Tag { get; set; }
        public class CreateNamespaceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource. You cannot specify an empty string as a tag key. The tag key can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain http\:// or https\://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>namespaceTagKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>namespaceTagValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
