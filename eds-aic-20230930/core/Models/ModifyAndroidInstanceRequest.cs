// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ModifyAndroidInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of a single instance. If you specify this parameter, InstanceIds is ignored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acp-8v5bjld0r7tkl****</para>
        /// </summary>
        [NameInMap("AndroidInstanceId")]
        [Validation(Required=false)]
        public string AndroidInstanceId { get; set; }

        /// <summary>
        /// <para>The limit for downstream bandwidth. Unit: Mbps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("DownBandwidthLimit")]
        [Validation(Required=false)]
        public int? DownBandwidthLimit { get; set; }

        /// <summary>
        /// <para>The list of Android instance IDs. You can specify from 1 to 100 IDs.</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The new name for the instance.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The name can be up to 30 characters long. It must start with a letter or a Chinese character and cannot start with http\:// or https\://. The name can contain only letters, digits, Chinese characters, colons (:), underscores (_), periods (.), and hyphens (-).</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>new_name</para>
        /// </summary>
        [NameInMap("NewAndroidInstanceName")]
        [Validation(Required=false)]
        public string NewAndroidInstanceName { get; set; }

        /// <summary>
        /// <para>The limit for upstream bandwidth. Unit: Mbps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("UpBandwidthLimit")]
        [Validation(Required=false)]
        public int? UpBandwidthLimit { get; set; }

    }

}
