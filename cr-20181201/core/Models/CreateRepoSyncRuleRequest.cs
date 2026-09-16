// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateRepoSyncRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the source instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-hpdfkc6utbaq****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the custom synchronization link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stl-72cjfd3fayno8***</para>
        /// </summary>
        [NameInMap("LinkId")]
        [Validation(Required=false)]
        public string LinkId { get; set; }

        /// <summary>
        /// <para>The namespace name of the source instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ns1</para>
        /// </summary>
        [NameInMap("NamespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// <para>The instance-level namespace regex filter.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when SyncScope is set to <c>INSTANCE</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>.*</para>
        /// </summary>
        [NameInMap("NamespaceNameFilter")]
        [Validation(Required=false)]
        public string NamespaceNameFilter { get; set; }

        /// <summary>
        /// <para>The execution priority of the synchronization task. Synchronization tasks are executed in descending order of priority. Tasks with the same priority are executed in random order.</para>
        /// <para>Valid values: 1 to 5.</para>
        /// <para>Default value: 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The repository name of the source instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>repo1</para>
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// <para>The repository filter rule.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when SyncScope is set to <c>INSTANCE</c> or <c>NAMESPACE</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>.*</para>
        /// </summary>
        [NameInMap("RepoNameFilter")]
        [Validation(Required=false)]
        public string RepoNameFilter { get; set; }

        /// <summary>
        /// <para>The name of the synchronization rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule</para>
        /// </summary>
        [NameInMap("SyncRuleName")]
        [Validation(Required=false)]
        public string SyncRuleName { get; set; }

        /// <summary>
        /// <para>The synchronization type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>REPO</c>: Synchronizes by image repository.</para>
        /// </description></item>
        /// <item><description><para><c>NAMESPACE</c>: Synchronizes by namespace.</para>
        /// </description></item>
        /// <item><description><para><c>INSTANCE</c>: Synchronizes by namespace regex and repository regex.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>REPO</para>
        /// </summary>
        [NameInMap("SyncScope")]
        [Validation(Required=false)]
        public string SyncScope { get; set; }

        /// <summary>
        /// <para>The trigger for the synchronization action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>INITIATIVE</c>: Manual trigger.</para>
        /// </description></item>
        /// <item><description><para><c>PASSIVE</c>: Automatic trigger.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PASSIVE</para>
        /// </summary>
        [NameInMap("SyncTrigger")]
        [Validation(Required=false)]
        public string SyncTrigger { get; set; }

        /// <summary>
        /// <para>The tag filter rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>.*</para>
        /// </summary>
        [NameInMap("TagFilter")]
        [Validation(Required=false)]
        public string TagFilter { get; set; }

        /// <summary>
        /// <para>The ID of the target instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-ibxs3piklys3****</para>
        /// </summary>
        [NameInMap("TargetInstanceId")]
        [Validation(Required=false)]
        public string TargetInstanceId { get; set; }

        /// <summary>
        /// <para>The namespace name of the target instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ns1</para>
        /// </summary>
        [NameInMap("TargetNamespaceName")]
        [Validation(Required=false)]
        public string TargetNamespaceName { get; set; }

        /// <summary>
        /// <para>The region ID of the target instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("TargetRegionId")]
        [Validation(Required=false)]
        public string TargetRegionId { get; set; }

        /// <summary>
        /// <para>The image repository name of the target instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>repo1</para>
        /// </summary>
        [NameInMap("TargetRepoName")]
        [Validation(Required=false)]
        public string TargetRepoName { get; set; }

        /// <summary>
        /// <para>The UID of the account to which the target instance belongs.</para>
        /// <remarks>
        /// <para>This parameter is required for cross-account image synchronization.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>12645940***</para>
        /// </summary>
        [NameInMap("TargetUserId")]
        [Validation(Required=false)]
        public string TargetUserId { get; set; }

    }

}
