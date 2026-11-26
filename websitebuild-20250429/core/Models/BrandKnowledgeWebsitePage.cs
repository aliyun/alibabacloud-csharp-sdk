// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class BrandKnowledgeWebsitePage : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2026-11-26T08:00:00Z</para>
        /// </summary>
        [NameInMap("CapturedAt")]
        [Validation(Required=false)]
        public string CapturedAt { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>网页读取失败</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bkm_example001</para>
        /// </summary>
        [NameInMap("ExistingMaterialId")]
        [Validation(Required=false)]
        public string ExistingMaterialId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://example.com/company/about">https://example.com/company/about</a></para>
        /// </summary>
        [NameInMap("FinalUrl")]
        [Validation(Required=false)]
        public string FinalUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BrandKnowledge.ImportFailed</para>
        /// </summary>
        [NameInMap("ImportErrorCode")]
        [Validation(Required=false)]
        public string ImportErrorCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>资料额度已满</para>
        /// </summary>
        [NameInMap("ImportErrorMessage")]
        [Validation(Required=false)]
        public string ImportErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCEEDED</para>
        /// </summary>
        [NameInMap("ImportStatus")]
        [Validation(Required=false)]
        public string ImportStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bwp_example001</para>
        /// </summary>
        [NameInMap("PageId")]
        [Validation(Required=false)]
        public string PageId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>READY</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>关于示例科技</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://example.com/about">https://example.com/about</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
