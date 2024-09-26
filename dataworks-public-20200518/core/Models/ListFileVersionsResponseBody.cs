// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListFileVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The file versions returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListFileVersionsResponseBodyData Data { get; set; }
        public class ListFileVersionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The details of the file version.</para>
            /// </summary>
            [NameInMap("FileVersions")]
            [Validation(Required=false)]
            public List<ListFileVersionsResponseBodyDataFileVersions> FileVersions { get; set; }
            public class ListFileVersionsResponseBodyDataFileVersions : TeaModel {
                /// <summary>
                /// <para>The type of the change to the file of the current version. Valid values: CREATE, UPDATE, and DELETE.</para>
                /// 
                /// <b>Example:</b>
                /// <para>UPDATE</para>
                /// </summary>
                [NameInMap("ChangeType")]
                [Validation(Required=false)]
                public string ChangeType { get; set; }

                /// <summary>
                /// <para>The description of the file version.</para>
                /// </summary>
                [NameInMap("Comment")]
                [Validation(Required=false)]
                public string Comment { get; set; }

                /// <summary>
                /// <para>The time when the file version was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1593881265000</para>
                /// </summary>
                [NameInMap("CommitTime")]
                [Validation(Required=false)]
                public long? CommitTime { get; set; }

                /// <summary>
                /// <para>The ID of the Alibaba Cloud account used to create the file of the current version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>73842342****</para>
                /// </summary>
                [NameInMap("CommitUser")]
                [Validation(Required=false)]
                public string CommitUser { get; set; }

                /// <summary>
                /// <para>The code in the file of the current version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SHOW TABLES;</para>
                /// </summary>
                [NameInMap("FileContent")]
                [Validation(Required=false)]
                public string FileContent { get; set; }

                /// <summary>
                /// <para>The name of the file of the current version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ods_user_info_d</para>
                /// </summary>
                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The basic information about the file of the current version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;fileName&quot;:&quot;ods_user_info_d&quot;,&quot;fileType&quot;:10}</para>
                /// </summary>
                [NameInMap("FilePropertyContent")]
                [Validation(Required=false)]
                public string FilePropertyContent { get; set; }

                /// <summary>
                /// <para>The version of the file.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("FileVersion")]
                [Validation(Required=false)]
                public int? FileVersion { get; set; }

                /// <summary>
                /// <para>Indicates whether the file version is the same as the latest file version in the production environment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsCurrentProd")]
                [Validation(Required=false)]
                public bool? IsCurrentProd { get; set; }

                /// <summary>
                /// <para>The scheduling configurations for the node that corresponds to the file of the current version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;cycleType&quot;:0,&quot;cronExpress&quot;:&quot;00 05 00 * * ?&quot;}</para>
                /// </summary>
                [NameInMap("NodeContent")]
                [Validation(Required=false)]
                public string NodeContent { get; set; }

                /// <summary>
                /// <para>The ID of the auto triggered node that corresponds to the file of the current version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public long? NodeId { get; set; }

                /// <summary>
                /// <para>The status of the file of the current version. Valid values: COMMITTING, COMMITTED, CHECK_OK, PACKAGED, DEPLOYING, DEPLOYED, and CANCELLED.</para>
                /// 
                /// <b>Example:</b>
                /// <para>COMMITTED</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The functional module to which the file belongs. Valid values: NORMAL, MANUAL, MANUAL_BIZ, SKIP, ADHOCQUERY, and COMPONENT. The value SKIP indicates that the node corresponding to the file is run in dry-run mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NORMAL</para>
                /// </summary>
                [NameInMap("UseType")]
                [Validation(Required=false)]
                public string UseType { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
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
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Invalid.Tenant.ConnectionNotExists</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The connection does not exist.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
