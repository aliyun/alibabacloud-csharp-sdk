/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Address : TeaModel {
        /// <summary>
        /// AddressLine
        /// </summary>
        [NameInMap("AddressLine")]
        [Validation(Required=false)]
        public string AddressLine { get; set; }

        /// <summary>
        /// City
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// Country
        /// </summary>
        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// District
        /// </summary>
        [NameInMap("District")]
        [Validation(Required=false)]
        public string District { get; set; }

        /// <summary>
        /// Language
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// Province
        /// </summary>
        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// Township
        /// </summary>
        [NameInMap("Township")]
        [Validation(Required=false)]
        public string Township { get; set; }

    }

}
