// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateDriveResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The value 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The user-level storage resource.</para>
        /// </summary>
        [NameInMap("Drive")]
        [Validation(Required=false)]
        public CreateDriveResponseBodyDrive Drive { get; set; }
        public class CreateDriveResponseBodyDrive : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1202****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public string AliUid { get; set; }

            /// <summary>
            /// <para>The description of the storage resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test****</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the storage resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dom-aaaa****</para>
            /// </summary>
            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            /// <summary>
            /// <para>The ID of the user-level storage resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dri-aaaa****</para>
            /// </summary>
            [NameInMap("DriveId")]
            [Validation(Required=false)]
            public string DriveId { get; set; }

            /// <summary>
            /// <para>The ID of the external user-level storage resource.</para>
            /// <remarks>
            /// <para> A value is returned for this parameter only if ResourceType is set to PDS.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1100****</para>
            /// </summary>
            [NameInMap("ExternalDriveId")]
            [Validation(Required=false)]
            public string ExternalDriveId { get; set; }

            /// <summary>
            /// <para>The ID of the external user.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:user01@cn-hangzhou.120">user01@cn-hangzhou.120</a>****</para>
            /// </summary>
            [NameInMap("ExternalUserId")]
            [Validation(Required=false)]
            public string ExternalUserId { get; set; }

            /// <summary>
            /// <para>The time when the storage resource was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-02T08:42:26.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the storage resource was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-07T02:46:04.000+00:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the storage resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test****</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is deprecated.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("ProfileRoaming")]
            [Validation(Required=false)]
            public bool? ProfileRoaming { get; set; }

            /// <summary>
            /// <para>The status of the user-level storage resource.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>INIT: initializing</description></item>
            /// <item><description>MAINTAIN: maintaining</description></item>
            /// <item><description>DELETING</description></item>
            /// <item><description>INVALID</description></item>
            /// <item><description>NORMAL</description></item>
            /// <item><description>FAIL: failed</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The total amount of the user-level storage resource capacity.</para>
            /// <remarks>
            /// <para> Unit: bytes.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>536870912000</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

            /// <summary>
            /// <para>The usage of the storage resource.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>DESKTOP: data disk space</description></item>
            /// <item><description>USER_PROFILE: space for personal data of the user</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>USER_PROFILE</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The amount of user-level storage resource capacity used.</para>
            /// <remarks>
            /// <para> Unit: bytes.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>243175936</para>
            /// </summary>
            [NameInMap("UsedSize")]
            [Validation(Required=false)]
            public long? UsedSize { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user01</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B7AA****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
