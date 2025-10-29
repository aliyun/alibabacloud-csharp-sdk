// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListDeploymentPackagesRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud account ID of the deployment package creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>110755000425****</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The maximum millisecond timestamp for when the deployment package was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1593877765000</para>
        /// </summary>
        [NameInMap("EndCreateTime")]
        [Validation(Required=false)]
        public long? EndCreateTime { get; set; }

        /// <summary>
        /// <para>The maximum millisecond timestamp for when the deployment package started executing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1593877765000</para>
        /// </summary>
        [NameInMap("EndExecuteTime")]
        [Validation(Required=false)]
        public long? EndExecuteTime { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the deployment package executor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2003****</para>
        /// </summary>
        [NameInMap("Executor")]
        [Validation(Required=false)]
        public string Executor { get; set; }

        /// <summary>
        /// <para>The keyword in the deployment package name. DataWorks supports fuzzy matching, meaning you can enter a keyword to query for deployment packages that contain it.</para>
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
        /// <para>The number of records per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The DataWorks workspace ID. You can log on to the DataWorks console and go to the workspace configuration page to query the ID. You must configure either this parameter or the ProjectIdentifier parameter to determine the DataWorks workspace to which the operation is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10003</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the DataWorks workspace, which is the identifier at the top of the Data Studio page where you switch workspaces. Either this parameter or ProjectId must be specified to determine which DataWorks workspace this API call operates on.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dw_project</para>
        /// </summary>
        [NameInMap("ProjectIdentifier")]
        [Validation(Required=false)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// <para>The status of the deployment package. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: It is ready.</description></item>
        /// <item><description>1: It was successfully deployed.</description></item>
        /// <item><description>2: It failed to be deployed.</description></item>
        /// <item><description>6: It was rejected.</description></item>
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
