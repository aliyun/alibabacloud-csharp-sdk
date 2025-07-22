// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeDrivesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("Drives")]
        [Validation(Required=false)]
        public List<DescribeDrivesResponseBodyDrives> Drives { get; set; }
        public class DescribeDrivesResponseBodyDrives : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1202****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test****</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("DesktopGroupCount")]
            [Validation(Required=false)]
            public int? DesktopGroupCount { get; set; }

            [NameInMap("DesktopGroups")]
            [Validation(Required=false)]
            public List<DescribeDrivesResponseBodyDrivesDesktopGroups> DesktopGroups { get; set; }
            public class DescribeDrivesResponseBodyDrivesDesktopGroups : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>dg-aaaa****</para>
                /// </summary>
                [NameInMap("DesktopGroupId")]
                [Validation(Required=false)]
                public string DesktopGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>group01</para>
                /// </summary>
                [NameInMap("DesktopGroupName")]
                [Validation(Required=false)]
                public string DesktopGroupName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dom-aaaa****</para>
            /// </summary>
            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dri-aaaa****</para>
            /// </summary>
            [NameInMap("DriveId")]
            [Validation(Required=false)]
            public string DriveId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableProfileManagement")]
            [Validation(Required=false)]
            public bool? EnableProfileManagement { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0976****</para>
            /// </summary>
            [NameInMap("ExternalDomainId")]
            [Validation(Required=false)]
            public string ExternalDomainId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1100****</para>
            /// </summary>
            [NameInMap("ExternalDriveId")]
            [Validation(Required=false)]
            public string ExternalDriveId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="mailto:user01@cn-hangzhou.120">user01@cn-hangzhou.120</a>****</para>
            /// </summary>
            [NameInMap("ExternalUserId")]
            [Validation(Required=false)]
            public string ExternalUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-07-02T08:42:26.000+00:00</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-07-07T02:46:04.000+00:00</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test****</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// </summary>
            [NameInMap("ProfileRoaming")]
            [Validation(Required=false)]
            public bool? ProfileRoaming { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NORMAL</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>536870912000</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>USER_PROFILE</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>243175936</para>
            /// </summary>
            [NameInMap("UsedSize")]
            [Validation(Required=false)]
            public long? UsedSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>user01</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAA****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B7AA****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
