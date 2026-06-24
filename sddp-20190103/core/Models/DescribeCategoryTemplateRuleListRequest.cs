// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeCategoryTemplateRuleListRequest : TeaModel {
        /// <summary>
        /// <para>The page number. The default value is <b>1</b>.</para>
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
        /// <para>The language of the request and response. The default value is <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh_cn</b>: Simplified Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en_us</b>: US English.</para>
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
        /// <para>The number of template rules to return on each page. The default value is <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The risk level of the template rule. The value ranges from <b>1</b> to <b>11</b>. The default value is <b>null</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: No risk.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: S1.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: S2.</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: S3.</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: S4.</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: S5.</para>
        /// </description></item>
        /// <item><description><para><b>7</b>: S6.</para>
        /// </description></item>
        /// <item><description><para><b>8</b>: S7.</para>
        /// </description></item>
        /// <item><description><para><b>9</b>: S8.</para>
        /// </description></item>
        /// <item><description><para><b>10</b>: S9.</para>
        /// </description></item>
        /// <item><description><para><b>11</b>: S10.</para>
        /// </description></item>
        /// <item><description><para><b>null</b>: All risk levels, including No risk, S1, S2, S3, S4, S5, S6, S7, S8, S9, and S10.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RiskLevelId")]
        [Validation(Required=false)]
        public long? RiskLevelId { get; set; }

        /// <summary>
        /// <para>The status of the template rule. The default value is <b>null</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: The rule is disabled.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: The rule is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>null</b>: All rules are returned, regardless of their status.</para>
        /// </description></item>
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
