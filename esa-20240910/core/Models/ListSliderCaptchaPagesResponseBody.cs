// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class ListSliderCaptchaPagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of custom slider CAPTCHA pages.</para>
        /// </summary>
        [NameInMap("Pages")]
        [Validation(Required=false)]
        public List<ListSliderCaptchaPagesResponseBodyPages> Pages { get; set; }
        public class ListSliderCaptchaPagesResponseBodyPages : TeaModel {
            /// <summary>
            /// <para>The ID of the custom slider CAPTCHA page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50000001</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The name of the custom slider CAPTCHA page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of associated site IDs.</para>
            /// </summary>
            [NameInMap("SiteIds")]
            [Validation(Required=false)]
            public List<long?> SiteIds { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15C66C7B-671A-4297-9187-2C4477247A74</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
