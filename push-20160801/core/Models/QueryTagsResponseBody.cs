// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Push20160801.Models
{
    public class QueryTagsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>D68AE5C6-8AAF-46C9-B627-3FDACD1A4168</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TagInfos")]
        [Validation(Required=false)]
        public QueryTagsResponseBodyTagInfos TagInfos { get; set; }
        public class QueryTagsResponseBodyTagInfos : TeaModel {
            [NameInMap("TagInfo")]
            [Validation(Required=false)]
            public List<QueryTagsResponseBodyTagInfosTagInfo> TagInfo { get; set; }
            public class QueryTagsResponseBodyTagInfosTagInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test_tag2</para>
                /// </summary>
                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

        }

    }

}
