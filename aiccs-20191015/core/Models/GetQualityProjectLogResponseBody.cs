// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class GetQualityProjectLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. A value of 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The task logs of the quality inspection node.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetQualityProjectLogResponseBodyData> Data { get; set; }
        public class GetQualityProjectLogResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The execution data of the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sampling quality inspection details: Total number of eligible samples=0</para>
            /// </summary>
            [NameInMap("ActionData")]
            [Validation(Required=false)]
            public string ActionData { get; set; }

            /// <summary>
            /// <para>The time when the task was executed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-04-16 08:44:26</para>
            /// </summary>
            [NameInMap("ActionTime")]
            [Validation(Required=false)]
            public string ActionTime { get; set; }

            /// <summary>
            /// <para>The execution type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Sampling quality inspection</para>
            /// </summary>
            [NameInMap("ActionType")]
            [Validation(Required=false)]
            public string ActionType { get; set; }

            /// <summary>
            /// <para>The time when the quality inspection task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-04-07 18:07:18</para>
            /// </summary>
            [NameInMap("ProjectCreateTime")]
            [Validation(Required=false)]
            public string ProjectCreateTime { get; set; }

            /// <summary>
            /// <para>The ID of the quality inspection task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15977801</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE338D98-9BD3-4413-B165</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
