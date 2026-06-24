// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ExecDatamaskRequest : TeaModel {
        /// <summary>
        /// <para>The data that you want to mask. The data must be a string in JSON format and include the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>dataHeaderList</b>: The column names of the data. The order of the column names must correspond to the order of the data that you want to mask.</para>
        /// </description></item>
        /// <item><description><para><b>dataList</b>: The data that you want to mask.</para>
        /// </description></item>
        /// <item><description><para><b>ruleList</b>: A list of sensitive data type IDs. The order of the IDs must correspond to the order of the data that you want to mask. Each ID is a number that represents a sensitive data type. You can call the <a href="https://help.aliyun.com/document_detail/410141.html">DescribeRules</a> operation to obtain the IDs.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;dataHeaderList&quot;:[&quot;name&quot;,&quot;age&quot;],&quot;dataList&quot;:[[&quot;lily&quot;,18],[&quot;lucy&quot;,17]],&quot;ruleList&quot;:[1002,null]}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh_cn</b>: Simplified Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en_us</b>: English (US)</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the data masking template. A template ID is generated after you create a template in the <a href="https://yundun.console.aliyun.com/?p=sddp#/dm/dmConfig/cn-zhangjiakou">Data Security Center console</a>. You can find the <b>Template ID</b> on the <b>Data Masking</b> &gt; <b>Masking Configuration</b> &gt; <b>Masking Template</b> page.</para>
        /// <list type="bullet">
        /// <item><description><para>If the matching type of the data masking template is <b>Field Name</b>, the system matches the data against <b>dataHeaderList</b> in <b>Data</b>.</para>
        /// </description></item>
        /// <item><description><para>If the matching type of the data masking template is <b>Sensitive Data Type</b>, the system matches the data against <b>ruleList</b> in <b>Data</b>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public long? TemplateId { get; set; }

    }

}
