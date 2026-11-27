// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitEditMediaManifestJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the manifest editing task, which is the MediaConvert pipeline task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>93e154cb83e54b7a0f1236f847f4****</para>
        /// </summary>
        [NameInMap("ManifestEditJobId")]
        [Validation(Required=false)]
        public string ManifestEditJobId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4AF6-D7393642CA58****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
