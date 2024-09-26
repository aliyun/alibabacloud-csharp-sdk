// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetBaselineConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the baseline.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBaselineConfigResponseBodyData Data { get; set; }
        public class GetBaselineConfigResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The baseline ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("BaselineId")]
            [Validation(Required=false)]
            public long? BaselineId { get; set; }

            /// <summary>
            /// <para>The name of the baseline.</para>
            /// </summary>
            [NameInMap("BaselineName")]
            [Validation(Required=false)]
            public string BaselineName { get; set; }

            /// <summary>
            /// <para>The type of the baseline. Valid values: DAILY and HOURLY.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DAILY</para>
            /// </summary>
            [NameInMap("BaselineType")]
            [Validation(Required=false)]
            public string BaselineType { get; set; }

            /// <summary>
            /// <para>The hour in the alerting time of the day-level baseline. Valid values: [0, 47].</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("ExpHour")]
            [Validation(Required=false)]
            public int? ExpHour { get; set; }

            /// <summary>
            /// <para>The minute in the alerting time of the day-level baseline. Valid values: [0, 59].</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("ExpMinu")]
            [Validation(Required=false)]
            public int? ExpMinu { get; set; }

            /// <summary>
            /// <para>The alerting time of the hour-level baseline. This parameter is presented as key-value pairs in the JSON format. The key indicates the ID of the cycle, and the value is presented in the hh:mm format. Valid values of hh: [0,47]. Valid values of mm: [0,59].</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;1&quot;:&quot;03:28&quot;,&quot;2&quot;:&quot;04:28&quot;,&quot;3&quot;:&quot;05:28&quot;,&quot;4&quot;:&quot;06:28&quot;,&quot;5&quot;:&quot;07:28&quot;,&quot;6&quot;:&quot;08:28&quot;,&quot;7&quot;:&quot;09:28&quot;,&quot;8&quot;:&quot;10:28&quot;,&quot;9&quot;:&quot;11:28&quot;,&quot;10&quot;:&quot;12:28&quot;,&quot;11&quot;:&quot;13:28&quot;,&quot;12&quot;:&quot;14:28&quot;,&quot;13&quot;:&quot;15:28&quot;,&quot;14&quot;:&quot;16:28&quot;,&quot;15&quot;:&quot;17:28&quot;,&quot;16&quot;:&quot;18:28&quot;,&quot;17&quot;:&quot;19:28&quot;,&quot;18&quot;:&quot;20:28&quot;,&quot;19&quot;:&quot;21:28&quot;,&quot;20&quot;:&quot;22:28&quot;,&quot;21&quot;:&quot;23:28&quot;,&quot;22&quot;:&quot;24:28&quot;,&quot;23&quot;:&quot;25:28&quot;,&quot;24&quot;:&quot;26:28&quot;}</para>
            /// </summary>
            [NameInMap("HourExpDetail")]
            [Validation(Required=false)]
            public string HourExpDetail { get; set; }

            /// <summary>
            /// <para>The committed completion time of the hour-level baseline. This parameter is presented as key-value pairs in the JSON format. The key indicates the ID of the cycle, and the value is presented in the hh:mm format. Valid values of hh: [0,47]. Valid values of mm: [0,59].</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;1&quot;:&quot;03:58&quot;,&quot;2&quot;:&quot;04:58&quot;,&quot;3&quot;:&quot;05:58&quot;,&quot;4&quot;:&quot;06:58&quot;,&quot;5&quot;:&quot;07:58&quot;,&quot;6&quot;:&quot;08:58&quot;,&quot;7&quot;:&quot;09:58&quot;,&quot;8&quot;:&quot;10:58&quot;,&quot;9&quot;:&quot;11:58&quot;,&quot;10&quot;:&quot;12:58&quot;,&quot;11&quot;:&quot;13:58&quot;,&quot;12&quot;:&quot;14:58&quot;,&quot;13&quot;:&quot;15:58&quot;,&quot;14&quot;:&quot;16:58&quot;,&quot;15&quot;:&quot;17:58&quot;,&quot;16&quot;:&quot;18:58&quot;,&quot;17&quot;:&quot;19:58&quot;,&quot;18&quot;:&quot;20:58&quot;,&quot;19&quot;:&quot;21:58&quot;,&quot;20&quot;:&quot;22:58&quot;,&quot;21&quot;:&quot;23:58&quot;,&quot;22&quot;:&quot;24:58&quot;,&quot;23&quot;:&quot;25:58&quot;,&quot;24&quot;:&quot;26:58&quot;}</para>
            /// </summary>
            [NameInMap("HourSlaDetail")]
            [Validation(Required=false)]
            public string HourSlaDetail { get; set; }

            /// <summary>
            /// <para>Indicates whether the baseline is a default baseline of the workspace. Valid values: true and false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account used by the baseline owner. Multiple IDs can be specified. The IDs are separated by commas (,).</para>
            /// 
            /// <b>Example:</b>
            /// <para>9527952****</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The priority of the baseline. Valid values: {1,3,5,7,8}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The hour in the committed completion time of the day-level baseline. Valid values: [0, 47].</para>
            /// 
            /// <b>Example:</b>
            /// <para>9</para>
            /// </summary>
            [NameInMap("SlaHour")]
            [Validation(Required=false)]
            public int? SlaHour { get; set; }

            /// <summary>
            /// <para>The minute in the committed completion time of the day-level baseline. Valid values: [0, 59].</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("SlaMinu")]
            [Validation(Required=false)]
            public int? SlaMinu { get; set; }

            /// <summary>
            /// <para>Indicates whether the baseline is enabled. Valid values: true and false.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UseFlag")]
            [Validation(Required=false)]
            public bool? UseFlag { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1031203110005</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameters are invalid.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>401</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecb967ec-c137-48a5-860****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
