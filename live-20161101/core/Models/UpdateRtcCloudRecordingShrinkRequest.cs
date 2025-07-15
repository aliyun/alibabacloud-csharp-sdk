// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateRtcCloudRecordingShrinkRequest : TeaModel {
        [NameInMap("MixLayoutParams")]
        [Validation(Required=false)]
        public string MixLayoutParamsShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SubscribeParams")]
        [Validation(Required=false)]
        public string SubscribeParamsShrink { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>73-8501-</b></b>-8ac1-72295a</b>****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
