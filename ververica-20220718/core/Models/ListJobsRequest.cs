// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class ListJobsRequest : TeaModel {
        /// <summary>
        /// <para>The deployment ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58718c99-3b29-4c5e-93bb-c9fc4ec6****</para>
        /// </summary>
        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// <para>The page number. Minimum value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The collation.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>gmt_create</description></item>
        /// <item><description>job_id</description></item>
        /// <item><description>status</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>gmt_create</para>
        /// </summary>
        [NameInMap("sortName")]
        [Validation(Required=false)]
        public string SortName { get; set; }

    }

}
