// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class SizeChartExtractRequest : TeaModel {
        /// <summary>
        /// <para>The list of column names to extract, such as Size, Bust, and Length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;Size&quot;,&quot;Bust&quot;,&quot;Length&quot;]</para>
        /// </summary>
        [NameInMap("ColumnNameList")]
        [Validation(Required=false)]
        public List<string> ColumnNameList { get; set; }

        /// <summary>
        /// <para>The URL of the size chart image to extract.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/size_chart.jpg">https://example.com/size_chart.jpg</a></para>
        /// </summary>
        [NameInMap("ImageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The language model that controls the output language, such as en and cn.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("LanguageModel")]
        [Validation(Required=false)]
        public string LanguageModel { get; set; }

    }

}
