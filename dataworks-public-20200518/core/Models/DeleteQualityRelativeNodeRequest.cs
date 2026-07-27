// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DeleteQualityRelativeNodeRequest : TeaModel {
        /// <summary>
        /// <para>The type of the engine or data source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>cdh</para>
        /// </description></item>
        /// <item><description><para>analyticdb_for_mysql</para>
        /// </description></item>
        /// <item><description><para>odps</para>
        /// </description></item>
        /// <item><description><para>emr</para>
        /// </description></item>
        /// <item><description><para>hadoop</para>
        /// </description></item>
        /// <item><description><para>holodb</para>
        /// </description></item>
        /// <item><description><para>hybriddb_for_postgresql</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ODPS</para>
        /// </summary>
        [NameInMap("EnvType")]
        [Validation(Required=false)]
        public string EnvType { get; set; }

        /// <summary>
        /// <para>The partition filter expression.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dt=$[yyyymmdd]</para>
        /// </summary>
        [NameInMap("MatchExpression")]
        [Validation(Required=false)]
        public string MatchExpression { get; set; }

        /// <summary>
        /// <para>The node ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>156234</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The name of the workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>autotest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The table name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dual</para>
        /// </summary>
        [NameInMap("TableName")]
        [Validation(Required=false)]
        public string TableName { get; set; }

        /// <summary>
        /// <para>The ID of the workspace that contains the associated scheduling node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("TargetNodeProjectId")]
        [Validation(Required=false)]
        public long? TargetNodeProjectId { get; set; }

        /// <summary>
        /// <para>The name of the workspace that contains the associated scheduling node.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>autotest</para>
        /// </summary>
        [NameInMap("TargetNodeProjectName")]
        [Validation(Required=false)]
        public string TargetNodeProjectName { get; set; }

    }

}
