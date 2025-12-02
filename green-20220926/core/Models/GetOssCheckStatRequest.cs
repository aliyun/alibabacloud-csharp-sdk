// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetOssCheckStatRequest : TeaModel {
        /// <summary>
        /// <para>Whether to query by month.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ByMonth")]
        [Validation(Required=false)]
        public bool? ByMonth { get; set; }

        /// <summary>
        /// <para>End date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-08-24 10:01:55</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>Parent task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>P_UNHBH</para>
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
        /// <para>Start date.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-08-11 09:00:19</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

    }

}
