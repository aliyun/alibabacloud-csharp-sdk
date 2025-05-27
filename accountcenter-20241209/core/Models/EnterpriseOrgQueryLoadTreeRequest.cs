// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AccountCenter20241209.Models
{
    public class EnterpriseOrgQueryLoadTreeRequest : TeaModel {
        [NameInMap("EncryptTicket")]
        [Validation(Required=false)]
        public string EncryptTicket { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("LoadOrgOnly")]
        [Validation(Required=false)]
        public bool? LoadOrgOnly { get; set; }

        [NameInMap("OrientedEcId")]
        [Validation(Required=false)]
        public string OrientedEcId { get; set; }

        [NameInMap("OrientedLeId")]
        [Validation(Required=false)]
        public string OrientedLeId { get; set; }

        [NameInMap("OrientedNbId")]
        [Validation(Required=false)]
        public string OrientedNbId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CF20ED94-D406-512F-9798-4E1F65720BF6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
