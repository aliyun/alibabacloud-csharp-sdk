// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetRLTrajectoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc-20210114104214-vf9lowjt3pso</para>
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
        /// <para>The number of turn rows. The maximum number of turns per trajectory is 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The raw rows of sgl-metric for each turn. The schema is dynamic and retains the Logstore column names. JSON strings are parsed back into objects, and system fields with the __ prefix are excluded.</para>
        /// </summary>
        [NameInMap("Turns")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Turns { get; set; }

    }

}
