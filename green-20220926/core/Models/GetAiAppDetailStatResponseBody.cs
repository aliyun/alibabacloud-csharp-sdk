// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetAiAppDetailStatResponseBody : TeaModel {
        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>id-xxx</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The average duration of model calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.55</para>
        /// </summary>
        [NameInMap("AvgModelDuration")]
        [Validation(Required=false)]
        public float? AvgModelDuration { get; set; }

        /// <summary>
        /// <para>The day-over-day change ratio of average model call duration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.05</para>
        /// </summary>
        [NameInMap("AvgModelDurationDau")]
        [Validation(Required=false)]
        public float? AvgModelDurationDau { get; set; }

        /// <summary>
        /// <para>The number of model calls.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("ModelCount")]
        [Validation(Required=false)]
        public long? ModelCount { get; set; }

        /// <summary>
        /// <para>The day-over-day change ratio of model call count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.15</para>
        /// </summary>
        [NameInMap("ModelCountDau")]
        [Validation(Required=false)]
        public float? ModelCountDau { get; set; }

        /// <summary>
        /// <para>The ID assigned by the backend to uniquely identify a request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of risk events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskEventCount")]
        [Validation(Required=false)]
        public long? RiskEventCount { get; set; }

        /// <summary>
        /// <para>The number of tokens consumed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11000</para>
        /// </summary>
        [NameInMap("TokenCount")]
        [Validation(Required=false)]
        public long? TokenCount { get; set; }

        /// <summary>
        /// <para>The day-over-day change ratio of token consumption count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-0.15</para>
        /// </summary>
        [NameInMap("TokenCountDau")]
        [Validation(Required=false)]
        public float? TokenCountDau { get; set; }

    }

}
