// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Openanalytics_open20180619.Models
{
    public class GetJobAttemptLogRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>j202105272322hangzhou5d64f1560000128-0001</para>
        /// </summary>
        [NameInMap("JobAttemptId")]
        [Validation(Required=false)]
        public string JobAttemptId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>j202105272322hangzhou5d64f1560000128</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>release-test</para>
        /// </summary>
        [NameInMap("VcName")]
        [Validation(Required=false)]
        public string VcName { get; set; }

    }

}
