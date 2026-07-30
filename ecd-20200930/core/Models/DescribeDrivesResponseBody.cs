// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDrivesResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        /// <summary>
        /// <para>The list of user-level storage resources.</para>
        /// </summary>
        [NameInMap("Drives")]
        [Validation(Required=false)]
        public List<DescribeDrivesResponseBodyDrives> Drives { get; set; }
        public class DescribeDrivesResponseBodyDrives : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1202****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The storage resource description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test****</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The number of associated cloud computer pools.</para>
            /// <remarks>
            /// <para>This parameter is returned only when the storage resource is NAS and the purpose is USER_PROFILE.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DesktopGroupCount")]
            [Validation(Required=false)]
            public int? DesktopGroupCount { get; set; }

            /// <summary>
            /// <para>The list of associated cloud computer pool details.</para>
            /// <remarks>
            /// <para>This parameter is returned only when the storage resource is NAS and the purpose is USER_PROFILE.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("DesktopGroups")]
            [Validation(Required=false)]
            public List<DescribeDrivesResponseBodyDrivesDesktopGroups> DesktopGroups { get; set; }
            public class DescribeDrivesResponseBodyDrivesDesktopGroups : TeaModel {
                /// <summary>
                /// <para>The cloud computer pool ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dg-aaaa****</para>
                /// </summary>
                [NameInMap("DesktopGroupId")]
                [Validation(Required=false)]
                public string DesktopGroupId { get; set; }

                /// <summary>
                /// <para>The cloud computer pool name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>group01</para>
                /// </summary>
                [NameInMap("DesktopGroupName")]
                [Validation(Required=false)]
                public string DesktopGroupName { get; set; }

            }

            /// <summary>
            /// <para>The storage resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dom-aaaa****</para>
            /// </summary>
            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            /// <summary>
            /// <para>The user-level storage resource ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dri-aaaa****</para>
            /// </summary>
            [NameInMap("DriveId")]
            [Validation(Required=false)]
            public string DriveId { get; set; }

            /// <summary>
            /// <para>Indicates whether the User Profile Management (UPM) feature is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableProfileManagement")]
            [Validation(Required=false)]
            public bool? EnableProfileManagement { get; set; }

            /// <summary>
            /// <para>The external storage resource ID.</para>
            /// <list type="bullet">
            /// <item><description>If the storage resource is NAS, this parameter returns the NAS ID.</description></item>
            /// <item><description>If the storage resource is PDS, this parameter returns the PDS ID.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0976****</para>
            /// </summary>
            [NameInMap("ExternalDomainId")]
            [Validation(Required=false)]
            public string ExternalDomainId { get; set; }

            /// <summary>
            /// <para>The external user-level storage resource ID.</para>
            /// <remarks>
            /// <para>This parameter is returned only when the storage resource is PDS.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1100****</para>
            /// </summary>
            [NameInMap("ExternalDriveId")]
            [Validation(Required=false)]
            public string ExternalDriveId { get; set; }

            /// <summary>
            /// <para>The external user ID.</para>
            /// <remarks>
            /// <para>This parameter is returned only when the storage resource is PDS.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="mailto:user01@cn-hangzhou.120">user01@cn-hangzhou.120</a>****</para>
            /// </summary>
            [NameInMap("ExternalUserId")]
            [Validation(Required=false)]
            public string ExternalUserId { get; set; }

            /// <summary>
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-02T08:42:26.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-07T02:46:04.000+00:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ID.</para>
            /// <remarks>
            /// <para>You can ignore this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The storage resource name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test****</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <remarks>
            /// <para>This parameter is deprecated.</para>
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
            /// 
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The total capacity of the user-level storage resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>536870912000</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

            /// <summary>
            /// <para>The purpose of the storage resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER_PROFILE</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The used capacity of the user-level storage resource.</para>
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
        /// <para>The pagination token for the next query. An empty value indicates that there are no more results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAA****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
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
