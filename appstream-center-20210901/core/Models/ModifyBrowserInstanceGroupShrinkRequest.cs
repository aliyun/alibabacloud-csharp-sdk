// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyBrowserInstanceGroupShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The browser configuration.</para>
        /// </summary>
        [NameInMap("BrowserConfig")]
        [Validation(Required=false)]
        public string BrowserConfigShrink { get; set; }

        /// <summary>
        /// <para>The ID of the cloud browser to modify.</para>
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
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("MaxAmount")]
        [Validation(Required=false)]
        public int? MaxAmount { get; set; }

        /// <summary>
        /// <para>The network configuration.</para>
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

        [NameInMap("StoragePolicy")]
        [Validation(Required=false)]
        public string StoragePolicyShrink { get; set; }

        /// <summary>
        /// <para>The timers.</para>
        /// </summary>
        [NameInMap("Timers")]
        [Validation(Required=false)]
        public string TimersShrink { get; set; }

    }

}
