// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieoauth2_1_0.Models
{
    public class GetUserBasicInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://xxxxxx">https://xxxxxx</a></para>
        /// </summary>
        [NameInMap("AvatarUrl")]
        [Validation(Required=false)]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxxx</para>
        /// </summary>
        [NameInMap("Nickname")]
        [Validation(Required=false)]
        public string Nickname { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3hPPBd9YuhfJQCzZ/07AAWdoO3K8zCb/KAqW96zPHXPiFkzjB/JfcWuuFHQQDaGZ4wVbNMV6wYuj075p/rhVLg==</para>
        /// </summary>
        [NameInMap("OpenId")]
        [Validation(Required=false)]
        public string OpenId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4070039E-5822-1F32-9295-1D2883E48BA5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UnionIds")]
        [Validation(Required=false)]
        public List<GetUserBasicInfoResponseBodyUnionIds> UnionIds { get; set; }
        public class GetUserBasicInfoResponseBodyUnionIds : TeaModel {
            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            [NameInMap("UnionId")]
            [Validation(Required=false)]
            public string UnionId { get; set; }

        }

    }

}
