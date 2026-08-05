// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateRtcCloudRecordingShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The updated layout parameters. Leave this parameter empty in single-stream recording mode. This parameter is required in stream mixing recording mode when the transcoding output is not audio-only.</para>
        /// </summary>
        [NameInMap("MixLayoutParams")]
        [Validation(Required=false)]
        public string MixLayoutParamsShrink { get; set; }

        /// <summary>
        /// <para>The updated subscription parameters.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SubscribeParams")]
        [Validation(Required=false)]
        public string SubscribeParamsShrink { get; set; }

        /// <summary>
        /// <para>The task ID. This ID is returned by StartRtcCloudRecording. Only tasks in the running or abnormal state can be updated.</para>
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
