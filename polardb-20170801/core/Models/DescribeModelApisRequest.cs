// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeModelApisRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the gateway instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pg-xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("GwClusterId")]
        [Validation(Required=false)]
        public string GwClusterId { get; set; }

        /// <summary>
        /// <para>The IDs of the model APIs. Separate multiple IDs with a comma.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mi-xxx,mi-xxxx</para>
        /// </summary>
        [NameInMap("ModelApiIds")]
        [Validation(Required=false)]
        public string ModelApiIds { get; set; }

        /// <summary>
        /// <para>The model category. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>text</b></para>
        /// </description></item>
        /// <item><description><para><b>embedding</b></para>
        /// </description></item>
        /// <item><description><para><b>rerank</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("ModelCategory")]
        [Validation(Required=false)]
        public string ModelCategory { get; set; }

        /// <summary>
        /// <para>The name of the model API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testName</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
        /// <para>The number of entries per page. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>30</b></para>
        /// </description></item>
        /// <item><description><para><b>50</b></para>
        /// </description></item>
        /// <item><description><para><b>100</b>
        /// The default value is <b>30</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The API path prefix.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/test</para>
        /// </summary>
        [NameInMap("PathPrefix")]
        [Validation(Required=false)]
        public string PathPrefix { get; set; }

        /// <summary>
        /// <para>The protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>openai</b></para>
        /// </description></item>
        /// <item><description><para><b>anthropic</b></para>
        /// </description></item>
        /// <item><description><para><b>bailian</b></para>
        /// </description></item>
        /// <item><description><para><b>vllm</b></para>
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
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The model API status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
