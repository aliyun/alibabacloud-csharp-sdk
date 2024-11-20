// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitLiveEditingJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the live editing job.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>d80e4e4044975745c14b</b></b></para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The media asset ID of the output file.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>c469e944b5a856828dc2</b></b></para>
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// <para>The URL of the output file.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://test-bucket.cn-shanghai.aliyuncs.com/test.mp4">http://test-bucket.cn-shanghai.aliyuncs.com/test.mp4</a></para>
        /// </summary>
        [NameInMap("MediaURL")]
        [Validation(Required=false)]
        public string MediaURL { get; set; }

        /// <summary>
        /// <para>The ID of the live editing project.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>fddd7748b58bf1d47e95</b></b></para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>36-3C1E-4417-BDB2-1E034F</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The media asset ID of the output file in ApsaraVideo VOD if the output file is stored in ApsaraVideo VOD.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>d7578s4h75ci945c14b</b></b></para>
        /// </summary>
        [NameInMap("VodMediaId")]
        [Validation(Required=false)]
        public string VodMediaId { get; set; }

    }

}
