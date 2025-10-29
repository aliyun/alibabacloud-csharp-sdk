// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListFileVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of file versions.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListFileVersionsResponseBodyData Data { get; set; }
        public class ListFileVersionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of file version details.</para>
            /// </summary>
            [NameInMap("FileVersions")]
            [Validation(Required=false)]
            public List<ListFileVersionsResponseBodyDataFileVersions> FileVersions { get; set; }
            public class ListFileVersionsResponseBodyDataFileVersions : TeaModel {
                /// <summary>
                /// <para>The change type for this file version. Valid values: CREATE, UPDATE, and DELETE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UPDATE</para>
                /// </summary>
                [NameInMap("ChangeType")]
                [Validation(Required=false)]
                public string ChangeType { get; set; }

                /// <summary>
                /// <para>The description of this file version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Second version submission</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The timestamp (in milliseconds) when the file version was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593881265000</para>
                /// </summary>
                [NameInMap("CommitTime")]
                [Validation(Required=false)]
                public long? CommitTime { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud account ID of the user who created this file version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>73842342****</para>
                /// </summary>
                [NameInMap("CommitUser")]
                [Validation(Required=false)]
                public string CommitUser { get; set; }

                /// <summary>
                /// <para>The file code for this version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SHOW TABLES;</para>
                /// </summary>
                [NameInMap("FileContent")]
                [Validation(Required=false)]
                public string FileContent { get; set; }

                /// <summary>
                /// <para>The file name for this file version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ods_user_info_d</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The text information for this file version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;fileName&quot;:&quot;ods_user_info_d&quot;,&quot;fileType&quot;:10}</para>
                /// </summary>
                [NameInMap("FilePropertyContent")]
                [Validation(Required=false)]
                public string FilePropertyContent { get; set; }

                /// <summary>
                /// <para>The file version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("FileVersion")]
                [Validation(Required=false)]
                public int? FileVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether this file version is the latest version in the production environment.</para>
                /// <list type="bullet">
                /// <item><description>true</description></item>
                /// <item><description>false</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsCurrentProd")]
                [Validation(Required=false)]
                public bool? IsCurrentProd { get; set; }

                /// <summary>
                /// <para>The scheduling configuration for this file version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;cycleType&quot;:0,&quot;cronExpress&quot;:&quot;00 05 00 * * ?&quot;}</para>
                /// </summary>
                [NameInMap("NodeContent")]
                [Validation(Required=false)]
                public string NodeContent { get; set; }

                /// <summary>
                /// <para>The scheduling task ID associated with this file version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <para>The current status of the file version. Valid values: COMMITTING (committing), COMMITTED or CHECK_OK (committed), PACKAGED (ready for deployment), DEPLOYING (deploying), DEPLOYED (deployed), and CANCELLED (deployment canceled).</para>
                /// 
                /// <b>Example:</b>
                /// <para>COMMITTED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The functional module to which the file belongs. Valid values: NORMAL (Data Studio), MANUAL (manual task), MANUAL_BIZ (manual workflow), SKIP (dry-run scheduling in Data Studio), ADHOCQUERY (ad hoc query), and COMPONENT (component management).</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("UseType")]
                [Validation(Required=false)]
                public string UseType { get; set; }

            }

            /// <summary>
            /// <para>The current page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid.Tenant.ConnectionNotExists</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The connection does not exist.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call succeeded. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
