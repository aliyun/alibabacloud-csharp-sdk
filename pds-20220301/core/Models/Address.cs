// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class Address : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>杭州市</para>
        /// </summary>
        [NameInMap("city")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>中国</para>
        /// </summary>
        [NameInMap("country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>余杭区</para>
        /// </summary>
        [NameInMap("district")]
        [Validation(Required=false)]
        public string District { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>浙江省</para>
        /// </summary>
        [NameInMap("province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>文一西路</para>
        /// </summary>
        [NameInMap("township")]
        [Validation(Required=false)]
        public string Township { get; set; }

    }

}
