// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDeploymentPackagesRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account UID of the deployment package creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>110755000425****</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The maximum timestamp in milliseconds for the creation time of the deployment package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1593877765000</para>
        /// </summary>
        [NameInMap("EndCreateTime")]
        [Validation(Required=false)]
        public long? EndCreateTime { get; set; }

        /// <summary>
        /// <para>The maximum timestamp in milliseconds for the execution start time of the deployment package.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1593877765000</para>
        /// </summary>
        [NameInMap("EndExecuteTime")]
        [Validation(Required=false)]
        public long? EndExecuteTime { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account UID of the deployment package executor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2003****</para>
        /// </summary>
        [NameInMap("Executor")]
        [Validation(Required=false)]
        public string Executor { get; set; }

        /// <summary>
        /// <para>The keyword in the deployment package name. DataWorks supports fuzzy match. You can enter a keyword to query deployment packages whose names contain the keyword.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abc</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The page number.</para>
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
        /// <para>The ID of the DataWorks workspace. You can log on to the DataWorks console and go to the workspace configuration page to obtain the workspace ID. You must specify either this parameter or the ProjectIdentifier parameter to determine the DataWorks workspace for this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10003</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the DataWorks workspace, which is the English identifier displayed in the workspace switcher at the top of the DataStudio page. You must specify either this parameter or the ProjectId parameter to determine the DataWorks workspace for this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// <para>The current status of the deployment package. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: The deployment package is ready.</description></item>
        /// <item><description>1: The deployment package is published.</description></item>
        /// <item><description>2: The deployment package failed to be published.</description></item>
        /// <item><description>6: The deployment package is rejected.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
