// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdatePipelineRequest : TeaModel {
        /// <summary>
        /// <para>The name of the MPS queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-pipeline</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the MPS queue.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>d80e4e4044975745c14b</b></b></para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// <para>The priority of the MPS queue. Valid values: 1 to 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The state of the MPS queue.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Active</description></item>
        /// <item><description>Paused</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Paused</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
