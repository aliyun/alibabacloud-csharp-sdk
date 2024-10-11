// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SubmitAIJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the AI jobs.</para>
        /// </summary>
        [NameInMap("AIJobList")]
        [Validation(Required=false)]
        public SubmitAIJobResponseBodyAIJobList AIJobList { get; set; }
        public class SubmitAIJobResponseBodyAIJobList : TeaModel {
            [NameInMap("AIJob")]
            [Validation(Required=false)]
            public List<SubmitAIJobResponseBodyAIJobListAIJob> AIJob { get; set; }
            public class SubmitAIJobResponseBodyAIJobListAIJob : TeaModel {
                /// <summary>
                /// <para>The ID of the AI job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9e82640c85114bf5af23edfaf****</para>
                /// </summary>
                [NameInMap("JobId")]
                [Validation(Required=false)]
                public string JobId { get; set; }

                /// <summary>
                /// <para>The ID of the video.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3D3D12340d92c641401fab46a0b847****</para>
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// <para>The type of the AI job. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>AIMediaDNA</b>: The media fingerprinting job.</description></item>
                /// <item><description><b>AIVideoTag</b>: The smart tagging job.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>AIVideoTag</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>25818875-5F78-4A13-BEF6-D73936****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
