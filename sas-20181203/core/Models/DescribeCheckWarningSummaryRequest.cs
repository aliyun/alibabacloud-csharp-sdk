// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeCheckWarningSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the container cluster to query.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeGroupedContainerInstances~~">DescribeGroupedContainerInstances</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>c80dae73bd1be442699766b14ffd0****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The container field. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>clusterId</b>: cluster ID</description></item>
        /// <item><description><b>image</b>: image name</description></item>
        /// <item><description><b>imageId</b>: image ID</description></item>
        /// <item><description><b>namespace</b>: namespace.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>namespace</para>
        /// </summary>
        [NameInMap("ContainerFieldName")]
        [Validation(Required=false)]
        public string ContainerFieldName { get; set; }

        /// <summary>
        /// <para>The value of the container field.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c819391d2d520485fa3e81e2dc2ea****</para>
        /// </summary>
        [NameInMap("ContainerFieldValue")]
        [Validation(Required=false)]
        public string ContainerFieldValue { get; set; }

        /// <summary>
        /// <para>The page number for a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The group ID of the server to query.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeAllGroups~~">DescribeAllGroups</a> operation to obtain the group ID of the server.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page for a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the baseline check risk item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Redis</para>
        /// </summary>
        [NameInMap("RiskName")]
        [Validation(Required=false)]
        public string RiskName { get; set; }

        /// <summary>
        /// <para>The status of the baseline check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: failed </description></item>
        /// <item><description><b>3</b>: passed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RiskStatus")]
        [Validation(Required=false)]
        public int? RiskStatus { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>219.133.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The status of the check item. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: failed</description></item>
        /// <item><description><b>2</b>: verifying </description></item>
        /// <item><description><b>3</b>: passed </description></item>
        /// <item><description><b>5</b>: expired </description></item>
        /// <item><description><b>6</b>: ignored.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the baseline check policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public long? StrategyId { get; set; }

        /// <summary>
        /// <para>The query type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>uuid</b>: asset ID.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>uuid</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The level-1 type of the baseline.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeRiskType~~">DescribeRiskType</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>database</para>
        /// </summary>
        [NameInMap("TypeName")]
        [Validation(Required=false)]
        public string TypeName { get; set; }

        /// <summary>
        /// <para>The UUID of the asset.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>f03259d8-1e81-4fae-bcbb-275fb5****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
