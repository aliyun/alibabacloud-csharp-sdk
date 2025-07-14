// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListAccessKeysInRecycleBinResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the AccessKey pairs.</para>
        /// </summary>
        [NameInMap("AccessKeys")]
        [Validation(Required=false)]
        public ListAccessKeysInRecycleBinResponseBodyAccessKeys AccessKeys { get; set; }
        public class ListAccessKeysInRecycleBinResponseBodyAccessKeys : TeaModel {
            [NameInMap("AccessKey")]
            [Validation(Required=false)]
            public List<ListAccessKeysInRecycleBinResponseBodyAccessKeysAccessKey> AccessKey { get; set; }
            public class ListAccessKeysInRecycleBinResponseBodyAccessKeysAccessKey : TeaModel {
                /// <summary>
                /// <para>The AccessKey ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LTAI*******************</para>
                /// </summary>
                [NameInMap("AccessKeyId")]
                [Validation(Required=false)]
                public string AccessKeyId { get; set; }

                /// <summary>
                /// <para>The time when the AccessKey pair was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-11T09:12:00Z</para>
                /// </summary>
                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                /// <summary>
                /// <para>The time when the AccessKey pair will be permanently deleted from the recycle bin.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-11-12T09:12:00Z</para>
                /// </summary>
                [NameInMap("DeleteDate")]
                [Validation(Required=false)]
                public string DeleteDate { get; set; }

                /// <summary>
                /// <para>The time when the AccessKey pair was deleted and moved to the recycle bin.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-12T09:12:00Z</para>
                /// </summary>
                [NameInMap("RecycleDate")]
                [Validation(Required=false)]
                public string RecycleDate { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4507D1CD-526A-4E2B-A1E2-3AB045D1EE0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
