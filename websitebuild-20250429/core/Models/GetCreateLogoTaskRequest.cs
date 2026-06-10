// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetCreateLogoTaskRequest : TeaModel {
        /// <summary>
        /// <para>The job ID returned upon successful invocation. Note: Keep this ID securely. You need this ID to query the device creation status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20051349</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
