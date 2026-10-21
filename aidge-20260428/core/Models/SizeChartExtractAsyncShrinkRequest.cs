// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class SizeChartExtractAsyncShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The business order number of the caller. It is recorded when the request is accepted and returned as is when you query the asynchronous task result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>order-20260928-001</para>
        /// </summary>
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The list of column names to extract, such as Size, Bust, and Length.</para>
        /// </summary>
        [NameInMap("ColumnNameList")]
        [Validation(Required=false)]
        public string ColumnNameListShrink { get; set; }

        /// <summary>
        /// <para>The image URL. The image must be in the JPG, JPEG, PNG, BMP, or WEBP format. The resolution must be between 256 × 256 pixels and 3000 × 3000 pixels, and the file size cannot exceed 10 MB.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg">https://ae01.alicdn.com/kf/S342f0070dc9f4be09a6cbed34e90dc8fs.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The output language format. If you do not specify this parameter, the original language is used. If the original image language is Chinese or English, specifying en outputs English, and specifying cn outputs Chinese.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("LanguageModel")]
        [Validation(Required=false)]
        public string LanguageModel { get; set; }

    }

}
