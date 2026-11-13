// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetTopicInfluenceResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of baseline instances affected by the event.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTopicInfluenceResponseBodyData Data { get; set; }
        public class GetTopicInfluenceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of affected baseline instances.</para>
            /// </summary>
            [NameInMap("Influences")]
            [Validation(Required=false)]
            public List<GetTopicInfluenceResponseBodyDataInfluences> Influences { get; set; }
            public class GetTopicInfluenceResponseBodyDataInfluences : TeaModel {
                /// <summary>
                /// <para>The ID of the baseline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12345</para>
                /// </summary>
                [NameInMap("BaselineId")]
                [Validation(Required=false)]
                public long? BaselineId { get; set; }

                /// <summary>
                /// <para>The name of the baseline.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Baseline name</para>
                /// </summary>
                [NameInMap("BaselineName")]
                [Validation(Required=false)]
                public string BaselineName { get; set; }

                /// <summary>
                /// <para>The business date timestamp of the baseline instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1553356800000</para>
                /// </summary>
                [NameInMap("Bizdate")]
                [Validation(Required=false)]
                public long? Bizdate { get; set; }

                /// <summary>
                /// <para>The buffer of the baseline instance, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>360</para>
                /// </summary>
                [NameInMap("Buffer")]
                [Validation(Required=false)]
                public long? Buffer { get; set; }

                /// <summary>
                /// <para>The cycle number of the baseline instance. The value is 1 for daily baselines, and ranges from 1 to 24 for hourly baselines.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("InGroupId")]
                [Validation(Required=false)]
                public int? InGroupId { get; set; }

                /// <summary>
                /// <para>The Alibaba Cloud UID of the baseline owner. Multiple owners are separated by commas (,).</para>
                /// 
                /// <b>Example:</b>
                /// <para>952795****</para>
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The priority of the baseline. Valid values: 1, 2, 5, 7, and 8.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The ID of the workspace to which the baseline belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1234</para>
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public long? ProjectId { get; set; }

                /// <summary>
                /// <para>The status of the baseline. Valid values: ERROR (abnormal), SAFE (safe), DANGROUS (warning), and OVER (breached).</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAFE</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The ID of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("TopicId")]
            [Validation(Required=false)]
            public long? TopicId { get; set; }

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
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The unique ID of the request. You can use this ID to troubleshoot issues if an error occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFG****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
