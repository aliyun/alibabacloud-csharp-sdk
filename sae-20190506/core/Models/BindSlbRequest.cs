// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class BindSlbRequest : TeaModel {
        /// <summary>
        /// 0099b7be-5f5b-4512-a7fc-56049ef1\\*\\*\\*\\*
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// [{"port":80,"targetPort":8080,"protocol":"TCP"}]
        /// </summary>
        [NameInMap("Internet")]
        [Validation(Required=false)]
        public string Internet { get; set; }

        [NameInMap("InternetSlbChargeType")]
        [Validation(Required=false)]
        public string InternetSlbChargeType { get; set; }

        /// <summary>
        /// lb-bp1tg0k6d9nqaw7l1\\*\\*\\*\\*
        /// </summary>
        [NameInMap("InternetSlbId")]
        [Validation(Required=false)]
        public string InternetSlbId { get; set; }

        /// <summary>
        /// [{"port":80,"targetPort":8080,"protocol":"TCP"}]
        /// </summary>
        [NameInMap("Intranet")]
        [Validation(Required=false)]
        public string Intranet { get; set; }

        [NameInMap("IntranetSlbChargeType")]
        [Validation(Required=false)]
        public string IntranetSlbChargeType { get; set; }

        /// <summary>
        /// lb-bp1tg0k6d9nqaw7l1\\*\\*\\*\\*
        /// </summary>
        [NameInMap("IntranetSlbId")]
        [Validation(Required=false)]
        public string IntranetSlbId { get; set; }

    }

}
