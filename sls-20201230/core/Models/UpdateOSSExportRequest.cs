// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class UpdateOSSExportRequest : TeaModel {
        /// <summary>
        /// <para>The configuration details of the job.</para>
        /// </summary>
        [NameInMap("configuration")]
        [Validation(Required=false)]
        public OSSExportConfiguration Configuration { get; set; }

        /// <summary>
        /// <para>The description of the job.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ali-test-oss-job</para>
        /// </summary>
        [NameInMap("displayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

    }

}
