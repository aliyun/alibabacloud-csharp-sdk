/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class AddVirtualNumberRelationRequest : TeaModel {
        /// <summary>
        /// The company names. Separate multiple company names with commas (,).
        /// </summary>
        [NameInMap("CorpNameList")]
        [Validation(Required=false)]
        public string CorpNameList { get; set; }

        /// <summary>
        /// The real numbers. Separate multiple real numbers with commas (,).
        /// </summary>
        [NameInMap("NumberList")]
        [Validation(Required=false)]
        public string NumberList { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The virtual number.
        /// </summary>
        [NameInMap("PhoneNum")]
        [Validation(Required=false)]
        public string PhoneNum { get; set; }

        /// <summary>
        /// The service name. Default value: **dyvms**.
        /// </summary>
        [NameInMap("ProdCode")]
        [Validation(Required=false)]
        public string ProdCode { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The route type. Valid values:
        /// 
        /// *   **0**: number location first.
        /// *   **1**: random.
        /// </summary>
        [NameInMap("RouteType")]
        [Validation(Required=false)]
        public int? RouteType { get; set; }

    }

}
