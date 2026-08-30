// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class GetSaseUserTagResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2CABFEBB-0CE7-575E-833A-266F75D46713</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The user tag response body.</para>
        /// </summary>
        [NameInMap("SaseUserTag")]
        [Validation(Required=false)]
        public GetSaseUserTagResponseBodySaseUserTag SaseUserTag { get; set; }
        public class GetSaseUserTagResponseBodySaseUserTag : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>141681795035****</para>
            /// </summary>
            [NameInMap("Aliuid")]
            [Validation(Required=false)]
            public string Aliuid { get; set; }

            /// <summary>
            /// <para>The user tag description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>These are the company\&quot;s employees</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The user tag name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>boss</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The user tag ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>su-tag-1ae52f66039fa0d4****</para>
            /// </summary>
            [NameInMap("TagId")]
            [Validation(Required=false)]
            public string TagId { get; set; }

        }

    }

}
