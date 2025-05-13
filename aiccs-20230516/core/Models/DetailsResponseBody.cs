// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20230516.Models
{
    public class DetailsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>示例值</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public DetailsResponseBodyModel Model { get; set; }
        public class DetailsResponseBodyModel : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<DetailsResponseBodyModelList> List { get; set; }
            public class DetailsResponseBodyModelList : TeaModel {
                /// <summary>
                /// <para>批次号</para>
                /// 
                /// <b>Example:</b>
                /// <para>27</para>
                /// </summary>
                [NameInMap("BatchId")]
                [Validation(Required=false)]
                public long? BatchId { get; set; }

                /// <summary>
                /// <para>呼叫状态描述</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("CallDesc")]
                [Validation(Required=false)]
                public string CallDesc { get; set; }

                /// <summary>
                /// <para>外呼ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>28dd74a4-30ec-43c0-9bec-272924c51eeb</para>
                /// </summary>
                [NameInMap("CallId")]
                [Validation(Required=false)]
                public string CallId { get; set; }

                /// <summary>
                /// <para>呼叫状态</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CallStatus")]
                [Validation(Required=false)]
                public long? CallStatus { get; set; }

                /// <summary>
                /// <para>外呼类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>2001</para>
                /// </summary>
                [NameInMap("CallType")]
                [Validation(Required=false)]
                public long? CallType { get; set; }

                /// <summary>
                /// <para>导入时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-04-25 15:19:02</para>
                /// </summary>
                [NameInMap("ImportTime")]
                [Validation(Required=false)]
                public string ImportTime { get; set; }

                /// <summary>
                /// <para>拦截原因</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("InterceptReason")]
                [Validation(Required=false)]
                public string InterceptReason { get; set; }

                /// <summary>
                /// <para>外呼号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>188******454</para>
                /// </summary>
                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                /// <summary>
                /// <para>号码状态描述</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("NumberDesc")]
                [Validation(Required=false)]
                public string NumberDesc { get; set; }

                /// <summary>
                /// <para>外呼号码MD5</para>
                /// 
                /// <b>Example:</b>
                /// <para>cbe1b40f76f2cca4735954886b706ffa</para>
                /// </summary>
                [NameInMap("NumberMD5")]
                [Validation(Required=false)]
                public string NumberMD5 { get; set; }

                /// <summary>
                /// <para>号码状态</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NumberStatus")]
                [Validation(Required=false)]
                public long? NumberStatus { get; set; }

                /// <summary>
                /// <para>用户自定义标签</para>
                /// 
                /// <b>Example:</b>
                /// <para>A</para>
                /// </summary>
                [NameInMap("Tag")]
                [Validation(Required=false)]
                public string Tag { get; set; }

                /// <summary>
                /// <para>任务ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>28</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public long? TaskId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>94</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>79</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>71.8132</para>
            /// </summary>
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public float? TotalPage { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>389b2d0a-37e2-406d-b576-1fc0827be46a</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1686279332221</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
