// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetUserInRecycleBinResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4507D1CD-526A-4E2B-A1E2-3AB045D1EE0B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the RAM user.</para>
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public GetUserInRecycleBinResponseBodyUser User { get; set; }
        public class GetUserInRecycleBinResponseBodyUser : TeaModel {
            /// <summary>
            /// <para>The time when the RAM user was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-11T09:12:00Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The time when the RAM user will be permanently deleted from the recycle bin.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-11-12T09:12:00Z</para>
            /// </summary>
            [NameInMap("DeleteDate")]
            [Validation(Required=false)]
            public string DeleteDate { get; set; }

            /// <summary>
            /// <para>The display name of the RAM user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The time when the RAM user was deleted and moved to the recycle bin.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-10-12T09:12:00Z</para>
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

        }

    }

}
