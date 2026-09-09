// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class AbolishCrossProjectPipelineRunRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cross-workspace publish flow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fcfd4160-e2ff-4603-9719-09128fe733df</para>
        /// </summary>
        [NameInMap("PipelineRunId")]
        [Validation(Required=false)]
        public string PipelineRunId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The reason for stopping the cross-workspace publish flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The target publish plan has changed. Stop the flow that has not been executed</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

    }

}
