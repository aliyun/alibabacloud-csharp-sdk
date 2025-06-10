// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateRepoSyncRuleRequest : TeaModel {
        /// <summary>
        /// <para>The source instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-hpdfkc6utbaq****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The namespace name of the source instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ns1</para>
        /// </summary>
        [NameInMap("NamespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// <para>The name of the image repository in the source instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>repo1</para>
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// <para>The regular expression that is used to filter repositories.</para>
        /// <remarks>
        /// <para> This parameter is valid only when SyncScope is set to <c>NAMESPACE</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>.*</para>
        /// </summary>
        [NameInMap("RepoNameFilter")]
        [Validation(Required=false)]
        public string RepoNameFilter { get; set; }

        /// <summary>
        /// <para>The name of the image synchronization rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rule</para>
        /// </summary>
        [NameInMap("SyncRuleName")]
        [Validation(Required=false)]
        public string SyncRuleName { get; set; }

        /// <summary>
        /// <para>The synchronization scope. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>REPO</c>: synchronizes the image tags in an image repository that meet the synchronization rule.</description></item>
        /// <item><description><c>NAMESPACE</c>: synchronizes the image tags in a namespace that meet the synchronization rule.</description></item>
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
        /// <para>The mode of triggering the synchronization rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>INITIATIVE</c>: manually triggers the synchronization rule.</description></item>
        /// <item><description><c>PASSIVE</c>: automatically triggers the synchronization rule.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PASSIVE</para>
        /// </summary>
        [NameInMap("SyncTrigger")]
        [Validation(Required=false)]
        public string SyncTrigger { get; set; }

        /// <summary>
        /// <para>The regular expression that is used to filter image tags.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>.*</para>
        /// </summary>
        [NameInMap("TagFilter")]
        [Validation(Required=false)]
        public string TagFilter { get; set; }

        /// <summary>
        /// <para>The destination instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-ibxs3piklys3****</para>
        /// </summary>
        [NameInMap("TargetInstanceId")]
        [Validation(Required=false)]
        public string TargetInstanceId { get; set; }

        /// <summary>
        /// <para>The namespace name of the destination instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ns1</para>
        /// </summary>
        [NameInMap("TargetNamespaceName")]
        [Validation(Required=false)]
        public string TargetNamespaceName { get; set; }

        /// <summary>
        /// <para>The region ID of the destination instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("TargetRegionId")]
        [Validation(Required=false)]
        public string TargetRegionId { get; set; }

        /// <summary>
        /// <para>The name of the image repository in the destination instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>repo1</para>
        /// </summary>
        [NameInMap("TargetRepoName")]
        [Validation(Required=false)]
        public string TargetRepoName { get; set; }

        /// <summary>
        /// <para>The user ID (UID) of the account to which the destination instance belongs.</para>
        /// <remarks>
        /// <para> If you synchronize images across accounts, you must use the UID.</para>
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
