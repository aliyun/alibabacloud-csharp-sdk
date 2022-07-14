// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imarketing20220704.Models
{
    public class ListAdvertisingShrinkRequest : TeaModel {
        /// <summary>
        /// app
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string AppShrink { get; set; }

        [NameInMap("Dealtype")]
        [Validation(Required=false)]
        public int? Dealtype { get; set; }

        [NameInMap("Device")]
        [Validation(Required=false)]
        public string DeviceShrink { get; set; }

        [NameInMap("Ext")]
        [Validation(Required=false)]
        public string ExtShrink { get; set; }

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
