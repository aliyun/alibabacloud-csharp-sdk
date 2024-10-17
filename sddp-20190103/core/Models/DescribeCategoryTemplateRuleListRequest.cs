// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeCategoryTemplateRuleListRequest : TeaModel {
        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

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
        /// <para>The number of entries to return on each page. Default value: <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The sensitivity level of the data that is not compliant with the rule. Valid values: <b>1</b> to <b>11</b>. Default value: <b>null</b>.</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: No sensitive data is detected.</description></item>
        /// <item><description><b>2</b>: specifies the S1 sensitivity level.</description></item>
        /// <item><description><b>3</b>: specifies the S2 sensitivity level.</description></item>
        /// <item><description><b>4</b>: specifies the S3 sensitivity level.</description></item>
        /// <item><description><b>5</b>: specifies the S4 sensitivity level.</description></item>
        /// <item><description><b>6</b>: specifies the S5 sensitivity level.</description></item>
        /// <item><description><b>7</b>: specifies the S6 sensitivity level.</description></item>
        /// <item><description><b>8</b>: specifies the S7 sensitivity level.</description></item>
        /// <item><description><b>9</b>: specifies the S8 sensitivity level.</description></item>
        /// <item><description><b>10</b>: specifies the S9 sensitivity level.</description></item>
        /// <item><description><b>11</b>: specifies the S10 sensitivity level.</description></item>
        /// <item><description><b>null</b>: specifies all preceding sensitivity levels.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RiskLevelId")]
        [Validation(Required=false)]
        public long? RiskLevelId { get; set; }

        /// <summary>
        /// <para>The status of the rule. Default value: <b>null</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: disabled</description></item>
        /// <item><description><b>1</b>: enabled</description></item>
        /// <item><description><b>null</b>: all states</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
