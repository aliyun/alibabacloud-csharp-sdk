// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CancelUrlUploadJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The IDs of canceled jobs.</para>
        /// </summary>
        [NameInMap("CanceledJobs")]
        [Validation(Required=false)]
        public List<string> CanceledJobs { get; set; }

        /// <summary>
        /// <para>The jobs that do not exist.</para>
        /// </summary>
        [NameInMap("NonExists")]
        [Validation(Required=false)]
        public List<string> NonExists { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4D5C-3C3D-D7393642****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
