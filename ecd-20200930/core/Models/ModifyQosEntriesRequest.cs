// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyQosEntriesRequest : TeaModel {
        /// <summary>
        /// <para>The list of cloud phone IDs to associate.</para>
        /// </summary>
        [NameInMap("AuthAndroidId")]
        [Validation(Required=false)]
        public List<string> AuthAndroidId { get; set; }

        /// <summary>
        /// <para>The ID of the cloud desktop pool to authorize.</para>
        /// </summary>
        [NameInMap("AuthDesktopGroupId")]
        [Validation(Required=false)]
        public List<string> AuthDesktopGroupId { get; set; }

        /// <summary>
        /// <para>The list of cloud desktop IDs to associate.</para>
        /// </summary>
        [NameInMap("AuthDesktopId")]
        [Validation(Required=false)]
        public List<string> AuthDesktopId { get; set; }

        /// <summary>
        /// <para>The ID of the public network rate limiting rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-5605u0gelk200****</para>
        /// </summary>
        [NameInMap("QosRuleId")]
        [Validation(Required=false)]
        public string QosRuleId { get; set; }

        /// <summary>
        /// <para>The list of cloud phone IDs to disassociate.</para>
        /// </summary>
        [NameInMap("RevokeAndroidId")]
        [Validation(Required=false)]
        public List<string> RevokeAndroidId { get; set; }

        /// <summary>
        /// <para>The ID of the cloud desktop pool to revoke authorization from.</para>
        /// </summary>
        [NameInMap("RevokeDesktopGroupId")]
        [Validation(Required=false)]
        public List<string> RevokeDesktopGroupId { get; set; }

        /// <summary>
        /// <para>The list of cloud desktop IDs to disassociate.</para>
        /// </summary>
        [NameInMap("RevokeDesktopId")]
        [Validation(Required=false)]
        public List<string> RevokeDesktopId { get; set; }

    }

}
