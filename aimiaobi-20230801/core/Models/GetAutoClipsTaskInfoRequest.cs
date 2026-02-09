// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetAutoClipsTaskInfoRequest : TeaModel {
        [NameInMap("ShowAnalysisResults")]
        [Validation(Required=false)]
        public bool? ShowAnalysisResults { get; set; }

        [NameInMap("ShowResourceInfo")]
        [Validation(Required=false)]
        public bool? ShowResourceInfo { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0dbf1055f8a2475d99904c3b76a0ffba</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
