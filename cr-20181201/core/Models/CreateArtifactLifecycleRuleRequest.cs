// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20181201.Models
{
    public class CreateArtifactLifecycleRuleRequest : TeaModel {
        /// <summary>
        /// <para>Specify whether to automatically execute the lifecycle management rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Auto")]
        [Validation(Required=false)]
        public bool? Auto { get; set; }

        /// <summary>
        /// <para>Specify whether to enable lifecycle management for the artifact.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableDeleteTag")]
        [Validation(Required=false)]
        public bool? EnableDeleteTag { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cri-gbwfk7qbgrxe****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The name of the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dev-backend</para>
        /// </summary>
        [NameInMap("NamespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// <para>The name of the image repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_1</para>
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// <para>The number of images that you want to retain.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("RetentionTagCount")]
        [Validation(Required=false)]
        public long? RetentionTagCount { get; set; }

        /// <summary>
        /// <para>The execution cycle of the lifecycle management rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WEEK</para>
        /// </summary>
        [NameInMap("ScheduleTime")]
        [Validation(Required=false)]
        public string ScheduleTime { get; set; }

        /// <summary>
        /// <para>The deletion scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCE</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

        /// <summary>
        /// <para>The regular expression that is used to indicate which image tags are retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>release-.*</para>
        /// </summary>
        [NameInMap("TagRegexp")]
        [Validation(Required=false)]
        public string TagRegexp { get; set; }

    }

}
