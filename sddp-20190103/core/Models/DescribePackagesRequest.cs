// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribePackagesRequest : TeaModel {
        /// <summary>
        /// <para>The page number to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The ID of the asset instance to which the data asset package belongs.</para>
        /// <remarks>
        /// <para>To query the list of MaxCompute data asset packages that are authorized for an SDPP connection by instance ID, call the <b>DescribeInstances</b> operation to obtain the instance ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12321</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public long? InstanceId { get; set; }

        /// <summary>
        /// <para>The language of the request and response. The default value is <b>zh_cn</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh_cn</b>: Chinese.</para>
        /// </description></item>
        /// <item><description><para><b>en_us</b>: English.</para>
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
        /// <para>The keyword for the search. Fuzzy matching is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the product to which the data asset package belongs.</para>
        /// <remarks>
        /// <para>To query the list of MaxCompute data asset packages that are authorized for an SDPP connection by product ID, call the <b>DescribeDataAssets</b> operation to obtain the product ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2566600</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public long? ProductId { get; set; }

        /// <summary>
        /// <para>The ID of the risk level for the data asset package.</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: N/A: No sensitive data is detected.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: S1: Level 1 sensitive data.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: S2: Level 2 sensitive data.</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: S3: Level 3 sensitive data.</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: S4: Level 4 sensitive data.</para>
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
        /// <para>The ID of the sensitive data detection rule that the data asset package matches.</para>
        /// <remarks>
        /// <para>To query the list of MaxCompute data asset packages that are authorized for an SDPP connection by the ID of a matching sensitive data detection rule, call the <b>DescribeRules</b> operation to obtain the rule ID.</para>
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
