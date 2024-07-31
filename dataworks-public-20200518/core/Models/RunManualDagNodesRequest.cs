// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RunManualDagNodesRequest : TeaModel {
        /// <summary>
        /// The data timestamp. The value of the data timestamp must be one or more days before the current date. For example, if the current date is November 11, 2020, set the value to 2020-11-10 00:00:00 or earlier. Configure this parameter in the YYYY-MM-DD 00:00:00 format. The StartBizDate parameter is used together with the EndBizDate parameter. You can configure only the BizDate parameter or the StartBizDate and EndBizDate parameters.
        /// </summary>
        [NameInMap("BizDate")]
        [Validation(Required=false)]
        public string BizDate { get; set; }

        /// <summary>
        /// The parameters are synchronized to all the instances in the directed acyclic graph (DAG) of the workflow. If a workflow parameter specified in DagParameters is referenced as a scheduling parameter of a [node](https://help.aliyun.com/document_detail/147245.html), the value of the scheduling parameter is replaced with the value of the workflow parameter.
        /// </summary>
        [NameInMap("DagParameters")]
        [Validation(Required=false)]
        public string DagParameters { get; set; }

        /// <summary>
        /// The end of the time range in which data generated needs to be processed. Configure this parameter in the yyyy-MM-dd HH:mm:ss format. The StartBizDate parameter is used together with the EndBizDate parameter. You can configure only the BizDate parameter or the StartBizDate and EndBizDate parameters.
        /// </summary>
        [NameInMap("EndBizDate")]
        [Validation(Required=false)]
        public string EndBizDate { get; set; }

        /// <summary>
        /// The IDs of the nodes that you do not need to run in the manually triggered workflow. DataWorks generates dry-run instances for all these nodes. After the dry-run instances are scheduled, the states of these instances are directly set to successful, but the scripts are not run. Separate multiple node IDs with commas (,). The ExcludeNodeIds parameter must be used together with the IncludeNodeIds parameter. This way, the settings of the ExcludeNodeIds parameter can take effect.
        /// </summary>
        [NameInMap("ExcludeNodeIds")]
        [Validation(Required=false)]
        public string ExcludeNodeIds { get; set; }

        /// <summary>
        /// The name of the manually triggered workflow.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FlowName")]
        [Validation(Required=false)]
        public string FlowName { get; set; }

        /// <summary>
        /// The IDs of the nodes that you need to run in the manually triggered workflow. Separate multiple node IDs with commas (,).
        /// </summary>
        [NameInMap("IncludeNodeIds")]
        [Validation(Required=false)]
        public string IncludeNodeIds { get; set; }

        /// <summary>
        /// The scheduling parameters of nodes in the manually triggered workflow. Configure NodeParameters in the following JSON format: {"\\<ID of a node in the manually triggered workflow>": "Scheduling parameter settings of the node, which are in the same format as the parameter settings in the Scheduling Parameter section of the Properties tab on the DataStudio page", "\\<ID of a node in the manually triggered workflow>": "Scheduling parameter settings of the node, which are in the same format as the parameter settings in the Scheduling Parameter section of the Properties tab on the DataStudio page"}.
        /// </summary>
        [NameInMap("NodeParameters")]
        [Validation(Required=false)]
        public string NodeParameters { get; set; }

        /// <summary>
        /// The environment type of Operation Center. Valid values: PROD and DEV. The value PROD indicates the production environment. The value DEV indicates the development environment.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectEnv")]
        [Validation(Required=false)]
        public string ProjectEnv { get; set; }

        /// <summary>
        /// The ID of the workspace to which the manually triggered workflow belongs.
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// The name of the workspace to which the manually triggered workflow belongs.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// The beginning of the time range in which data generated needs to be processed. Configure this parameter in the yyyy-MM-dd HH:mm:ss format. The StartBizDate parameter is used together with the EndBizDate parameter. You can configure only the BizDate parameter or the StartBizDate and EndBizDate parameters.
        /// </summary>
        [NameInMap("StartBizDate")]
        [Validation(Required=false)]
        public string StartBizDate { get; set; }

    }

}
