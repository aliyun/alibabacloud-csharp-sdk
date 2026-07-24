// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class UpdateOssCheckResultsFreezeRequest : TeaModel {
        /// <summary>
        /// <para>The end time. Format: YYYY-MM-DD HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-10-21 16:08:38</para>
        /// </summary>
        [NameInMap("EndDate")]
        [Validation(Required=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// <para>The items to freeze.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("FreezeItems")]
        [Validation(Required=false)]
        public string FreezeItems { get; set; }

        /// <summary>
        /// <para>The directory to which the frozen files are moved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uploadTest/</para>
        /// </summary>
        [NameInMap("FreezeRestorePath")]
        [Validation(Required=false)]
        public string FreezeRestorePath { get; set; }

        /// <summary>
        /// <para>The freeze type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACL</para>
        /// </summary>
        [NameInMap("FreezeType")]
        [Validation(Required=false)]
        public string FreezeType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start time. Format: YYYY-MM-DD HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-08-21 16:08:38</para>
        /// </summary>
        [NameInMap("StartDate")]
        [Validation(Required=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>P_15BU42</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
