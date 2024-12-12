// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetLiveRecordTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the recording job. You can specify the JobId parameter to retrieve the snapshot of the template used by the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ab0e3e76-1e9d-11ed-ba64-0c42a1b73d66</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>69e1f9fe-1e97-11ed-ba64-0c42a1b73d66</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

    }

}
