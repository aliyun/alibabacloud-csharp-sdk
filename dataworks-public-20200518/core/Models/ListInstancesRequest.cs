// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The parameters related to the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-02 00:00:00</para>
        /// </summary>
        [NameInMap("BeginBizdate")]
        [Validation(Required=false)]
        public string BeginBizdate { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_bizName</para>
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-02 00:00:00</para>
        /// </summary>
        [NameInMap("Bizdate")]
        [Validation(Required=false)]
        public string Bizdate { get; set; }

        /// <summary>
        /// <para>The environment of the workspace. Valid values: PROD and DEV. The value PROD indicates the production environment. The value DEV indicates the development environment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11111</para>
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// <para>The ID of the workflow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-03 00:00:00</para>
        /// </summary>
        [NameInMap("EndBizdate")]
        [Validation(Required=false)]
        public string EndBizdate { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance is associated with a monitoring rule in Data Quality. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: The instance is associated with a monitoring rule in Data Quality.</description></item>
        /// <item><description>1: The instance is not associated with a monitoring rule in Data Quality.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>100000000000</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

        /// <summary>
        /// <para>Indicates whether the node can be rerun.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openmr_8****</para>
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <para>The sorting rule of the instances to be returned. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CREATE_TIME_DESC: The instances are sorted in descending order of their creation time.</description></item>
        /// <item><description>INSTANCE_ID_DESC (default): The instances are sorted in descending order of their IDs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCE_ID_DESC</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The connection string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>193379****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The ID of the node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ODPS_SQL</para>
        /// </summary>
        [NameInMap("ProgramType")]
        [Validation(Required=false)]
        public string ProgramType { get; set; }

        /// <summary>
        /// <para>The environment in which the node runs. Valid values: DEV and PROD.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

        /// <summary>
        /// <para>The ID of the baseline.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The status of the node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NOT_RUN: The node is not run.</description></item>
        /// <item><description>WAIT_TIME: The node is waiting for the scheduling time to arrive.</description></item>
        /// <item><description>WAIT_RESOURCE: The node is waiting for resources.</description></item>
        /// <item><description>RUNNING: The node is running.</description></item>
        /// <item><description>CHECKING: Data quality is being checked for the node.</description></item>
        /// <item><description>CHECKING_CONDITION: Branch conditions are being checked for the node.</description></item>
        /// <item><description>FAILURE: The node fails to run.</description></item>
        /// <item><description>SUCCESS: The node is successfully run.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NOT_RUN</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
