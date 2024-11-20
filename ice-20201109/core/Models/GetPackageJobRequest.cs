// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetPackageJobRequest : TeaModel {
        /// <summary>
        /// <para>The job ID. You can obtain the job ID from the response parameters of the <a href="https://help.aliyun.com/document_detail/461964.html">SubmitPackageJob</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ab4802364a2e49208c99efab82dfa8e8</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

    }

}
