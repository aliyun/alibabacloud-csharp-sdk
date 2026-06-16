// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtee20210910.Models
{
    public class DescribeVariableDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A32FE941-35F2-5378-B37C-4B8FDB16F094</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The returned object.</para>
        /// </summary>
        [NameInMap("resultObject")]
        [Validation(Required=false)]
        public DescribeVariableDetailResponseBodyResultObject ResultObject { get; set; }
        public class DescribeVariableDetailResponseBodyResultObject : TeaModel {
            /// <summary>
            /// <para>The basic properties.</para>
            /// </summary>
            [NameInMap("baseInfo")]
            [Validation(Required=false)]
            public DescribeVariableDetailResponseBodyResultObjectBaseInfo BaseInfo { get; set; }
            public class DescribeVariableDetailResponseBodyResultObjectBaseInfo : TeaModel {
                /// <summary>
                /// <para>Specifies whether variable binding is allowed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>DISABLE</b>: unavailable</description></item>
                /// <item><description><b>ALL</b>: all</description></item>
                /// <item><description><b>ENABLE</b>: available</description></item>
                /// <item><description><b>PART_ENABLE</b>: partially available.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ENABLE</para>
                /// </summary>
                [NameInMap("allowBind")]
                [Validation(Required=false)]
                public string AllowBind { get; set; }

                /// <summary>
                /// <para>The billing mode. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PAY_PER_VIEW</b>: paid</description></item>
                /// <item><description><b>FREE</b>: free.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>FREE</para>
                /// </summary>
                [NameInMap("chargingMode")]
                [Validation(Required=false)]
                public string ChargingMode { get; set; }

                /// <summary>
                /// <para>The billing mode description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>免费</para>
                /// </summary>
                [NameInMap("chargingModeDesc")]
                [Validation(Required=false)]
                public string ChargingModeDesc { get; set; }

                /// <summary>
                /// <para>The creator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>176020</para>
                /// </summary>
                [NameInMap("creator")]
                [Validation(Required=false)]
                public string Creator { get; set; }

                /// <summary>
                /// <para>The data distribution display in JSON format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("dataDisplay")]
                [Validation(Required=false)]
                public string DataDisplay { get; set; }

                /// <summary>
                /// <para>The valid data range, inclusive on both ends.</para>
                /// 
                /// <b>Example:</b>
                /// <para>(0,10)</para>
                /// </summary>
                [NameInMap("dataThreshold")]
                [Validation(Required=false)]
                public string DataThreshold { get; set; }

                /// <summary>
                /// <para>The deduction coefficient.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("deductionFactor")]
                [Validation(Required=false)]
                public int? DeductionFactor { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>描述</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Specifies whether front-end binding is allowed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>DISABLE</b>: not allowed</description></item>
                /// <item><description><b>ENABLE</b>: allowed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ENABLE</para>
                /// </summary>
                [NameInMap("frontAllowBind")]
                [Validation(Required=false)]
                public string FrontAllowBind { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1698143758000</para>
                /// </summary>
                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                /// <summary>
                /// <para>The modification time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1698143758000</para>
                /// </summary>
                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3144</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The required parameters.</para>
                /// <para>When inputRequired is set to <b>all</b>, all parameters are required.
                /// When inputRequired is set to <b>one</b>, only one input parameter is required.
                /// Required fields are separated by commas, such as mobile,ip,email.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b>one</b></para>
                /// </summary>
                [NameInMap("inputRequired")]
                [Validation(Required=false)]
                public string InputRequired { get; set; }

                /// <summary>
                /// <para>The input parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ip,age,mobile</para>
                /// </summary>
                [NameInMap("inputs")]
                [Validation(Required=false)]
                public string Inputs { get; set; }

                /// <summary>
                /// <para>The input parameter description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ip,年龄,手机号</para>
                /// </summary>
                [NameInMap("inputsDesc")]
                [Validation(Required=false)]
                public string InputsDesc { get; set; }

                /// <summary>
                /// <para>The invocation key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>onlineScamDetectionTags_v</para>
                /// </summary>
                [NameInMap("invokeKey")]
                [Validation(Required=false)]
                public string InvokeKey { get; set; }

                /// <summary>
                /// <para>The invocation response time, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("invokeRt")]
                [Validation(Required=false)]
                public int? InvokeRt { get; set; }

                /// <summary>
                /// <para>The invocation success rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("invokeSuccessRate")]
                [Validation(Required=false)]
                public string InvokeSuccessRate { get; set; }

                /// <summary>
                /// <para>The number of invocations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("invokeTimes")]
                [Validation(Required=false)]
                public long? InvokeTimes { get; set; }

                /// <summary>
                /// <para>The last modifier.</para>
                /// 
                /// <b>Example:</b>
                /// <para>root</para>
                /// </summary>
                [NameInMap("lastModifiedOperator")]
                [Validation(Required=false)]
                public string LastModifiedOperator { get; set; }

                /// <summary>
                /// <para>The variable name.</para>
                /// 
                /// <b>Example:</b>
                /// <para><b>onlineScamDetectionTags</b></para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The outputs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STRING</para>
                /// </summary>
                [NameInMap("outputs")]
                [Validation(Required=false)]
                public string Outputs { get; set; }

                /// <summary>
                /// <para>The output description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>字符串</para>
                /// </summary>
                [NameInMap("outputsDesc")]
                [Validation(Required=false)]
                public string OutputsDesc { get; set; }

                /// <summary>
                /// <para>The applicable scenario code.</para>
                /// </summary>
                [NameInMap("scene")]
                [Validation(Required=false)]
                public List<string> Scene { get; set; }

                /// <summary>
                /// <para>The applicable scenario description.</para>
                /// </summary>
                [NameInMap("sceneDesc")]
                [Validation(Required=false)]
                public List<string> SceneDesc { get; set; }

                /// <summary>
                /// <para>The display order.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("showOrder")]
                [Validation(Required=false)]
                public string ShowOrder { get; set; }

                /// <summary>
                /// <para>The source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SAF</para>
                /// </summary>
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The source description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>风险识别</para>
                /// </summary>
                [NameInMap("sourceDesc")]
                [Validation(Required=false)]
                public string SourceDesc { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ENABLE</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The list of supported regions.</para>
                /// </summary>
                [NameInMap("supportRegions")]
                [Validation(Required=false)]
                public List<string> SupportRegions { get; set; }

                /// <summary>
                /// <para>The title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>诈骗引流识别_标签</para>
                /// </summary>
                [NameInMap("title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>NATIVE</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The category description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>事件字段</para>
                /// </summary>
                [NameInMap("typeDesc")]
                [Validation(Required=false)]
                public string TypeDesc { get; set; }

                /// <summary>
                /// <para>The X-axis label for the data distribution chart.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("xLabel")]
                [Validation(Required=false)]
                public string XLabel { get; set; }

                /// <summary>
                /// <para>The Y-axis label for the data distribution chart.</para>
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
