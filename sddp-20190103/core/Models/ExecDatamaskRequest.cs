// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class ExecDatamaskRequest : TeaModel {
        /// <summary>
        /// <para>The sensitive data to be de-identified. The value is a JSON string that contains the following parameters:</para>
        /// <list type="bullet">
        /// <item><description><b>dataHeaderList</b>: the names of the columns in which data needs to be de-identified. Specify the column names in accordance with the order of data that needs to be de-identified.</description></item>
        /// <item><description><b>dataList</b>: the data that needs to be de-identified.</description></item>
        /// <item><description><b>ruleList</b>: the IDs of sensitive data detection rules used to detect data that needs to be de-identified. Specify the rule IDs in accordance with the order of data that needs to be de-identified. Each ID identifies a sensitive data detection rule that is used to detect a type of sensitive data. You can call the <a href="~~DescribeRules~~">DescribeRules</a> operation to query the IDs of sensitive data detection rules.</description></item>
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
        /// <para>1</para>
        /// </summary>
        [NameInMap("FeatureType")]
        [Validation(Required=false)]
        public int? FeatureType { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh_cn</b>: Simplified Chinese</description></item>
        /// <item><description><b>en_us</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The ID of the de-identification template. The ID is generated after you create the de-identification template in the <a href="https://yundun.console.aliyun.com/?%5C&p=sddpnext#/sddp/dm/template">Data Security Center (DSC) console</a>. You can choose <b>Data desensitization</b> &gt; <b>Desensitization Template</b> in the left-side navigation pane and obtain the ID of the de-identification template from the <b>Desensitization Template</b> page.</para>
        /// <list type="bullet">
        /// <item><description>If you select <b>Field name</b> as the matching mode of the template, DSC matches data based on the columns specified by the <b>dataHeaderList</b> parameter in the <b>Data</b> parameter.</description></item>
        /// <item><description>If you select <b>Sensitive type</b> as the matching mode of the template, DSC matches data based on the sensitive data detection rules specified by the <b>ruleList</b> parameter in the <b>Data</b> parameter.</description></item>
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
