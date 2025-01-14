// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class ListNodesRequest : TeaModel {
        /// <summary>
        /// <para>The container ID. This parameter specifies a filter condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>860438872620113XXXX</para>
        /// </summary>
        [NameInMap("ContainerId")]
        [Validation(Required=false)]
        public long? ContainerId { get; set; }

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
        /// <para>The DataWorks workspace ID. You can log on to the <a href="https://workbench.data.aliyun.com/console">DataWorks console</a> and go to the Workspace page to query the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("Recurrence")]
        [Validation(Required=false)]
        public string Recurrence { get; set; }

        /// <summary>
        /// <para>The rerun mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Allowed: The nodes can be rerun regardless of whether they are successfully run or fail to run.</description></item>
        /// <item><description>FailureAllowed: The nodes can be rerun only after they fail to run.</description></item>
        /// <item><description>Denied: The nodes cannot be rerun regardless of whether they are successfully run or fail to run.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Allowed</para>
        /// </summary>
        [NameInMap("RerunMode")]
        [Validation(Required=false)]
        public string RerunMode { get; set; }

        /// <summary>
        /// <para>The scene of nodes. This parameter specifies a filter condition.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DATAWORKS_PROJECT</description></item>
        /// <item><description>MANUAL_WORKFLOW</description></item>
        /// <item><description>MANUAL_NODE</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DATAWORKS_PROJECT</para>
        /// </summary>
        [NameInMap("Scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

    }

}
