// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateQosRuleRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the cloud phones to include in this rule.</para>
        /// </summary>
        [NameInMap("AuthAndroidId")]
        [Validation(Required=false)]
        public List<string> AuthAndroidId { get; set; }

        [NameInMap("AuthDesktopGroupId")]
        [Validation(Required=false)]
        public List<string> AuthDesktopGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of the cloud desktops to include in this rule.</para>
        /// </summary>
        [NameInMap("AuthDesktopId")]
        [Validation(Required=false)]
        public List<string> AuthDesktopId { get; set; }

        /// <summary>
        /// <para>The maximum downstream bandwidth. Unit: Mbps.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Download")]
        [Validation(Required=false)]
        public int? Download { get; set; }

        /// <summary>
        /// <para>The ID of the premium bandwidth plan.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>np-cfedn7r2pe48g****</para>
        /// </summary>
        [NameInMap("NetworkPackageId")]
        [Validation(Required=false)]
        public string NetworkPackageId { get; set; }

        /// <summary>
        /// <para>The name of the QoS rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("QosRuleName")]
        [Validation(Required=false)]
        public string QosRuleName { get; set; }

        /// <summary>
        /// <para>The maximum upstream bandwidth. Unit: Mbps.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Upload")]
        [Validation(Required=false)]
        public int? Upload { get; set; }

    }

}
