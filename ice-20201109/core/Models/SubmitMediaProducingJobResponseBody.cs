// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitMediaProducingJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The job ID.</para>
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
        /// <para>The ID of the editing project.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>b4549d46c88681030f6e</b></b></para>
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
        /// <para><b><b>d8s4h75ci975745c14b</b></b></para>
        /// </summary>
        [NameInMap("VodMediaId")]
        [Validation(Required=false)]
        public string VodMediaId { get; set; }

    }

}
