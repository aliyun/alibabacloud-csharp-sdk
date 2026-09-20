// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListInstancesRequest : TeaModel {
        /// <summary>
        /// <para>The start date for which to retrieve the instance list. Format: yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-02 00:00:00</para>
        /// </summary>
        [NameInMap("BeginBizdate")]
        [Validation(Required=false)]
        public string BeginBizdate { get; set; }

        /// <summary>
        /// <para>The name of the workflow. You can call <a href="https://help.aliyun.com/document_detail/173945.html">ListBusiness</a> to query workflow information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_bizName</para>
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        /// <summary>
        /// <para>The date for which to retrieve the instance list. Format: yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-02 00:00:00</para>
        /// </summary>
        [NameInMap("Bizdate")]
        [Validation(Required=false)]
        public string Bizdate { get; set; }

        /// <summary>
        /// <para>The DAG ID. The DagId can be the DagId returned by operations such as <a href="https://help.aliyun.com/document_detail/212961.html">RunCycleDagNodes</a> for data backfill, <a href="https://help.aliyun.com/document_detail/212949.html">RunSmokeTest</a> for smoke testing, and <a href="https://help.aliyun.com/document_detail/212830.html">RunManualDagNodes</a> for manual workflows.</para>
        /// 
        /// <b>Example:</b>
        /// <para>11111</para>
        /// </summary>
        [NameInMap("DagId")]
        [Validation(Required=false)]
        public long? DagId { get; set; }

        /// <summary>
        /// <para>The end date for which to retrieve the instance list. Format: yyyy-MM-dd HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-02-03 00:00:00</para>
        /// </summary>
        [NameInMap("EndBizdate")]
        [Validation(Required=false)]
        public string EndBizdate { get; set; }

        /// <summary>
        /// <para>The node ID. You can call <a href="https://help.aliyun.com/document_detail/173979.html">ListNodes</a> to query the node ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100000000000</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

        /// <summary>
        /// <para>The node name. You can call <a href="https://help.aliyun.com/document_detail/173979.html">ListNodes</a> to query the node name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>openmr_8****</para>
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <para>The sorting rule for the returned results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CREATE_TIME_DESC: sorted by creation time in descending order.</description></item>
        /// <item><description>INSTANCE_ID_DESC: default value. Sorted by instance ID in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCE_ID_DESC</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The ID of the owner, which is the UID of the workspace administrator. You can logon to the Alibaba Cloud Management Console and view the UID in the Security Settings section of the storage management page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>193379****</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>The page number. Minimum value: 1. Maximum value: 100.</para>
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
        /// <para>The node type. You can call <a href="https://help.aliyun.com/document_detail/173979.html">ListNodes</a> to query the node type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ODPS_SQL</para>
        /// </summary>
        [NameInMap("ProgramType")]
        [Validation(Required=false)]
        public string ProgramType { get; set; }

        /// <summary>
        /// <para>The runtime environment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PROD: production environment.</description></item>
        /// <item><description>DEV: development environment.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROD</para>
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

        /// <summary>
        /// <para>The workspace ID. You can call <a href="https://help.aliyun.com/document_detail/178393.html">ListProjects</a> to query the workspace ID.</para>
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
        /// <item><description><para>NOT_RUN: The node is not run.</para>
        /// </description></item>
        /// <item><description><para>WAIT_TIME: The node is waiting for the scheduled time (DueTime or CycTime) to arrive.</para>
        /// </description></item>
        /// <item><description><para>WAIT_RESOURCE: The node is waiting for resources.</para>
        /// </description></item>
        /// <item><description><para>RUNNING: The node is running.</para>
        /// </description></item>
        /// <item><description><para>CHECKING: The node has been sent to Data Quality for data validation.</para>
        /// </description></item>
        /// <item><description><para>CHECKING_CONDITION: The node is undergoing branch condition verification.</para>
        /// </description></item>
        /// <item><description><para>FAILURE: Failed to execute.</para>
        /// </description></item>
        /// <item><description><para>SUCCESS: Execute successfully.</para>
        /// </description></item>
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
