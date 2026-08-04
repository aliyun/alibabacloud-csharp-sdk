// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetActiveIdpConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The identity provider configuration.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetActiveIdpConfigResponseBodyData Data { get; set; }
        public class GetActiveIdpConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A description of the identity provider configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例身份源</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the identity provider configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>idp-cfg001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the identity provider configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试身份源</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The type of the identity provider configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DingTalk</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4D169859-A4F2-5EC8-853B-8447787C0D8A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
