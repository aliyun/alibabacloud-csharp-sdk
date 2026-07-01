// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ListJobsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the deployment.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58718c99-3b29-4c5e-93bb-c9fc4ec6****</para>
        /// </summary>
        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// <para>The page number to return. Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100. Minimum value: 1. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The field to sort the results by.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gmt_create</para>
        /// </summary>
        [NameInMap("sortName")]
        [Validation(Required=false)]
        public string SortName { get; set; }

        [NameInMap("sortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

    }

}
