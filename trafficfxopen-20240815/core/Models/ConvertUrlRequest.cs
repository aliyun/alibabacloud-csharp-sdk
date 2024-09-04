// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.TrafficFxOpen20240815.Models
{
    public class ConvertUrlRequest : TeaModel {
        [NameInMap("countryCallingCode")]
        [Validation(Required=false)]
        public string CountryCallingCode { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("jumpUrl")]
        [Validation(Required=false)]
        public string JumpUrl { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("scene")]
        [Validation(Required=false)]
        public string Scene { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("thirdId")]
        [Validation(Required=false)]
        public string ThirdId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("xenv")]
        [Validation(Required=false)]
        public string Xenv { get; set; }

    }

}
