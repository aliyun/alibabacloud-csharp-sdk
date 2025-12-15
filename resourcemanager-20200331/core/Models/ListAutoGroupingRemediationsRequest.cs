// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListAutoGroupingRemediationsRequest : TeaModel {
        /// <summary>
        /// <para>The earliest remediation time. This parameter is empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-01-01 00:00:00</para>
        /// </summary>
        [NameInMap("EarliestRemediationTime")]
        [Validation(Required=false)]
        public string EarliestRemediationTime { get; set; }

        /// <summary>
        /// <para>The latest remediation time. This parameter is empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-01 00:00:00</para>
        /// </summary>
        [NameInMap("LatestRemediationTime")]
        [Validation(Required=false)]
        public string LatestRemediationTime { get; set; }

        /// <summary>
        /// <para>The maximum number of data entries to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. If you leave this parameter empty, the query starts from the beginning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TGlzdFJlc291cm****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The resource ID,</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-23v38****</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type,</para>
        /// <para>You can obtain the resource type from the <b>Resource type</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Services that work with Resource Group</a>.</para>
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
        /// <para>The ID of the Alibaba Cloud service.</para>
        /// <para>You can obtain the ID from the <b>Service code</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Services that work with Resource Group</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ecs</para>
        /// </summary>
        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        /// <summary>
        /// <para>The ID of the new resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekz26emqhc****</para>
        /// </summary>
        [NameInMap("TargetResourceGroupId")]
        [Validation(Required=false)]
        public string TargetResourceGroupId { get; set; }

    }

}
