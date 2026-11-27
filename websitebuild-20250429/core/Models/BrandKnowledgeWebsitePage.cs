// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class BrandKnowledgeWebsitePage : TeaModel {
        /// <summary>
        /// <para>The time when the web page was captured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-26T08:00:00Z</para>
        /// </summary>
        [NameInMap("CapturedAt")]
        [Validation(Required=false)]
        public string CapturedAt { get; set; }

        /// <summary>
        /// <para>The description displayed when a failure occurs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Failed to fetch the web page</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the existing material with the same URL in the same knowledge base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bkm_example001</para>
        /// </summary>
        [NameInMap("ExistingMaterialId")]
        [Validation(Required=false)]
        public string ExistingMaterialId { get; set; }

        /// <summary>
        /// <para>The final web page address obtained after following redirects.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/company/about">https://example.com/company/about</a></para>
        /// </summary>
        [NameInMap("FinalUrl")]
        [Validation(Required=false)]
        public string FinalUrl { get; set; }

        /// <summary>
        /// <para>The business error code when a single-page import fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BrandKnowledge.ImportFailed</para>
        /// </summary>
        [NameInMap("ImportErrorCode")]
        [Validation(Required=false)]
        public string ImportErrorCode { get; set; }

        /// <summary>
        /// <para>The description displayed when a single-page import fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Material quota exceeded</para>
        /// </summary>
        [NameInMap("ImportErrorMessage")]
        [Validation(Required=false)]
        public string ImportErrorMessage { get; set; }

        /// <summary>
        /// <para>The import status of the web page material.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCEEDED</para>
        /// </summary>
        [NameInMap("ImportStatus")]
        [Validation(Required=false)]
        public string ImportStatus { get; set; }

        /// <summary>
        /// <para>The ID of the web page in the collection batch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bwp_example001</para>
        /// </summary>
        [NameInMap("PageId")]
        [Validation(Required=false)]
        public string PageId { get; set; }

        /// <summary>
        /// <para>The fetch result of the web page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>READY</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The title of the web page or content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>About Sample Technology</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The original web page address.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/about">https://example.com/about</a></para>
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
