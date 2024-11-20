// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetPipelineResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the MPS queue.</para>
        /// </summary>
        [NameInMap("Pipeline")]
        [Validation(Required=false)]
        public GetPipelineResponseBodyPipeline Pipeline { get; set; }
        public class GetPipelineResponseBodyPipeline : TeaModel {
            /// <summary>
            /// <para>The time when the template was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-12T16:17:54Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the template was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-12T16:17:54Z</para>
            /// </summary>
            [NameInMap("ModifiedTime")]
            [Validation(Required=false)]
            public string ModifiedTime { get; set; }

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
            /// 
            /// <b>Example:</b>
            /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
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
            /// <para>The type of the MPS queue.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Standard: standard MPS queue.</description></item>
            /// <item><description>Boost: MPS queue with transcoding speed boosted.</description></item>
            /// <item><description>NarrowBandHDV2: MPS queue that supports Narrowband HD 2.0.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Standard</para>
            /// </summary>
            [NameInMap("Speed")]
            [Validation(Required=false)]
            public string Speed { get; set; }

            /// <summary>
            /// <para>The state of the MPS queue.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Active</description></item>
            /// <item><description>Paused</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
