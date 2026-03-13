// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai20240521.Models
{
    public class QuickStartModel : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DeploymentCount")]
        [Validation(Required=false)]
        public long? DeploymentCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cv</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtraInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<Label> Labels { get; set; }

        [NameInMap("LatestVersion")]
        [Validation(Required=false)]
        public ModelVersion LatestVersion { get; set; }

        [NameInMap("ModelDescription")]
        [Validation(Required=false)]
        public string ModelDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>https://***.md</para>
        /// </summary>
        [NameInMap("ModelDoc")]
        [Validation(Required=false)]
        public string ModelDoc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>model-1123*****</para>
        /// </summary>
        [NameInMap("ModelId")]
        [Validation(Required=false)]
        public string ModelId { get; set; }

        [NameInMap("ModelName")]
        [Validation(Required=false)]
        public string ModelName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>101</para>
        /// </summary>
        [NameInMap("OrderNumber")]
        [Validation(Required=false)]
        public long? OrderNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ModelScope</para>
        /// </summary>
        [NameInMap("Origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1557702098******</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pai</para>
        /// </summary>
        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;en-US&quot;:&quot;Large Language Model&quot;  &quot;zh-CN&quot;:&quot;大语言模型&quot;}</para>
        /// </summary>
        [NameInMap("QuickStartModelDescription")]
        [Validation(Required=false)]
        public Dictionary<string, object> QuickStartModelDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;en-US&quot;:&quot;qwen&quot;，  &quot;zh-CN&quot;:&quot;千问&quot;}</para>
        /// </summary>
        [NameInMap("QuickStartModelName")]
        [Validation(Required=false)]
        public Dictionary<string, object> QuickStartModelName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>model-12346</para>
        /// </summary>
        [NameInMap("RelatedModelId")]
        [Validation(Required=false)]
        public string RelatedModelId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>text-classifiaction</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public string Task { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("TrainingCount")]
        [Validation(Required=false)]
        public long? TrainingCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1557702098******</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("ViewCount")]
        [Validation(Required=false)]
        public long? ViewCount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("ViewCount7Days")]
        [Validation(Required=false)]
        public long? ViewCount7Days { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>234**</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
