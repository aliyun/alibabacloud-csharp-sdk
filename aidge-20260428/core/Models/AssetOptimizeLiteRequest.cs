// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aidge20260428.Models
{
    public class AssetOptimizeLiteRequest : TeaModel {
        /// <summary>
        /// <para>The custom glossary for term intervention.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Glossary")]
        [Validation(Required=false)]
        public string Glossary { get; set; }

        /// <summary>
        /// <para>Specifies whether product area translation is included.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludingProductArea")]
        [Validation(Required=false)]
        public bool? IncludingProductArea { get; set; }

        /// <summary>
        /// <para>Specifies whether translation is needed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("NeedTrans")]
        [Validation(Required=false)]
        public bool? NeedTrans { get; set; }

        /// <summary>
        /// <para>The product URL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://detail.1688.com/offer/631960323816.html">https://detail.1688.com/offer/631960323816.html</a></para>
        /// </summary>
        [NameInMap("ProductUrl")]
        [Validation(Required=false)]
        public string ProductUrl { get; set; }

        /// <summary>
        /// <para>The source language code, such as zh.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("SourceLanguage")]
        [Validation(Required=false)]
        public string SourceLanguage { get; set; }

        /// <summary>
        /// <para>The source platform, such as 1688.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1688</para>
        /// </summary>
        [NameInMap("SourcePlatform")]
        [Validation(Required=false)]
        public string SourcePlatform { get; set; }

        /// <summary>
        /// <para>The target language code, such as en.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("TargetLanguage")]
        [Validation(Required=false)]
        public string TargetLanguage { get; set; }

        /// <summary>
        /// <para>The target platform, such as temu.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>temu</para>
        /// </summary>
        [NameInMap("TargetPlatform")]
        [Validation(Required=false)]
        public string TargetPlatform { get; set; }

        /// <summary>
        /// <para>Specifies whether to translate brand names in images. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("TranslatingBrandInTheProduct")]
        [Validation(Required=false)]
        public bool? TranslatingBrandInTheProduct { get; set; }

    }

}
