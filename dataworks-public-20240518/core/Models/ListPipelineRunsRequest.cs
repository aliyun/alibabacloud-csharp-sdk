// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListPipelineRunsRequest : TeaModel {
        /// <summary>
        /// <para>The creator of the deployment pipeline. This parameter is used as a filter condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>110755000425****</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The ID of the deployment object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>860438872620113XXXX</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
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
        /// <para>The ID of the DataWorks workspace. You can logon to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the workspace management page to obtain the ID.</para>
        /// <para>This parameter specifies the DataWorks workspace for the current API invoke operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The current status of the deployment pipeline. This parameter is used as a filter condition.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Init: Initialized.</description></item>
        /// <item><description>Running: Running.</description></item>
        /// <item><description>Success: Succeeded.</description></item>
        /// <item><description>Fail: Failed.</description></item>
        /// <item><description>Termination: Terminated.</description></item>
        /// <item><description>Cancel: Canceled.</description></item>
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
