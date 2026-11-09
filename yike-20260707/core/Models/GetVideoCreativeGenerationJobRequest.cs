// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class GetVideoCreativeGenerationJobRequest : TeaModel {
        /// <summary>
        /// <para>The job ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2ff6142097984dde9591925df43291a9</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

    }

}
