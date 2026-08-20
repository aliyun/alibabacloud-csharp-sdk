// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Market20151101.Models
{
    public class DescribeCurrentNodeInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00eb4de1-6cff-4f56-833e-7b1e070e398d</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The process node information returned upon success.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeCurrentNodeInfoResponseBodyResult Result { get; set; }
        public class DescribeCurrentNodeInfoResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Indicates whether rollback to the previous process node is allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AllowRollbackNode")]
            [Validation(Required=false)]
            public bool? AllowRollbackNode { get; set; }

            /// <summary>
            /// <para>Indicates whether the node is automatically completed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AutoFinishNode")]
            [Validation(Required=false)]
            public bool? AutoFinishNode { get; set; }

            /// <summary>
            /// <para>The sequence number of the last node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("FinalStepNo")]
            [Validation(Required=false)]
            public int? FinalStepNo { get; set; }

            /// <summary>
            /// <para>The timeout of the process node. The value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1588920725000</para>
            /// </summary>
            [NameInMap("GmtExpired")]
            [Validation(Required=false)]
            public long? GmtExpired { get; set; }

            /// <summary>
            /// <para>The completion time of the process node. The value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1588920725000</para>
            /// </summary>
            [NameInMap("GmtFinished")]
            [Validation(Required=false)]
            public long? GmtFinished { get; set; }

            /// <summary>
            /// <para>The start time of the process node. The value is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1588834325000</para>
            /// </summary>
            [NameInMap("GmtStart")]
            [Validation(Required=false)]
            public long? GmtStart { get; set; }

            /// <summary>
            /// <para>Indicates whether uploading an attachment is mandatory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NeedAttachment")]
            [Validation(Required=false)]
            public bool? NeedAttachment { get; set; }

            /// <summary>
            /// <para>The ID of the next process node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8473</para>
            /// </summary>
            [NameInMap("NextNodeId")]
            [Validation(Required=false)]
            public long? NextNodeId { get; set; }

            /// <summary>
            /// <para>The ID of the process node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8472</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public long? NodeId { get; set; }

            /// <summary>
            /// <para>The name of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>等待服务开通</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The execution status of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NotStart: not started.</description></item>
            /// <item><description>Starting: in progress.</description></item>
            /// <item><description>Cancel: canceled.</description></item>
            /// <item><description>Finish: completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Starting</para>
            /// </summary>
            [NameInMap("NodeStatus")]
            [Validation(Required=false)]
            public string NodeStatus { get; set; }

            /// <summary>
            /// <para>The role of the operator for the process node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>system: system.</description></item>
            /// <item><description>custom: user.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Provider</para>
            /// </summary>
            [NameInMap("OperatorRole")]
            [Validation(Required=false)]
            public string OperatorRole { get; set; }

            /// <summary>
            /// <para>The ID of the parent process node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ParentNodeId")]
            [Validation(Required=false)]
            public long? ParentNodeId { get; set; }

            /// <summary>
            /// <para>The ID of the previous process node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8471</para>
            /// </summary>
            [NameInMap("PreviousNodeId")]
            [Validation(Required=false)]
            public long? PreviousNodeId { get; set; }

            /// <summary>
            /// <para>The sequence number of the process node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("StepNo")]
            [Validation(Required=false)]
            public int? StepNo { get; set; }

            /// <summary>
            /// <para>The form content of the process node in JSON format.
            /// Sample code:
            /// <c>[ { &quot;fieldKey&quot;: &quot;TFD0&quot;, //form key &quot;isRequired&quot;: true, //whether the field is required &quot;maxLength&quot;: 50, //maximum length &quot;placeHolder&quot;: &quot;姓名&quot;, //form value description &quot;stepNum&quot;: 0, //sort value (ascending) &quot;title&quot;: &quot;收货人姓名&quot;, //form title &quot;type&quot;: &quot;text&quot; //form type }, { &quot;fieldKey&quot;: &quot;TFD1&quot;, &quot;isRequired&quot;: true, &quot;maxLength&quot;: 50, &quot;placeHolder&quot;: &quot;手机号码&quot;, &quot;stepNum&quot;: 1, &quot;title&quot;: &quot;收货人电话&quot;, &quot;type&quot;: &quot;text&quot; }, { &quot;fieldKey&quot;: &quot;TFD2&quot;, &quot;isRequired&quot;: true, &quot;maxLength&quot;: 50, &quot;placeHolder&quot;: &quot;省市区街道门牌号码&quot;, &quot;stepNum&quot;: 2, &quot;title&quot;: &quot;详细收货地址&quot;, &quot;type&quot;: &quot;textarea&quot; } ]</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[ {&quot;fieldKey&quot;: &quot;TFD0&quot;,&quot;isRequired&quot;: true,&quot;maxLength&quot;: 50, &quot;placeHolder&quot;: &quot;姓名&quot;,&quot;stepNum&quot;: 0,&quot;title&quot;: &quot;收货人姓名&quot;,&quot;type&quot;: &quot;text&quot; },{ &quot;fieldKey&quot;: &quot;TFD1&quot;,&quot;isRequired&quot;: true,&quot;maxLength&quot;: 50,&quot;placeHolder&quot;: &quot;手机号码&quot;,&quot;stepNum&quot;: 1,&quot;title&quot;: &quot;收货人电话&quot;,&quot;type&quot;: &quot;text&quot;},{&quot;fieldKey&quot;: &quot;TFD2&quot;,&quot;isRequired&quot;: true,&quot;maxLength&quot;: 50,&quot;placeHolder&quot;: &quot;省市区街道门牌号码&quot;,&quot;stepNum&quot;: 2,&quot;title&quot;: &quot;详细收货地址&quot;,&quot;type&quot;: &quot;textarea&quot;}]</para>
            /// </summary>
            [NameInMap("TemplateForm")]
            [Validation(Required=false)]
            public string TemplateForm { get; set; }

        }

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
