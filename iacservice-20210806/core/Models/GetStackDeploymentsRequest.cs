// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class GetStackDeploymentsRequest : TeaModel {
        /// <summary>
        /// <para>The configuration version, such as v1. The initial value is v1. The version number increments each time the stack is updated or refreshed and the configuration changes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("configVersion")]
        [Validation(Required=false)]
        public string ConfigVersion { get; set; }

        /// <summary>
        /// <para>The deployment name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>production</para>
        /// </summary>
        [NameInMap("deploymentName")]
        [Validation(Required=false)]
        public string DeploymentName { get; set; }

        /// <summary>
        /// <para>The deployment number. The deployment number for each stack starts from 1 and increments each time a deployment is successfully triggered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("deploymentNo")]
        [Validation(Required=false)]
        public string DeploymentNo { get; set; }

        /// <summary>
        /// <para>The page number, starting from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of results returned per page. Default value: 20. Minimum value: 1. Maximum value: 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The deployment status.</para>
        /// <table>
        /// <thead>
        /// <tr>
        /// <th>Name</th>
        /// <th>Description</th>
        /// </tr>
        /// </thead>
        /// <tbody><tr>
        /// <td>Pending</td>
        /// <td>The initial status after the deployment is created.</td>
        /// </tr>
        /// <tr>
        /// <td>PriorityQueued</td>
        /// <td>Priority queuing in progress.</td>
        /// </tr>
        /// <tr>
        /// <td>PlanQueued</td>
        /// <td>The deployment is queuing because no workflow is available after creation.</td>
        /// </tr>
        /// <tr>
        /// <td>ApplyQueued</td>
        /// <td>The deployment is queuing because no workflow is available during execution.</td>
        /// </tr>
        /// <tr>
        /// <td>Planning</td>
        /// <td>The resource deployment is in the Plan phase.</td>
        /// </tr>
        /// <tr>
        /// <td>Planned</td>
        /// <td>The resource deployment has completed the Plan phase.</td>
        /// </tr>
        /// <tr>
        /// <td>ConfigProactiveInProgress</td>
        /// <td>Compliance pre-check in progress.</td>
        /// </tr>
        /// <tr>
        /// <td>ConfigProactiveSuccess</td>
        /// <td>Compliance pre-check succeeded.</td>
        /// </tr>
        /// <tr>
        /// <td>DetectInProgress</td>
        /// <td>Drift detection in progress.</td>
        /// </tr>
        /// <tr>
        /// <td>ImportQueued</td>
        /// <td>The deployment is queuing because no workflow is available during Import execution.</td>
        /// </tr>
        /// <tr>
        /// <td>Importing</td>
        /// <td>The resource deployment is in the Import phase.</td>
        /// </tr>
        /// <tr>
        /// <td>Imported</td>
        /// <td>The resource deployment has completed the Import phase.</td>
        /// </tr>
        /// <tr>
        /// <td>StateQueued</td>
        /// <td>The deployment is queuing because no workflow is available during state command execution.</td>
        /// </tr>
        /// <tr>
        /// <td>Stating</td>
        /// <td>The resource deployment is executing the state command.</td>
        /// </tr>
        /// <tr>
        /// <td>Stated</td>
        /// <td>The resource deployment has completed the state command execution.</td>
        /// </tr>
        /// <tr>
        /// <td>Confirmed</td>
        /// <td>The resource deployment has been confirmed after the Plan phase.</td>
        /// </tr>
        /// <tr>
        /// <td>PlannedAndFinished</td>
        /// <td>No diff was found after the Plan phase. The deployment is in a final status.</td>
        /// </tr>
        /// <tr>
        /// <td>Applying</td>
        /// <td>The resource deployment is in the Apply phase.</td>
        /// </tr>
        /// <tr>
        /// <td>Applied</td>
        /// <td>The resource deployment has completed the Apply phase.</td>
        /// </tr>
        /// <tr>
        /// <td>Discarded</td>
        /// <td>The resource deployment has been discarded and is in a final status.</td>
        /// </tr>
        /// <tr>
        /// <td>Errored</td>
        /// <td>The deployment execution encountered an error and is in a final status.</td>
        /// </tr>
        /// <tr>
        /// <td>ConfigProactiveFailure</td>
        /// <td>Compliance pre-check failed.</td>
        /// </tr>
        /// <tr>
        /// <td>Canceled</td>
        /// <td>The deployment execution has been canceled and is in a final status.</td>
        /// </tr>
        /// </tbody></table>
        /// 
        /// <b>Example:</b>
        /// <para>Applied</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
