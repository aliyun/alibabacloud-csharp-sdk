// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class GetDeploymentsByLabelRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to exclude job summary information, such as jobName and status, from the response. If set to true, the response includes only the JobId. This improves performance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ignoreJobSummary")]
        [Validation(Required=false)]
        public bool? IgnoreJobSummary { get; set; }

        /// <summary>
        /// <para>Specifies whether to exclude resource configuration information, such as parallelism and the number of CUs, from the response. This reduces the size of the returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ignoreResourceSetting")]
        [Validation(Required=false)]
        public bool? IgnoreResourceSetting { get; set; }

        /// <summary>
        /// <para>The label key used for filtering.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key</para>
        /// </summary>
        [NameInMap("labelKey")]
        [Validation(Required=false)]
        public string LabelKey { get; set; }

        /// <summary>
        /// <para>The label value. You can specify multiple values separated by commas (,) to create an OR condition.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>value</para>
        /// </summary>
        [NameInMap("labelValue")]
        [Validation(Required=false)]
        public string LabelValue { get; set; }

    }

}
