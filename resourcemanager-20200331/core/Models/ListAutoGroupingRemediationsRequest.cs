// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListAutoGroupingRemediationsRequest : TeaModel {
        /// <summary>
        /// <para>The earliest time. This parameter is empty by default. The format is YYYY-MM-DD HH:mm:ss without a time zone identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("EarliestRemediationTime")]
        [Validation(Required=false)]
        public string EarliestRemediationTime { get; set; }

        /// <summary>
        /// <para>The latest time. This parameter is empty by default. The format is YYYY-MM-DD HH:mm:ss without a time zone identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-01 00:00:00</para>
        /// </summary>
        [NameInMap("LatestRemediationTime")]
        [Validation(Required=false)]
        public string LatestRemediationTime { get; set; }

        /// <summary>
        /// <para>The maximum number of records to return in this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that marks the position from which to start reading. If this parameter is left empty, data is read from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cm****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The resource ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-23v38****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type.</para>
        /// <para>You can obtain the resource type from the <b>Resource Type</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Cloud services that support resource groups</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The rule ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gr-acfnugygwms32yy</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// <para>The cloud service ID.</para>
        /// <para>You can obtain the cloud service ID from the <b>Cloud Service Code</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Cloud services that support resource groups</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>The ID of the target resource group for remediation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekz26emqhc****</para>
        /// </summary>
        [NameInMap("TargetResourceGroupId")]
        [Validation(Required=false)]
        public string TargetResourceGroupId { get; set; }

    }

}
