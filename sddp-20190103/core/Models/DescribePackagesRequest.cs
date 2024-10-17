// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribePackagesRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The ID of the instance to which the package belongs.</para>
        /// <remarks>
        /// <para>You can call the <b>DescribeInstances</b> operation to query the ID of the instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12321</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh_cn</b>: Chinese</description></item>
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
        /// <para>The search keyword. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the service to which the package belongs.</para>
        /// <remarks>
        /// <para>You can call the <b>DescribeDataAssets</b> operation to query the ID of the service.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2566600</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <para>The sensitivity level of the package. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: N/A, which indicates that no sensitive data is detected.</description></item>
        /// <item><description><b>2</b>: S1, which indicates the low sensitivity level.</description></item>
        /// <item><description><b>3</b>: S2, which indicates the medium sensitivity level.</description></item>
        /// <item><description><b>4</b>: S3, which indicates the high sensitivity level.</description></item>
        /// <item><description><b>5</b>: S4, which indicates the highest sensitivity level.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RiskLevelId")]
        [Validation(Required=false)]
        public long? RiskLevelId { get; set; }

        /// <summary>
        /// <para>The ID of the sensitive data detection rule that the package hits.</para>
        /// <remarks>
        /// <para>You can call the <b>DescribeRules</b> operation to query the ID of the sensitive data detection rule.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>266666</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

    }

}
