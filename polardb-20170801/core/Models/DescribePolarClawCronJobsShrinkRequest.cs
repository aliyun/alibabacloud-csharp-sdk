// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarClawCronJobsShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>Specifies whether to include disabled jobs. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeDisabled")]
        [Validation(Required=false)]
        public bool? IncludeDisabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the run history. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeRuns")]
        [Validation(Required=false)]
        public bool? IncludeRuns { get; set; }

        /// <summary>
        /// <para>Filters the results by a list of job IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ee00f56-f467-4d41-858c-ca4ede2c770e,1ee00f56-f467-4d41-858c-ca4ede2c770f</para>
        /// </summary>
        [NameInMap("JobIdList")]
        [Validation(Required=false)]
        public string JobIdListShrink { get; set; }

        /// <summary>
        /// <para>The maximum number of run history records per job. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("RunLimit")]
        [Validation(Required=false)]
        public int? RunLimit { get; set; }

    }

}
