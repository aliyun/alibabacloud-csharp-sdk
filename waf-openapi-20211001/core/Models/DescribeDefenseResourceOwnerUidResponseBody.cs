// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDefenseResourceOwnerUidResponseBody : TeaModel {
        [NameInMap("OwnerInfos")]
        [Validation(Required=false)]
        public List<DescribeDefenseResourceOwnerUidResponseBodyOwnerInfos> OwnerInfos { get; set; }
        public class DescribeDefenseResourceOwnerUidResponseBodyOwnerInfos : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>125************21</para>
            /// </summary>
            [NameInMap("OwnerUserId")]
            [Validation(Required=false)]
            public string OwnerUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a.com-waf</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7326952B-B83B-5B7C-84FA-77F3E17310A2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
