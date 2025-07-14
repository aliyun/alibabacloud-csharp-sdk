// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class ListUsersInRecycleBinResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the response is truncated. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTruncated")]
        [Validation(Required=false)]
        public bool? IsTruncated { get; set; }

        /// <summary>
        /// <para>The parameter that is used to obtain the truncated part. It takes effect only when <c>IsTruncated</c> is set to <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXAMPLE</para>
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3687BD52-49FD-585B-AB14-CD05B7C76963</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the RAM users.</para>
        /// </summary>
        [NameInMap("Users")]
        [Validation(Required=false)]
        public ListUsersInRecycleBinResponseBodyUsers Users { get; set; }
        public class ListUsersInRecycleBinResponseBodyUsers : TeaModel {
            [NameInMap("User")]
            [Validation(Required=false)]
            public List<ListUsersInRecycleBinResponseBodyUsersUser> User { get; set; }
            public class ListUsersInRecycleBinResponseBodyUsersUser : TeaModel {
                /// <summary>
                /// <para>The time when the RAM user was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-12T09:12:00Z</para>
                /// </summary>
                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                /// <summary>
                /// <para>The time when the RAM user will be permanently deleted from the recycle bin.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-11-15T09:12:00Z</para>
                /// </summary>
                [NameInMap("DeleteDate")]
                [Validation(Required=false)]
                public string DeleteDate { get; set; }

                /// <summary>
                /// <para>The display name of the RAM user.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:test@example.onaliyun.com">test@example.onaliyun.com</a></para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The time when the RAM user was deleted and moved to the recycle bin.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-15T09:12:00Z</para>
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

}
