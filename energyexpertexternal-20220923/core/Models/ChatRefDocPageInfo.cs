// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class ChatRefDocPageInfo : TeaModel {
        /// <summary>
        /// <para>The rotation angle of the image after the page is converted to an image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0</para>
        /// </summary>
        [NameInMap("angle")]
        [Validation(Required=false)]
        public double? Angle { get; set; }

        /// <summary>
        /// <para>Reserved, can be unused for now.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("excelParseResult")]
        [Validation(Required=false)]
        public string ExcelParseResult { get; set; }

        /// <summary>
        /// <para>The height of the page turns to image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>22</para>
        /// </summary>
        [NameInMap("imageHeight")]
        [Validation(Required=false)]
        public int? ImageHeight { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>The image URL after the page is converted to an image. </description></item>
        /// <item><description>Note: The image URL will be inaccessible after 24 hours, so you need to save it promptly.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("imageUrl")]
        [Validation(Required=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <para>The width of the page turns to image</para>
        /// 
        /// <b>Example:</b>
        /// <para>23</para>
        /// </summary>
        [NameInMap("imageWidth")]
        [Validation(Required=false)]
        public int? ImageWidth { get; set; }

        /// <summary>
        /// <para>The page index in the current document, starting from 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("pageIdCurDoc")]
        [Validation(Required=false)]
        public int? PageIdCurDoc { get; set; }

        /// <summary>
        /// <para>Reserved, can be unused for now.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("pdfParseResult")]
        [Validation(Required=false)]
        public string PdfParseResult { get; set; }

        /// <summary>
        /// <para>Reserved, can be unused for now.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("wordParseResult")]
        [Validation(Required=false)]
        public string WordParseResult { get; set; }

    }

}
