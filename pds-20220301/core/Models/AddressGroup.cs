// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class AddressGroup : TeaModel {
        /// <summary>
        /// <para>The information about the site.</para>
        /// </summary>
        [NameInMap("address_detail")]
        [Validation(Required=false)]
        public Address AddressDetail { get; set; }

        /// <summary>
        /// <para>The number of files in the site group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        /// <summary>
        /// <para>The ID of the cover image of the site.</para>
        /// </summary>
        [NameInMap("cover_file_id")]
        [Validation(Required=false)]
        public string CoverFileId { get; set; }

        /// <summary>
        /// <para>The URL of the cover image of the site.</para>
        /// </summary>
        [NameInMap("cover_url")]
        [Validation(Required=false)]
        public string CoverUrl { get; set; }

        /// <summary>
        /// <para>The latitude and longitude of the site.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30.12231,120.1212</para>
        /// </summary>
        [NameInMap("location")]
        [Validation(Required=false)]
        public string Location { get; set; }

        /// <summary>
        /// <para>The name of the site.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
