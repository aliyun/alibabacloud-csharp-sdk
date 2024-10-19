// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class RemoveVpcAccessResponseBody : TeaModel {
        /// <summary>
        /// <para>API operations</para>
        /// </summary>
        [NameInMap("Apis")]
        [Validation(Required=false)]
        public RemoveVpcAccessResponseBodyApis Apis { get; set; }
        public class RemoveVpcAccessResponseBodyApis : TeaModel {
            [NameInMap("Api")]
            [Validation(Required=false)]
            public List<RemoveVpcAccessResponseBodyApisApi> Api { get; set; }
            public class RemoveVpcAccessResponseBodyApisApi : TeaModel {
                /// <summary>
                /// <para>API Id</para>
                /// 
                /// <b>Example:</b>
                /// <para>551877242a4b4f3a84a56b7c3570e4a7</para>
                /// </summary>
                [NameInMap("ApiId")]
                [Validation(Required=false)]
                public string ApiId { get; set; }

                /// <summary>
                /// <para>The ID of the API group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>78d54ac4424d4b1792e33ca35637e8e4</para>
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// <para>The ID of the runtime environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>d1e1ee28f9fb4b729db0ee8ca76ff0a5</para>
                /// </summary>
                [NameInMap("StageId")]
                [Validation(Required=false)]
                public string StageId { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BZ015</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
