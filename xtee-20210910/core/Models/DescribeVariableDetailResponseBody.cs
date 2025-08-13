// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeVariableDetailResponseBody : TeaModel {
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
        /// <para>Return object</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeVariableDetailResponseBodyResultObject ResultObject { get; set; }
        public class DescribeVariableDetailResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>Basic attributes.</para>
            /// </summary>
            [NameInMap("baseInfo")]
            [Validation(Required=false)]
            public DescribeVariableDetailResponseBodyResultObjectBaseInfo BaseInfo { get; set; }
            public class DescribeVariableDetailResponseBodyResultObjectBaseInfo : TeaModel {
                /// <summary>
                /// <para>Whether variable binding is allowed</para>
                /// 
                /// <b>Example:</b>
                /// <para>ENABLE</para>
                /// </summary>
                [NameInMap("allowBind")]
                [Validation(Required=false)]
                public string AllowBind { get; set; }

                /// <summary>
                /// <para>Charging mode</para>
                /// 
                /// <b>Example:</b>
                /// <para>FREE</para>
                /// </summary>
                [NameInMap("chargingMode")]
                [Validation(Required=false)]
                public string ChargingMode { get; set; }

                /// <summary>
                /// <para>Charging mode description</para>
                /// 
                /// <b>Example:</b>
                /// <para>免费</para>
                /// </summary>
                [NameInMap("chargingModeDesc")]
                [Validation(Required=false)]
                public string ChargingModeDesc { get; set; }

                /// <summary>
                /// <para>Creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>176020</para>
                /// </summary>
                [NameInMap("creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>Data distribution display, in JSON format</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>Data valid range, left-closed and right-closed</para>
                /// 
                /// <b>Example:</b>
                /// <para>(0,10)</para>
                /// </summary>
                [NameInMap("dataThreshold")]
                [Validation(Required=false)]
                public string DataThreshold { get; set; }

                /// <summary>
                /// <para>Deduction factor</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("deductionFactor")]
                [Validation(Required=false)]
                public int? DeductionFactor { get; set; }

                /// <summary>
                /// <para>Description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>描述</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Front-end binding allowed</para>
                /// 
                /// <b>Example:</b>
                /// <para>ENABLE</para>
                /// </summary>
                [NameInMap("frontAllowBind")]
                [Validation(Required=false)]
                public string FrontAllowBind { get; set; }

                /// <summary>
                /// <para>Creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1698143758000</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>Modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1698143758000</para>
                /// </summary>
                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <para>Primary key ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>3144</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Required parameters</para>
                /// <pre><c> When inputRequired=__all__, it means all parameters are required
                ///  When inputRequired=__one__, it means only one input is needed
                ///  Required fields are separated by commas, e.g., mobile,ip,email
                /// </c></pre>
                /// 
                /// <b>Example:</b>
                /// <para><b>one</b></para>
                /// </summary>
                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                /// <summary>
                /// <para>Input parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ip,age,mobile</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>Input parameter description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ip,年龄,手机号</para>
                /// </summary>
                [NameInMap("inputsDesc")]
                [Validation(Required=false)]
                public string InputsDesc { get; set; }

                /// <summary>
                /// <para>Invoke key</para>
                /// 
                /// <b>Example:</b>
                /// <para>onlineScamDetectionTags_v</para>
                /// </summary>
                [NameInMap("invokeKey")]
                [Validation(Required=false)]
                public string InvokeKey { get; set; }

                /// <summary>
                /// <para>Invoke RT, unit: milliseconds</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("invokeRt")]
                [Validation(Required=false)]
                public int? InvokeRt { get; set; }

                /// <summary>
                /// <para>Invocation success rate</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("invokeSuccessRate")]
                [Validation(Required=false)]
                public string InvokeSuccessRate { get; set; }

                /// <summary>
                /// <para>Number of invocations</para>
                /// 
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("invokeTimes")]
                [Validation(Required=false)]
                public long? InvokeTimes { get; set; }

                /// <summary>
                /// <para>Last modifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>root</para>
                /// </summary>
                [NameInMap("lastModifiedOperator")]
                [Validation(Required=false)]
                public string LastModifiedOperator { get; set; }

                /// <summary>
                /// <para>Variable name</para>
                /// 
                /// <b>Example:</b>
                /// <para><b>onlineScamDetectionTags</b></para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Output</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("outputs")]
                [Validation(Required=false)]
                public string Outputs { get; set; }

                /// <summary>
                /// <para>Output description</para>
                /// 
                /// <b>Example:</b>
                /// <para>字符串</para>
                /// </summary>
                [NameInMap("outputsDesc")]
                [Validation(Required=false)]
                public string OutputsDesc { get; set; }

                /// <summary>
                /// <para>Code of applicable scenarios</para>
                /// </summary>
                [NameInMap("scene")]
                [Validation(Required=false)]
                public List<string> Scene { get; set; }

                /// <summary>
                /// <para>Applicable scenario description</para>
                /// </summary>
                [NameInMap("sceneDesc")]
                [Validation(Required=false)]
                public List<string> SceneDesc { get; set; }

                /// <summary>
                /// <para>Display order</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("showOrder")]
                [Validation(Required=false)]
                public string ShowOrder { get; set; }

                /// <summary>
                /// <para>Source</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAF</para>
                /// </summary>
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>Source description</para>
                /// 
                /// <b>Example:</b>
                /// <para>风险识别</para>
                /// </summary>
                [NameInMap("sourceDesc")]
                [Validation(Required=false)]
                public string SourceDesc { get; set; }

                /// <summary>
                /// <para>Status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ENABLE</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>List of supported regions.</para>
                /// </summary>
                [NameInMap("supportRegions")]
                [Validation(Required=false)]
                public List<string> SupportRegions { get; set; }

                /// <summary>
                /// <para>Title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>诈骗引流识别_标签</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>Type</para>
                /// 
                /// <b>Example:</b>
                /// <para>NATIVE</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>Category description</para>
                /// 
                /// <b>Example:</b>
                /// <para>事件字段</para>
                /// </summary>
                [NameInMap("typeDesc")]
                [Validation(Required=false)]
                public string TypeDesc { get; set; }

                /// <summary>
                /// <para>X-axis label for data distribution display</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>Data distribution display y-axis label</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("yLabel")]
                [Validation(Required=false)]
                public string YLabel { get; set; }

            }

        }

    }

}
