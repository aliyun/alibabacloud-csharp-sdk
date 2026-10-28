// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyBrowserInstanceGroupShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to send notification emails for authorization and deauthorization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AuthNotificationEnabled")]
        [Validation(Required=false)]
        public bool? AuthNotificationEnabled { get; set; }

        /// <summary>
        /// <para>The browser configuration.</para>
        /// </summary>
        [NameInMap("BrowserConfig")]
        [Validation(Required=false)]
        public string BrowserConfigShrink { get; set; }

        /// <summary>
        /// <para>The ID of the cloud browser.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>big-0bz55ixxxxx9xi9w9</para>
        /// </summary>
        [NameInMap("BrowserInstanceGroupId")]
        [Validation(Required=false)]
        public string BrowserInstanceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the cloud browser.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BrowserTest</para>
        /// </summary>
        [NameInMap("CloudBrowserName")]
        [Validation(Required=false)]
        public string CloudBrowserName { get; set; }

        /// <summary>
        /// <para>The maximum resource count. This parameter takes effect only for the pay-as-you-go billing method based on monthly active users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MaxAmount")]
        [Validation(Required=false)]
        public int? MaxAmount { get; set; }

        /// <summary>
        /// <para>The network configurations.</para>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public string NetworkShrink { get; set; }

        /// <summary>
        /// <para>The access policy.</para>
        /// </summary>
        [NameInMap("Policy")]
        [Validation(Required=false)]
        public string PolicyShrink { get; set; }

        /// <summary>
        /// <para>The storage-related policy.</para>
        /// </summary>
        [NameInMap("StoragePolicy")]
        [Validation(Required=false)]
        public string StoragePolicyShrink { get; set; }

        /// <summary>
        /// <para>The timer.</para>
        /// </summary>
        [NameInMap("Timers")]
        [Validation(Required=false)]
        public string TimersShrink { get; set; }

    }

}
