// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class ListDataAgentAccuracyTestResultsRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the accuracy test.</para>
        /// 
        /// <b>Example:</b>
        /// <para>at-106n4rg17gv9fxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("AccuracyTestInsId")]
        [Validation(Required=false)]
        public string AccuracyTestInsId { get; set; }

        /// <summary>
        /// <para>The result ID used to retrieve a single record.</para>
        /// 
        /// <b>Example:</b>
        /// <para>at-emhnbwewfngrxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("AccuracyTestResultId")]
        [Validation(Required=false)]
        public string AccuracyTestResultId { get; set; }

        /// <summary>
        /// <para>The subtask ID used to filter results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>f1eb8728-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("AccuracyTestSubtaskId")]
        [Validation(Required=false)]
        public string AccuracyTestSubtaskId { get; set; }

        /// <summary>
        /// <para>The ID of the accuracy test task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>692abb8f-xxxx-xxxx-xxxx-xxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("AccuracyTestTaskId")]
        [Validation(Required=false)]
        public string AccuracyTestTaskId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nu use</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NesLoKLEdIZrKhDT7I2gS****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8wfig6l33n4f4xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
