// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudesl20190801.Models
{
    public class CreateStoreRequest : TeaModel {
        [NameInMap("Brand")]
        [Validation(Required=false)]
        public string Brand { get; set; }

        [NameInMap("Comments")]
        [Validation(Required=false)]
        public string Comments { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CompanyId")]
        [Validation(Required=false)]
        public string CompanyId { get; set; }

        [NameInMap("Groups")]
        [Validation(Required=false)]
        public string Groups { get; set; }

        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("ParentId")]
        [Validation(Required=false)]
        public string ParentId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("StoreName")]
        [Validation(Required=false)]
        public string StoreName { get; set; }

    }

}
