// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListNodesRequest : TeaModel {
        /// <summary>
        /// <para>The error code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_bizName</para>
        /// </summary>
        [NameInMap("BizName")]
        [Validation(Required=false)]
        public string BizName { get; set; }

        /// <summary>
        /// <para>The ID of the baseline with which the node is associated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liux_test_n****</para>
        /// </summary>
        [NameInMap("NodeName")]
        [Validation(Required=false)]
        public string NodeName { get; set; }

        /// <summary>
        /// <para>The description of the node.</para>
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
        /// <para>The operation that you want to perform. Set the value to <b>ListNodes</b>.</para>
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
        /// <para>The ID of the owner.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para>The scheduling type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NORMAL: Nodes are scheduled as expected.</description></item>
        /// <item><description>PAUSE: Nodes are paused.</description></item>
        /// <item><description>SKIP: Nodes are dry-run. Dry-run nodes are started as scheduled, but the system sets the status of the nodes to successful when it starts to run them.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NORMAL</para>
        /// </summary>
        [NameInMap("SchedulerType")]
        [Validation(Required=false)]
        public string SchedulerType { get; set; }

    }

}
