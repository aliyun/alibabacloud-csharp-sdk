// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyCloudVendorTrialConfigRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>23**</para>
        /// </summary>
        [NameInMap("AuthId")]
        [Validation(Required=false)]
        public long? AuthId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{\&quot;sqsRegion\&quot;:\&quot;us-west-2\&quot;,\&quot;sqsQueueName\&quot;:\&quot;****\&quot;}</para>
        /// </summary>
        [NameInMap("AuthInfo")]
        [Validation(Required=false)]
        public string AuthInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeleteTrail")]
        [Validation(Required=false)]
        public bool? DeleteTrail { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Tencent</para>
        /// </summary>
        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
