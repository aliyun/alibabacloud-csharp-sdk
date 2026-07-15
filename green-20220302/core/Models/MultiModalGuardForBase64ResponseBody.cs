// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220302.Models
{
    public class MultiModalGuardForBase64ResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public MultiModalGuardForBase64ResponseBodyData Data { get; set; }
        public class MultiModalGuardForBase64ResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            /// <summary>
            /// <para>The details.</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public List<MultiModalGuardForBase64ResponseBodyDataDetail> Detail { get; set; }
            public class MultiModalGuardForBase64ResponseBodyDataDetail : TeaModel {
                /// <summary>
                /// <para>The risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>low</para>
                /// </summary>
                [NameInMap("Level")]
                [Validation(Required=false)]
                public string Level { get; set; }

                /// <summary>
                /// <para>The result.</para>
                /// </summary>
                [NameInMap("Result")]
                [Validation(Required=false)]
                public List<MultiModalGuardForBase64ResponseBodyDataDetailResult> Result { get; set; }
                public class MultiModalGuardForBase64ResponseBodyDataDetailResult : TeaModel {
                    /// <summary>
                    /// <para>The confidence level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Confidence")]
                    [Validation(Required=false)]
                    public float? Confidence { get; set; }

                    /// <summary>
                    /// <para>The description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>未检测出风险</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The extension information.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>json格式数据</para>
                    /// </summary>
                    [NameInMap("Ext")]
                    [Validation(Required=false)]
                    public object Ext { get; set; }

                    /// <summary>
                    /// <para>The label.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>nonLable</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <para>The risk level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>low</para>
                    /// </summary>
                    [NameInMap("Level")]
                    [Validation(Required=false)]
                    public string Level { get; set; }

                }

                /// <summary>
                /// <para>The suggested action.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pass</para>
                /// </summary>
                [NameInMap("Suggestion")]
                [Validation(Required=false)]
                public string Suggestion { get; set; }

                /// <summary>
                /// <para>The category.</para>
                /// 
                /// <b>Example:</b>
                /// <para>contentModeration</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The suggested action.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pass</para>
            /// </summary>
            [NameInMap("Suggestion")]
            [Validation(Required=false)]
            public string Suggestion { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
