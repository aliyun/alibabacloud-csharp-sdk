// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Address : TeaModel {
        /// <summary>
        /// <para>The full address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>中国浙江省杭州市余杭区文一西路969号</para>
        /// </summary>
        [NameInMap("AddressLine")]
        [Validation(Required=false)]
        public string AddressLine { get; set; }

        /// <summary>
        /// <para>The city.</para>
        /// 
        /// <b>Example:</b>
        /// <para>杭州市</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>The country or region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>中国</para>
        /// </summary>
        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        /// <summary>
        /// <para>The district.</para>
        /// 
        /// <b>Example:</b>
        /// <para>余杭区</para>
        /// </summary>
        [NameInMap("District")]
        [Validation(Required=false)]
        public string District { get; set; }

        /// <summary>
        /// <para>The BCP 47 language code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-Hans</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The province.</para>
        /// 
        /// <b>Example:</b>
        /// <para>浙江省</para>
        /// </summary>
        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        /// <summary>
        /// <para>The street.</para>
        /// 
        /// <b>Example:</b>
        /// <para>文一西路</para>
        /// </summary>
        [NameInMap("Township")]
        [Validation(Required=false)]
        public string Township { get; set; }

    }

}
