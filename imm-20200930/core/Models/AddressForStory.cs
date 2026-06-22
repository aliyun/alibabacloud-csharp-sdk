// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class AddressForStory : TeaModel {
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
        /// <para>The country.</para>
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
        /// <para>滨江区</para>
        /// </summary>
        [NameInMap("District")]
        [Validation(Required=false)]
        public string District { get; set; }

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
        /// <para>The township.</para>
        /// 
        /// <b>Example:</b>
        /// <para>长河街道</para>
        /// </summary>
        [NameInMap("Township")]
        [Validation(Required=false)]
        public string Township { get; set; }

    }

}
