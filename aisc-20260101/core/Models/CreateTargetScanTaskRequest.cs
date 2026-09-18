// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AISC20260101.Models
{
    public class CreateTargetScanTaskRequest : TeaModel {
        /// <summary>
        /// <para>The language filter for samples, in locale format (such as zh_CN or en_US, which is internally normalized to zh or en). If this parameter is not specified, samples are selected based on the default language policy combined with general-purpose samples.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh_CN</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The detection intensity. The backend derives the corresponding technique level based on this value. If this parameter is not specified, the system falls back to the scan task configuration saved for the target, and then to the system default value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("SampleLevel")]
        [Validation(Required=false)]
        public long? SampleLevel { get; set; }

        /// <summary>
        /// <para>The unique identifier of the scan target. The target must have passed connectivity verification (verifyStatus=verified). Otherwise, a 400 error is returned. You can call TestConnectivity to complete the verification first.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>target-abc123def4567</para>
        /// </summary>
        [NameInMap("TargetId")]
        [Validation(Required=false)]
        public string TargetId { get; set; }

    }

}
