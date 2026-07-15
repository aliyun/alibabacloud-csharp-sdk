// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class DeleteMediasRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletePhysicalFiles")]
        [Validation(Required=false)]
        public bool? DeletePhysicalFiles { get; set; }

        [NameInMap("InputURLs")]
        [Validation(Required=false)]
        public string InputURLs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><b><b><b>b48fb04483915d4f2cd8</b></b></b>,<b><b><b>c48fb37407365d4f2cd8</b></b></b></para>
        /// </summary>
        [NameInMap("MediaIds")]
        [Validation(Required=false)]
        public string MediaIds { get; set; }

    }

}
