// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class GetEventsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the deployed job. If you specify this parameter, the operation returns events only for this job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>58718c99-3b29-4c5e-93bb-c9fc4ec6****</para>
        /// </summary>
        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        [NameInMap("deploymentName")]
        [Validation(Required=false)]
        public string DeploymentName { get; set; }

        /// <summary>
        /// <para>The page number to retrieve. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
