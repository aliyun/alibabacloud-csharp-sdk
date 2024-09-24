// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeTaskErrorLogRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the task.</para>
        /// <remarks>
        /// <para> You can call the DescribeImageFixTask operation to query the IDs of tasks.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ivf-6e520160-205d-4801-b8e9-9e7e****</para>
        /// </summary>
        [NameInMap("BuildTaskId")]
        [Validation(Required=false)]
        public string BuildTaskId { get; set; }

    }

}
