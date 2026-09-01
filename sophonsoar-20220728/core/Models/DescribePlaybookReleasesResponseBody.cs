// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePlaybookReleasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public DescribePlaybookReleasesResponseBodyPage Page { get; set; }
        public class DescribePlaybookReleasesResponseBodyPage : TeaModel {
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
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>A list of playbook versions.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DescribePlaybookReleasesResponseBodyRecords> Records { get; set; }
        public class DescribePlaybookReleasesResponseBodyRecords : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that published the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>145xxxx985</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The description of the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a new version</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the version was created. This is a 13-digit UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1655277397000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the version was last modified. This is a 13-digit UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1691460804000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The record ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80xxx</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            /// <summary>
            /// <para>The MD5 hash of the playbook configuration for the published version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>be0a4ef084dd174abe47xxxxx</para>
            /// </summary>
            [NameInMap("TaskflowMd5")]
            [Validation(Required=false)]
            public string TaskflowMd5 { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3DFBE11C-6EB6-5166-92D6-3397796AFE1E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
