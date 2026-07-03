// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeDataSourceParametersResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeDataSourceParametersResponseBodyData> Data { get; set; }
        public class DescribeDataSourceParametersResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the parameter is editable. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: The parameter cannot be modified.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: The parameter can be modified.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>wafApi</para>
            /// </summary>
            [NameInMap("CanEditted")]
            [Validation(Required=false)]
            public int? CanEditted { get; set; }

            /// <summary>
            /// <para>The code for the multicloud environment. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>qcloud</b>: Tencent Cloud.</para>
            /// </description></item>
            /// <item><description><para><b>aliyun</b>: Alibaba Cloud.</para>
            /// </description></item>
            /// <item><description><para><b>hcloud</b>: Huawei Cloud.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>hcloud</para>
            /// </summary>
            [NameInMap("CloudCode")]
            [Validation(Required=false)]
            public string CloudCode { get; set; }

            /// <summary>
            /// <para>The type of the data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>obs</b>: Huawei Cloud OBS.</para>
            /// </description></item>
            /// <item><description><para><b>wafApi</b>: Tencent Cloud WAF download API.</para>
            /// </description></item>
            /// <item><description><para><b>ckafka</b>: Tencent Cloud CKafka.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>obs</para>
            /// </summary>
            [NameInMap("DataSourceType")]
            [Validation(Required=false)]
            public string DataSourceType { get; set; }

            /// <summary>
            /// <para>The default value of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wafApi</para>
            /// </summary>
            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            /// <summary>
            /// <para>Indicates whether the parameter can be modified. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The parameter cannot be modified.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The parameter can be modified.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>wafApi</para>
            /// </summary>
            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            /// <summary>
            /// <para>The format check method.</para>
            /// 
            /// <b>Example:</b>
            /// <para>email</para>
            /// </summary>
            [NameInMap("FormatCheck")]
            [Validation(Required=false)]
            public string FormatCheck { get; set; }

            /// <summary>
            /// <para>Additional information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>obs docment</para>
            /// </summary>
            [NameInMap("Hit")]
            [Validation(Required=false)]
            public string Hit { get; set; }

            /// <summary>
            /// <para>The code of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>region_code</para>
            /// </summary>
            [NameInMap("ParaCode")]
            [Validation(Required=false)]
            public string ParaCode { get; set; }

            /// <summary>
            /// <para>The level of the parameter. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: data source parameter.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: log parameter.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ParaLevel")]
            [Validation(Required=false)]
            public int? ParaLevel { get; set; }

            /// <summary>
            /// <para>The name of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>region local</para>
            /// </summary>
            [NameInMap("ParaName")]
            [Validation(Required=false)]
            public string ParaName { get; set; }

            /// <summary>
            /// <para>The type of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("ParaType")]
            [Validation(Required=false)]
            public string ParaType { get; set; }

            /// <summary>
            /// <para>The list of parameters.</para>
            /// </summary>
            [NameInMap("ParamValue")]
            [Validation(Required=false)]
            public List<DescribeDataSourceParametersResponseBodyDataParamValue> ParamValue { get; set; }
            public class DescribeDataSourceParametersResponseBodyDataParamValue : TeaModel {
                /// <summary>
                /// <para>The displayed content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>guangzhou</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>The actual value of the parameter.</para>
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
            /// <item><description><para><b>1</b>: The parameter is required.</para>
            /// </description></item>
            /// <item><description><para><b>0</b>: The parameter is optional.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>string</para>
            /// </summary>
            [NameInMap("Required")]
            [Validation(Required=false)]
            public int? Required { get; set; }

            /// <summary>
            /// <para>The prompt for the parameter value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>obs bucket name</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6276D891-*****-55B2-87B9-74D413F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
