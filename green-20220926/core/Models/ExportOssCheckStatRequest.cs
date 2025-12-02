// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class ExportOssCheckStatRequest : TeaModel {
        /// <summary>
        /// <para>Whether to support monthly indexing. Values: -true: supported. -false: not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ByMonth")]
        [Validation(Required=false)]
        public bool? ByMonth { get; set; }

        /// <summary>
        /// <para>End time of the query, in the format yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-11 10:00:00</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>OSS detection task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>P_UX0K5X</para>
        /// </summary>
        [NameInMap("ParentTaskId")]
        [Validation(Required=false)]
        public string ParentTaskId { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Start time of the query, in the format yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-03-10 10:00:00</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
