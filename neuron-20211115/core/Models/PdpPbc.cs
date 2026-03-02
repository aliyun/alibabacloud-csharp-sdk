// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class PdpPbc : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>基础商品</para>
        /// </summary>
        [NameInMap("alias")]
        [Validation(Required=false)]
        public string Alias { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>多端商城</para>
        /// </summary>
        [NameInMap("company")]
        [Validation(Required=false)]
        public string Company { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("companyId")]
        [Validation(Required=false)]
        public long? CompanyId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>基础商品描述</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("developerId")]
        [Validation(Required=false)]
        public string DeveloperId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>neuron-pdp-pbc</para>
        /// </summary>
        [NameInMap("gitGroup")]
        [Validation(Required=false)]
        public string GitGroup { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;path&quot;:&quot;neuron-pdp-pbc&quot;,&quot;webUrl&quot;:&quot;<a href="https://codeup.aliyun.com/616d751bbc23ecd311af9711/neuron-pdp-pbc%22,%22name%22:%22neuron-pdp-pbc%22,%22id%22:480037,%22ownerId%22:663171,%22pathWithNamespace%22:%22616d751bbc23ecd311af9711/neuron-pdp-pbc%22,%22parentId%22:330007%7D">https://codeup.aliyun.com/616d751bbc23ecd311af9711/neuron-pdp-pbc&quot;,&quot;name&quot;:&quot;neuron-pdp-pbc&quot;,&quot;id&quot;:480037,&quot;ownerId&quot;:663171,&quot;pathWithNamespace&quot;:&quot;616d751bbc23ecd311af9711/neuron-pdp-pbc&quot;,&quot;parentId&quot;:330007}</a></para>
        /// </summary>
        [NameInMap("gitGroupInfo")]
        [Validation(Required=false)]
        public string GitGroupInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2022-05-01T00:00:00.000Z</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>product</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("snowbergDisplay")]
        [Validation(Required=false)]
        public bool? SnowbergDisplay { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>INNER</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
