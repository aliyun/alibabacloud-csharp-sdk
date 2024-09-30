// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Docmind_api20220711.Models
{
    public class SubmitConvertPdfToExcelJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>convertPdfToExcel.pdf</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://gw.alipayobjects.com/os/basement_prod/598b9edf-5287-4065-9e36-464305c60698.pdf">https://gw.alipayobjects.com/os/basement_prod/598b9edf-5287-4065-9e36-464305c60698.pdf</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        [NameInMap("ForceExportInnerImage")]
        [Validation(Required=false)]
        public bool? ForceExportInnerImage { get; set; }

        [NameInMap("ForceMergeExcel")]
        [Validation(Required=false)]
        public bool? ForceMergeExcel { get; set; }

    }

}
