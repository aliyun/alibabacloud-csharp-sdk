/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class GetUserFinishedAdRequest : TeaModel {
        /// <summary>
        /// adid
        /// </summary>
        [NameInMap("Adid")]
        [Validation(Required=false)]
        public long? Adid { get; set; }

        /// <summary>
        /// clicklink
        /// </summary>
        [NameInMap("Clicklink")]
        [Validation(Required=false)]
        public string Clicklink { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// mediaid
        /// </summary>
        [NameInMap("Mediaid")]
        [Validation(Required=false)]
        public string Mediaid { get; set; }

        /// <summary>
        /// tagid
        /// </summary>
        [NameInMap("Tagid")]
        [Validation(Required=false)]
        public string Tagid { get; set; }

        /// <summary>
        /// uid
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
