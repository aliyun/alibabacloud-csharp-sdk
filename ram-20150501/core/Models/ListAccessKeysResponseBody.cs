// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ram20150501.Models
{
    public class ListAccessKeysResponseBody : TeaModel {
        /// <summary>
        /// <para>The AccessKey pairs that belong to the RAM user.</para>
        /// </summary>
        [NameInMap("AccessKeys")]
        [Validation(Required=false)]
        public ListAccessKeysResponseBodyAccessKeys AccessKeys { get; set; }
        public class ListAccessKeysResponseBodyAccessKeys : TeaModel {
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public List<ListAccessKeysResponseBodyAccessKeysAccessKey> AccessKey { get; set; }
            public class ListAccessKeysResponseBodyAccessKeysAccessKey : TeaModel {
                /// <summary>
                /// <para>The AccessKey ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0wNEpMMlzy7s****</para>
                /// </summary>
                [NameInMap("AccessKeyId")]
                [Validation(Required=false)]
                public string AccessKeyId { get; set; }

                /// <summary>
                /// <para>The time when the AccessKey pair was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-01-23T12:33:18Z</para>
                /// </summary>
                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                /// <summary>
                /// <para>The status of the AccessKey pair. Valid values: Active and Inactive.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4B450CA1-36E8-4AA2-8461-86B42BF4CC4E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
