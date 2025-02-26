// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ModifyAndroidInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the cloud phone instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acp-8v5bjld0r7tkl****</para>
        /// </summary>
        [NameInMap("AndroidInstanceId")]
        [Validation(Required=false)]
        public string AndroidInstanceId { get; set; }

        /// <summary>
        /// <para>The new name of the cloud phone instance.</para>
        /// <remarks>
        /// <para> The name can be up to 30 characters in length. It can contain letters, digits, colons (:), underscores (_), periods (.), or hyphens (-). It must start with letters but cannot start with http:// or https://.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>new_name</para>
        /// </summary>
        [NameInMap("NewAndroidInstanceName")]
        [Validation(Required=false)]
        public string NewAndroidInstanceName { get; set; }

    }

}
