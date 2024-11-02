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
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
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
        /// <para>The information about the playbook version.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<DescribePlaybookReleasesResponseBodyRecords> Records { get; set; }
        public class DescribePlaybookReleasesResponseBodyRecords : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account that is used to publish the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>145xxxx985</para>
            /// </summary>
            [NameInMap("Creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <para>The description of the layer version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>This is a new version</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the version was created. The value is a 13-digit timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1655277397000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the version was modified. The value is a 13-digit timestamp.</para>
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
            /// <para>The MD5 value configured for the published version of the playbook.</para>
            /// 
            /// <b>Example:</b>
            /// <para>be0a4ef084dd174abe47xxxxx</para>
            /// </summary>
            [NameInMap("TaskflowMd5")]
            [Validation(Required=false)]
            public string TaskflowMd5 { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3DFBE11C-6EB6-5166-92D6-3397796AFE1E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
