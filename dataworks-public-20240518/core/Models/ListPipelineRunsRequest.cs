// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListPipelineRunsRequest : TeaModel {
        /// <summary>
        /// <para>Filters the results by the creator of the pipeline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>110755000425****</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The ID of the artifact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>860438872620113XXXX</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. The default value is 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the DataWorks workspace. You can obtain this ID from the Workspace Management page in the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a>.</para>
        /// <para>This parameter specifies the DataWorks workspace to use for the API call.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>Filters the results by the current status of the pipeline.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Init</c>: initializing</para>
        /// </description></item>
        /// <item><description><para><c>Running</c>: running</para>
        /// </description></item>
        /// <item><description><para><c>Success</c>: succeeded</para>
        /// </description></item>
        /// <item><description><para><c>Fail</c>: failed</para>
        /// </description></item>
        /// <item><description><para><c>Termination</c>: terminated</para>
        /// </description></item>
        /// <item><description><para><c>Cancel</c>: canceled</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
