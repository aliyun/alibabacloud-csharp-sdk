// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeDataSourceParametersResponseBody : TeaModel {
        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeDataSourceParametersResponseBodyData> Data { get; set; }
        public class DescribeDataSourceParametersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the parameter is editable. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Modification is disabled. </description></item>
            /// <item><description><b>1</b>: Modification is allowed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("CanEditted")]
            [Validation(Required=false)]
            public int? CanEditted { get; set; }

            /// <summary>
            /// <para>The multi-cloud code. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>qcloud</b>: Tencent Cloud.</description></item>
            /// <item><description><b>aliyun</b>: Alibaba Cloud.</description></item>
            /// <item><description><b>hcloud</b>: Huawei Cloud.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>hcloud</para>
            /// </summary>
            [NameInMap("CloudCode")]
            [Validation(Required=false)]
            public string CloudCode { get; set; }

            /// <summary>
            /// <para>The data source type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>obs</b>: Huawei Cloud OBS.</description></item>
            /// <item><description><b>wafApi</b>: Tencent Cloud WAF download API. </description></item>
            /// <item><description><b>ckafka</b>: Tencent Cloud CKafka.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>obs</para>
            /// </summary>
            [NameInMap("DataSourceType")]
            [Validation(Required=false)]
            public string DataSourceType { get; set; }

            /// <summary>
            /// <para>The default parameter value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wafApi</para>
            /// </summary>
            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            /// <summary>
            /// <para>Indicates whether modification is disabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Modification is disabled. </description></item>
            /// <item><description><b>false</b>: Modification is allowed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            /// <summary>
            /// <para>The format validation method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>email</para>
            /// </summary>
            [NameInMap("FormatCheck")]
            [Validation(Required=false)]
            public string FormatCheck { get; set; }

            /// <summary>
            /// <para>The additional description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>obs docment</para>
            /// </summary>
            [NameInMap("Hit")]
            [Validation(Required=false)]
            public string Hit { get; set; }

            /// <summary>
            /// <para>The parameter code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>region_code</para>
            /// </summary>
            [NameInMap("ParaCode")]
            [Validation(Required=false)]
            public string ParaCode { get; set; }

            /// <summary>
            /// <para>The parameter level. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Data source parameter.</description></item>
            /// <item><description><b>2</b>: Log parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ParaLevel")]
            [Validation(Required=false)]
            public int? ParaLevel { get; set; }

            /// <summary>
            /// <para>The parameter name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>region local</para>
            /// </summary>
            [NameInMap("ParaName")]
            [Validation(Required=false)]
            public string ParaName { get; set; }

            /// <summary>
            /// <para>The parameter type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("ParaType")]
            [Validation(Required=false)]
            public string ParaType { get; set; }

            /// <summary>
            /// <para>The specific parameter list.</para>
            /// </summary>
            [NameInMap("ParamValue")]
            [Validation(Required=false)]
            public List<DescribeDataSourceParametersResponseBodyDataParamValue> ParamValue { get; set; }
            public class DescribeDataSourceParametersResponseBodyDataParamValue : TeaModel {
                /// <summary>
                /// <para>The display content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>guangzhou</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The actual parameter content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ap-guangzhou</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether the parameter is required. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Required.</description></item>
            /// <item><description><b>0</b>: Optional.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Required")]
            [Validation(Required=false)]
            public int? Required { get; set; }

            /// <summary>
            /// <para>The parameter value hint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>obs bucket name</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
