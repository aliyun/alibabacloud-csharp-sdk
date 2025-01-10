// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGenieip_1_0.Models
{
    public class AddCartoonRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>520a0***eb</para>
        /// </summary>
        [NameInMap("HotelId")]
        [Validation(Required=false)]
        public string HotelId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40c804***697</para>
        /// </summary>
        [NameInMap("StartVideoMd5")]
        [Validation(Required=false)]
        public string StartVideoMd5 { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>https://***.mp4</para>
        /// </summary>
        [NameInMap("StartVideoUrl")]
        [Validation(Required=false)]
        public string StartVideoUrl { get; set; }

    }

}
