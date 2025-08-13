// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeListModelResponseBody : TeaModel {
        /// <summary>
        /// <para>Current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>Number of items per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public List<DescribeListModelResponseBodyResultObject> ResultObject { get; set; }
        public class DescribeListModelResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Uploader ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>011786</para>
            /// </summary>
            [NameInMap("bucId")]
            [Validation(Required=false)]
            public string BucId { get; set; }

            /// <summary>
            /// <para>Creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-05-07T02:26:01Z</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Model code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>code</para>
            /// </summary>
            [NameInMap("modelCode")]
            [Validation(Required=false)]
            public string ModelCode { get; set; }

            /// <summary>
            /// <para>Unique identifier of the model in use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("modelId")]
            [Validation(Required=false)]
            public string ModelId { get; set; }

            /// <summary>
            /// <para>Model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom_model</para>
            /// </summary>
            [NameInMap("modelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>Model scenario.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custom_scene</para>
            /// </summary>
            [NameInMap("modelScene")]
            [Validation(Required=false)]
            public string ModelScene { get; set; }

            /// <summary>
            /// <para>Model status, values: -<b>ENABLED</b>: Enabled-<b>DISABLED</b>: Disabled</para>
            /// 
            /// <b>Example:</b>
            /// <para>ENABLED</para>
            /// </summary>
            [NameInMap("modelStatus")]
            [Validation(Required=false)]
            public string ModelStatus { get; set; }

            /// <summary>
            /// <para>Task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0c8a3799-5ac8-434b-b255-e06edb35c05f</para>
            /// </summary>
            [NameInMap("taskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>Last update time of the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-11-18T02:07:00Z</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>User ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1806507582222226</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>File name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>saf-ai-1662519103706.csv</para>
            /// </summary>
            [NameInMap("userLocalFileName")]
            [Validation(Required=false)]
            public string UserLocalFileName { get; set; }

        }

        /// <summary>
        /// <para>Total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalItem")]
        [Validation(Required=false)]
        public string TotalItem { get; set; }

        /// <summary>
        /// <para>Total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public string TotalPage { get; set; }

    }

}
