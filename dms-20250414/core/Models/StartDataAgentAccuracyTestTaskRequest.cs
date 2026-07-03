// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class StartDataAgentAccuracyTestTaskRequest : TeaModel {
        /// <summary>
        /// <para>The accuracy test instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>at-106n4rg17gv9fxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("AccuracyTestInsId")]
        [Validation(Required=false)]
        public string AccuracyTestInsId { get; set; }

        /// <summary>
        /// <para>The accuracy test sample.</para>
        /// 
        /// <b>Example:</b>
        /// <para>包含问题、答案[、SQL]的文件</para>
        /// </summary>
        [NameInMap("CsvFile")]
        [Validation(Required=false)]
        public string CsvFile { get; set; }

        /// <summary>
        /// <para>The DMS unit used to create the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DmsUnit")]
        [Validation(Required=false)]
        public string DmsUnit { get; set; }

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
        /// <para>The ID of the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8wfig6l33n4f4xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
