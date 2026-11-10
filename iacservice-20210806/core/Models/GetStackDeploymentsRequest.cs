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
        /// <para>The name of the deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>production</para>
        /// </summary>
        [NameInMap("deploymentName")]
        [Validation(Required=false)]
        public string DeploymentName { get; set; }

        /// <summary>
        /// <para>The deployment number. The deployment number of each stack starts from 1 and increments each time a deployment is successfully triggered.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("deploymentNo")]
        [Validation(Required=false)]
        public string DeploymentNo { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 20. Minimum value: 1. Maximum value: 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The deployment status. Valid values:</para>
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
        /// <td>The deployment is queued with priority.</td>
        /// </tr>
        /// <tr>
        /// <td>PlanQueued</td>
        /// <td>The deployment is queued and waiting for an available workflow after it is created.</td>
        /// </tr>
        /// <tr>
        /// <td>ApplyQueued</td>
        /// <td>The deployment is queued and waiting for an available workflow during execution.</td>
        /// </tr>
        /// <tr>
        /// <td>Planning</td>
        /// <td>The deployment is in the plan phase.</td>
        /// </tr>
        /// <tr>
        /// <td>Planned</td>
        /// <td>The deployment has completed the plan phase.</td>
        /// </tr>
        /// <tr>
        /// <td>ConfigProactiveInProgress</td>
        /// <td>The compliance precheck is in progress.</td>
        /// </tr>
        /// <tr>
        /// <td>ConfigProactiveSuccess</td>
        /// <td>The compliance precheck is successful.</td>
        /// </tr>
        /// <tr>
        /// <td>DetectInProgress</td>
        /// <td>Drift detection is in progress.</td>
        /// </tr>
        /// <tr>
        /// <td>ImportQueued</td>
        /// <td>The deployment is queued and waiting for an available workflow during the import phase.</td>
        /// </tr>
        /// <tr>
        /// <td>Importing</td>
        /// <td>The deployment is in the import phase.</td>
        /// </tr>
        /// <tr>
        /// <td>Imported</td>
        /// <td>The deployment has completed the import phase.</td>
        /// </tr>
        /// <tr>
        /// <td>StateQueued</td>
        /// <td>The deployment is queued and waiting for an available workflow during the state command execution.</td>
        /// </tr>
        /// <tr>
        /// <td>Stating</td>
        /// <td>The deployment is executing the state command.</td>
        /// </tr>
        /// <tr>
        /// <td>Stated</td>
        /// <td>The deployment has completed the execution of the state command.</td>
        /// </tr>
        /// <tr>
        /// <td>Confirmed</td>
        /// <td>The deployment is confirmed after the plan phase.</td>
        /// </tr>
        /// <tr>
        /// <td>PlannedAndFinished</td>
        /// <td>The deployment is in the final state because no differences are found after the plan phase.</td>
        /// </tr>
        /// <tr>
        /// <td>Applying</td>
        /// <td>The deployment is in the apply phase.</td>
        /// </tr>
        /// <tr>
        /// <td>Applied</td>
        /// <td>The deployment has completed the apply phase.</td>
        /// </tr>
        /// <tr>
        /// <td>Discarded</td>
        /// <td>The deployment is discarded and enters the final state.</td>
        /// </tr>
        /// <tr>
        /// <td>Errored</td>
        /// <td>An error occurred during the deployment execution, and the deployment enters the final state.</td>
        /// </tr>
        /// <tr>
        /// <td>ConfigProactiveFailure</td>
        /// <td>The compliance precheck failed.</td>
        /// </tr>
        /// <tr>
        /// <td>Canceled</td>
        /// <td>The deployment execution is canceled, and the deployment enters the final state.</td>
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
