// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetTopicResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the event.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTopicResponseBodyData Data { get; set; }
        public class GetTopicResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The timestamp when the event was discovered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1553524393000</para>
            /// </summary>
            [NameInMap("AddTime")]
            [Validation(Required=false)]
            public long? AddTime { get; set; }

            /// <summary>
            /// <para>The timestamp of the first alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1553524393000</para>
            /// </summary>
            [NameInMap("AlertTime")]
            [Validation(Required=false)]
            public long? AlertTime { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud UID of the assigner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>952795****</para>
            /// </summary>
            [NameInMap("Assigner")]
            [Validation(Required=false)]
            public string Assigner { get; set; }

            /// <summary>
            /// <para>The buffer of the worst baseline instance, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("BaselineBuffer")]
            [Validation(Required=false)]
            public long? BaselineBuffer { get; set; }

            /// <summary>
            /// <para>The baseline ID of the worst baseline instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("BaselineId")]
            [Validation(Required=false)]
            public long? BaselineId { get; set; }

            /// <summary>
            /// <para>The cycle number of the worst baseline instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("BaselineInGroupId")]
            [Validation(Required=false)]
            public int? BaselineInGroupId { get; set; }

            /// <summary>
            /// <para>The baseline name of the worst baseline instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Baseline name</para>
            /// </summary>
            [NameInMap("BaselineName")]
            [Validation(Required=false)]
            public string BaselineName { get; set; }

            /// <summary>
            /// <para>The status of the baseline. Valid values: ERROR, SAFE, DANGROUS (warning), and OVER (exceeded).</para>
            /// 
            /// <b>Example:</b>
            /// <para>SAFE</para>
            /// </summary>
            [NameInMap("BaselineStatus")]
            [Validation(Required=false)]
            public string BaselineStatus { get; set; }

            /// <summary>
            /// <para>The buffer of the event, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1200</para>
            /// </summary>
            [NameInMap("Buffer")]
            [Validation(Required=false)]
            public long? Buffer { get; set; }

            /// <summary>
            /// <para>The timestamp of the last handling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1553524393000</para>
            /// </summary>
            [NameInMap("DealTime")]
            [Validation(Required=false)]
            public long? DealTime { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud UID of the last handler.</para>
            /// 
            /// <b>Example:</b>
            /// <para>952795****</para>
            /// </summary>
            [NameInMap("DealUser")]
            [Validation(Required=false)]
            public string DealUser { get; set; }

            /// <summary>
            /// <para>The timestamp when the event was resolved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1553524393000</para>
            /// </summary>
            [NameInMap("FixTime")]
            [Validation(Required=false)]
            public long? FixTime { get; set; }

            /// <summary>
            /// <para>The timestamp when the event occurred. There may be a time difference between when the event occurred and when it was discovered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1553524393000</para>
            /// </summary>
            [NameInMap("HappenTime")]
            [Validation(Required=false)]
            public long? HappenTime { get; set; }

            /// <summary>
            /// <para>The instance ID associated with the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// <para>The timestamp of the next alert.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1553524393000</para>
            /// </summary>
            [NameInMap("NextAlertTime")]
            [Validation(Required=false)]
            public long? NextAlertTime { get; set; }

            /// <summary>
            /// <para>The ID of the node associated with the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }

            /// <summary>
            /// <para>The name of the node associated with the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Node name</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud UID of the event owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>952795****</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The ID of the workspace to which the node associated with the event belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// <para>The ID of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234</para>
            /// </summary>
            [NameInMap("TopicId")]
            [Validation(Required=false)]
            public long? TopicId { get; set; }

            /// <summary>
            /// <para>The name of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234 error</para>
            /// </summary>
            [NameInMap("TopicName")]
            [Validation(Required=false)]
            public string TopicName { get; set; }

            /// <summary>
            /// <para>The status of the event. Valid values: IGNORE (ignored), NEW (newly discovered), FIXING (being handled), and RECOVER (recovered).</para>
            /// 
            /// <b>Example:</b>
            /// <para>FIXING</para>
            /// </summary>
            [NameInMap("TopicStatus")]
            [Validation(Required=false)]
            public string TopicStatus { get; set; }

            /// <summary>
            /// <para>The type of the event. Valid values: SLOW and ERROR.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ERROR</para>
            /// </summary>
            [NameInMap("TopicType")]
            [Validation(Required=false)]
            public string TopicType { get; set; }

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
        /// <para>The unique ID of the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0000-ABCD-EFGH-IJKLMNOPQ</para>
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
