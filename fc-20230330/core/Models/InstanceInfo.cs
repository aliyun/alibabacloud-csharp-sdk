// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class InstanceInfo : TeaModel {
        /// <summary>
        /// <para>The time when the instance was created, represented as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("createdTimeMs")]
        [Validation(Required=false)]
        public long? CreatedTimeMs { get; set; }

        /// <summary>
        /// <para>The time when the instance was destroyed, represented as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("destroyedTimeMs")]
        [Validation(Required=false)]
        public long? DestroyedTimeMs { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1ef6b6ff-7f7b-485e-ab49-501ac681****</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The version or alias of the function to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        /// <summary>
        /// <para>The resource type of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The instance status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Destroyed</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The version of the function to which the instance belongs. If the function instance belongs to the LATEST alias, 0 is returned as the version ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("versionId")]
        [Validation(Required=false)]
        public string VersionId { get; set; }

    }

}
