// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class SetSCIMSynchronizationStatusRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>The status of SCIM synchronization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled</description></item>
        /// <item><description>Disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enabled</para>
        /// </summary>
        [NameInMap("SCIMSynchronizationStatus")]
        [Validation(Required=false)]
        public string SCIMSynchronizationStatus { get; set; }

    }

}
