// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CreateQosRuleRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the cloud phones to associate.</para>
        /// </summary>
        [NameInMap("AuthAndroidId")]
        [Validation(Required=false)]
        public List<string> AuthAndroidId { get; set; }

        /// <summary>
        /// <para>The ID of the cloud computer pool where the authorization takes effect.</para>
        /// </summary>
        [NameInMap("AuthDesktopGroupId")]
        [Validation(Required=false)]
        public List<string> AuthDesktopGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of the cloud computers to associate.</para>
        /// </summary>
        [NameInMap("AuthDesktopId")]
        [Validation(Required=false)]
        public List<string> AuthDesktopId { get; set; }

        /// <summary>
        /// <para>The peak downstream bandwidth. Unit: Mbit/s.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("Download")]
        [Validation(Required=false)]
        public int? Download { get; set; }

        /// <summary>
        /// <para>The ID of the premium bandwidth.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>np-cfedn7r2pe48g****</para>
        /// </summary>
        [NameInMap("NetworkPackageId")]
        [Validation(Required=false)]
        public string NetworkPackageId { get; set; }

        /// <summary>
        /// <para>The name of the bandwidth throttling rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office network bandwidth throttling rule</para>
        /// </summary>
        [NameInMap("QosRuleName")]
        [Validation(Required=false)]
        public string QosRuleName { get; set; }

        /// <summary>
        /// <para>The peak upstream bandwidth. Unit: Mbit/s.</para>
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
