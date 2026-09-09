// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListCrossProjectPipelineRunsRequest : TeaModel {
        /// <summary>
        /// <para>The start of the creation time range. This value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1788739200000</para>
        /// </summary>
        [NameInMap("CreateTimeFrom")]
        [Validation(Required=false)]
        public long? CreateTimeFrom { get; set; }

        /// <summary>
        /// <para>The end of the creation time range. This value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1788825599999</para>
        /// </summary>
        [NameInMap("CreateTimeTo")]
        [Validation(Required=false)]
        public long? CreateTimeTo { get; set; }

        /// <summary>
        /// <para>The creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>creator</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The cross-workspace publish environment ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("DeploymentEnvironmentId")]
        [Validation(Required=false)]
        public long? DeploymentEnvironmentId { get; set; }

        /// <summary>
        /// <para>The executor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>executor</para>
        /// </summary>
        [NameInMap("Executor")]
        [Validation(Required=false)]
        public string Executor { get; set; }

        /// <summary>
        /// <para>The publish object ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>The publish object type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ODPS_SQL</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public string ObjectType { get; set; }

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
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The publish flow status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Building: Building.</description></item>
        /// <item><description>Ready: Ready and waiting for execution.</description></item>
        /// <item><description>Running: Running.</description></item>
        /// <item><description>Termination: Terminated.</description></item>
        /// <item><description>Success: Succeeded.</description></item>
        /// <item><description>Fail: Failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Ready</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
