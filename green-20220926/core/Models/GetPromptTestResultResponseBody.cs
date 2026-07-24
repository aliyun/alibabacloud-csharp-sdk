// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetPromptTestResultResponseBody : TeaModel {
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
        /// <para>The result.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<GetPromptTestResultResponseBodyResult> Result { get; set; }
        public class GetPromptTestResultResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试文本</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The labels.</para>
            /// </summary>
            [NameInMap("LabelDetails")]
            [Validation(Required=false)]
            public List<GetPromptTestResultResponseBodyResultLabelDetails> LabelDetails { get; set; }
            public class GetPromptTestResultResponseBodyResultLabelDetails : TeaModel {
                /// <summary>
                /// <para>The label description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>暴恐</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The labels.</para>
                /// 
                /// <b>Example:</b>
                /// <para>terrorism</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The reason why the model determined this risk level for the text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>该文本涉及暴力恐怖信息</para>
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

            }

            /// <summary>
            /// <para>The risk level, which is returned based on the configured high and low risk scores. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>high: High risk.</para>
            /// </description></item>
            /// <item><description><para>medium: Medium risk.</para>
            /// </description></item>
            /// <item><description><para>low: Low risk.</para>
            /// </description></item>
            /// <item><description><para>none: No risk detected.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

        }

    }

}
