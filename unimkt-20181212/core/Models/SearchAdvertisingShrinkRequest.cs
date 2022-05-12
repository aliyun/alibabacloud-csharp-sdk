// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class SearchAdvertisingShrinkRequest : TeaModel {
        /// <summary>
        /// app
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string AppShrink { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// imp
        /// </summary>
        [NameInMap("Imp")]
        [Validation(Required=false)]
        public string ImpShrink { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [NameInMap("Test")]
        [Validation(Required=false)]
        public int? Test { get; set; }

        /// <summary>
        /// user
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string UserShrink { get; set; }

    }

}
