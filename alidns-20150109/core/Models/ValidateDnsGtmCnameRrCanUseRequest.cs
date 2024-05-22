// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class ValidateDnsGtmCnameRrCanUseRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CnameMode")]
        [Validation(Required=false)]
        public string CnameMode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CnameRr")]
        [Validation(Required=false)]
        public string CnameRr { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CnameType")]
        [Validation(Required=false)]
        public string CnameType { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CnameZone")]
        [Validation(Required=false)]
        public string CnameZone { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
