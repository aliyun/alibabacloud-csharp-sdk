// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetAccessKeyInfoInRecycleBinResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the AccessKey pair.</para>
        /// </summary>
        [NameInMap("AccessKey")]
        [Validation(Required=false)]
        public GetAccessKeyInfoInRecycleBinResponseBodyAccessKey AccessKey { get; set; }
        public class GetAccessKeyInfoInRecycleBinResponseBodyAccessKey : TeaModel {
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
            /// <para>2020-10-12T09:12:00Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The time when the AccessKey pair will be permanently deleted from the recycle bin.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-12T10:12:00Z</para>
            /// </summary>
            [NameInMap("DeleteDate")]
            [Validation(Required=false)]
            public string DeleteDate { get; set; }

            /// <summary>
            /// <para>The time when the AccessKey pair was deleted and moved to the recycle bin.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-12T10:12:00Z</para>
            /// </summary>
            [NameInMap("RecycleDate")]
            [Validation(Required=false)]
            public string RecycleDate { get; set; }

            /// <summary>
            /// <para>The ID of the RAM user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20732900249392****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The logon name of the RAM user.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:test@example.onaliyun.com">test@example.onaliyun.com</a></para>
            /// </summary>
            [NameInMap("UserPrincipalName")]
            [Validation(Required=false)]
            public string UserPrincipalName { get; set; }

            /// <summary>
            /// <para>Indicates whether the RAM user to which the AccessKey pair belongs is in the recycle bin. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true</description></item>
            /// <item><description>false</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UserRecycled")]
            [Validation(Required=false)]
            public bool? UserRecycled { get; set; }

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
