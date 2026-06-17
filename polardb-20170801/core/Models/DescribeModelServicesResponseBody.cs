// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeModelServicesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the model services.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeModelServicesResponseBodyItems> Items { get; set; }
        public class DescribeModelServicesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The API key for the model service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxx</para>
            /// </summary>
            [NameInMap("ApiKey")]
            [Validation(Required=false)]
            public string ApiKey { get; set; }

            /// <summary>
            /// <para>The base URL of the upstream service.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://xxxxxx">https://xxxxxx</a></para>
            /// </summary>
            [NameInMap("BaseUrl")]
            [Validation(Required=false)]
            public string BaseUrl { get; set; }

            /// <summary>
            /// <para>The time when the model service was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-03-31T14:40:48Z</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The cost in points per million input tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("InputCostPointsPerMillion")]
            [Validation(Required=false)]
            public string InputCostPointsPerMillion { get; set; }

            /// <summary>
            /// <para>The model category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("ModelCategory")]
            [Validation(Required=false)]
            public string ModelCategory { get; set; }

            /// <summary>
            /// <para>The model service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ms-xxxxxx</para>
            /// </summary>
            [NameInMap("ModelServiceId")]
            [Validation(Required=false)]
            public string ModelServiceId { get; set; }

            /// <summary>
            /// <para>The model service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The cost in points per million output tokens.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("OutputCostPointsPerMillion")]
            [Validation(Required=false)]
            public string OutputCostPointsPerMillion { get; set; }

            /// <summary>
            /// <para>The protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>OpenAI</b></para>
            /// </description></item>
            /// <item><description><para><b>Anthropic</b></para>
            /// </description></item>
            /// <item><description><para><b>bailian</b>: Alibaba Cloud Model Studio.</para>
            /// </description></item>
            /// <item><description><para><b>vLLM</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>openai</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The cost in points per request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RequestCostPoints")]
            [Validation(Required=false)]
            public string RequestCostPoints { get; set; }

            /// <summary>
            /// <para>The status of the model service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Enable</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The vendor of the model service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bailian</para>
            /// </summary>
            [NameInMap("Vendor")]
            [Validation(Required=false)]
            public string Vendor { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of records on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The number of records to return on each page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>30</b></para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b></para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <b>30</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A1990B-4F6E-482B-B8CB-75C612******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
