// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class CreateAnalysisExportTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public CreateAnalysisExportTaskResponseBodyResultObject ResultObject { get; set; }
        public class CreateAnalysisExportTaskResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Export list.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[
            ///                 {
            ///                     &quot;fieldName&quot;: &quot;requestId&quot;,
            ///                     &quot;fieldTitle&quot;: &quot;RequestId&quot;
            ///                 },
            ///                 {
            ///                     &quot;fieldName&quot;: &quot;eventTime&quot;,
            ///                     &quot;fieldTitle&quot;: &quot;事件时间&quot;
            ///                 },
            ///                 {
            ///                     &quot;fieldName&quot;: &quot;accountId&quot;,
            ///                     &quot;fieldTitle&quot;: &quot;账号&quot;
            ///                 },
            ///                 {
            ///                     &quot;fieldName&quot;: &quot;deviceId&quot;,
            ///                     &quot;fieldTitle&quot;: &quot;设备ID&quot;
            ///                 },
            ///                 {
            ///                     &quot;fieldName&quot;: &quot;eventCode&quot;,
            ///                     &quot;fieldTitle&quot;: &quot;事件编码&quot;
            ///                 },
            ///                 {
            ///                     &quot;fieldName&quot;: &quot;ip&quot;,
            ///                     &quot;fieldTitle&quot;: &quot;IP&quot;
            ///                 },
            ///                 {
            ///                     &quot;fieldName&quot;: &quot;score&quot;,
            ///                     &quot;fieldTitle&quot;: &quot;分值&quot;
            ///                 },
            ///                 {
            ///                     &quot;fieldName&quot;: &quot;tags&quot;,
            ///                     &quot;fieldTitle&quot;: &quot;标签&quot;
            ///                 },
            ///                 {
            ///                     &quot;fieldName&quot;: &quot;DEtest222&quot;,
            ///                     &quot;fieldTitle&quot;: &quot;测试222&quot;
            ///                 }
            ///             ]</para>
            /// </summary>
            [NameInMap("columns")]
            [Validation(Required=false)]
            public string Columns { get; set; }

            /// <summary>
            /// <para>Export task conditions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///      &quot;fieldName&quot;: null, 
            ///       &quot;fieldValue&quot;: null 
            ///       }</para>
            /// </summary>
            [NameInMap("conditions")]
            [Validation(Required=false)]
            public string Conditions { get; set; }

            /// <summary>
            /// <para>Event start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1752076800000</para>
            /// </summary>
            [NameInMap("eventBeginTime")]
            [Validation(Required=false)]
            public long? EventBeginTime { get; set; }

            /// <summary>
            /// <para>Event code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>de_ahespg8137</para>
            /// </summary>
            [NameInMap("eventCodes")]
            [Validation(Required=false)]
            public string EventCodes { get; set; }

            /// <summary>
            /// <para>End time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1753891199000</para>
            /// </summary>
            [NameInMap("eventEndTime")]
            [Validation(Required=false)]
            public long? EventEndTime { get; set; }

            /// <summary>
            /// <para>File format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CSV</para>
            /// </summary>
            [NameInMap("fileFormat")]
            [Validation(Required=false)]
            public string FileFormat { get; set; }

            /// <summary>
            /// <para>OSS-generated key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxx</para>
            /// </summary>
            [NameInMap("ossKey")]
            [Validation(Required=false)]
            public string OssKey { get; set; }

            /// <summary>
            /// <para>Export task scope.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>Task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Export task type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BASIC</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>User UID</para>
            /// 
            /// <b>Example:</b>
            /// <para>1519714049632764</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

        }

    }

}
