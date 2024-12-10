// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetSowListResponseBody : TeaModel {
        /// <summary>
        /// <para>Interface response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data returned by the interface.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetSowListResponseBodyData> Data { get; set; }
        public class GetSowListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Completion time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-03-28 16:19:35</para>
            /// </summary>
            [NameInMap("CompleteTime")]
            [Validation(Required=false)]
            public string CompleteTime { get; set; }

            /// <summary>
            /// <para>Operation remarks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>新建</para>
            /// </summary>
            [NameInMap("OperateRemark")]
            [Validation(Required=false)]
            public string OperateRemark { get; set; }

            /// <summary>
            /// <para>Progress.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IN_PREPARATION</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>Record count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>173</para>
            /// </summary>
            [NameInMap("RecordCount")]
            [Validation(Required=false)]
            public int? RecordCount { get; set; }

            /// <summary>
            /// <para>Start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-24 16:51:26</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>Task type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>安全风险评估</para>
            /// </summary>
            [NameInMap("TaskTypeName")]
            [Validation(Required=false)]
            public string TaskTypeName { get; set; }

            /// <summary>
            /// <para>Work order name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>安全产品配置问题与超量提醒</para>
            /// </summary>
            [NameInMap("WorkOrderName")]
            [Validation(Required=false)]
            public string WorkOrderName { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Prompt information for the returned result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FA8883BC-CB18-5E28-A113-8249917CA05E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the call was successful. - <b>true</b>: The call was successful. - <b>false</b>: The call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
