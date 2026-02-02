// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyQosEntriesRequest : TeaModel {
        [NameInMap("AuthAndroidId")]
        [Validation(Required=false)]
        public List<string> AuthAndroidId { get; set; }

        [NameInMap("AuthDesktopId")]
        [Validation(Required=false)]
        public List<string> AuthDesktopId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qos-5605u0gelk200****</para>
        /// </summary>
        [NameInMap("QosRuleId")]
        [Validation(Required=false)]
        public string QosRuleId { get; set; }

        [NameInMap("RevokeAndroidId")]
        [Validation(Required=false)]
        public List<string> RevokeAndroidId { get; set; }

        [NameInMap("RevokeDesktopId")]
        [Validation(Required=false)]
        public List<string> RevokeDesktopId { get; set; }

    }

}
