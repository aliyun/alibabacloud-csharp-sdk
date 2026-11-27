// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetRLSampleResponseBody : TeaModel {
        /// <summary>
        /// <para>The event stream sorted in ascending order by time.</para>
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<RLSampleEvent> Events { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc5yfk7eyg95lac</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The sample UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3afcfbdf-3956-4ab2-b9cb-f9c204b8fc9c</para>
        /// </summary>
        [NameInMap("PromptUid")]
        [Validation(Required=false)]
        public string PromptUid { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The trajectory index.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14</para>
        /// </summary>
        [NameInMap("SampleIndex")]
        [Validation(Required=false)]
        public string SampleIndex { get; set; }

        /// <summary>
        /// <para>The total number of returned events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>116</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
