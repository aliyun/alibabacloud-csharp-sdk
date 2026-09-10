// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class NotifyPolicySummary : TeaModel {
        /// <summary>
        /// <para>The creation time, represented as a UNIX millisecond timestamp string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700000000000</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The description of the notification policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A notification policy for testing</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether the notification policy is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The Policy Name of the notification policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample notification policy</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The configuration details of the notification policy.</para>
        /// </summary>
        [NameInMap("notifyStrategy")]
        [Validation(Required=false)]
        public NotifyStrategyDetail NotifyStrategy { get; set; }

        /// <summary>
        /// <para>The update time, represented as a UNIX millisecond timestamp string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1700000000000</para>
        /// </summary>
        [NameInMap("updateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567890</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The unique identifier of the notification policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ns-uuid-001</para>
        /// </summary>
        [NameInMap("uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

        /// <summary>
        /// <para>The version number of the notification policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public int? Version { get; set; }

        /// <summary>
        /// <para>The workspace identifier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
