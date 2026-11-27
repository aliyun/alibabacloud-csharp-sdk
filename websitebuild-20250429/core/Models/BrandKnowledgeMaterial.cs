// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class BrandKnowledgeMaterial : TeaModel {
        /// <summary>
        /// <para>The document ID of the current available version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bkd_example001</para>
        /// </summary>
        [NameInMap("CurrentDocumentId")]
        [Validation(Required=false)]
        public string CurrentDocumentId { get; set; }

        /// <summary>
        /// <para>Specifies whether the material is enabled for retrieval.</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The error message displayed when a single page fails to be imported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Material quota exceeded</para>
        /// </summary>
        [NameInMap("ImportErrorMessage")]
        [Validation(Required=false)]
        public string ImportErrorMessage { get; set; }

        /// <summary>
        /// <para>The import status of the web material.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCEEDED</para>
        /// </summary>
        [NameInMap("ImportStatus")]
        [Validation(Required=false)]
        public string ImportStatus { get; set; }

        /// <summary>
        /// <para>The ID of the brand knowledge base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bkb_example001</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <para>The ID of the brand material.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bkm_example001</para>
        /// </summary>
        [NameInMap("MaterialId")]
        [Validation(Required=false)]
        public string MaterialId { get; set; }

        /// <summary>
        /// <para>The name of the material.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Official website product introduction</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The document ID of the new version being processed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bkd_example002</para>
        /// </summary>
        [NameInMap("PendingDocumentId")]
        [Validation(Required=false)]
        public string PendingDocumentId { get; set; }

        /// <summary>
        /// <para>The source type of the material.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WEB</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The source web address of the material.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/about">https://example.com/about</a></para>
        /// </summary>
        [NameInMap("SourceUrl")]
        [Validation(Required=false)]
        public string SourceUrl { get; set; }

        /// <summary>
        /// <para>The business status of the material.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The version number of the record, which is used to detect concurrent modifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public long? Version { get; set; }

        /// <summary>
        /// <para>The ID of the Wanxiaozhi site.</para>
        /// 
        /// <b>Example:</b>
        /// <para>WS20261126000000000001</para>
        /// </summary>
        [NameInMap("WebsiteId")]
        [Validation(Required=false)]
        public string WebsiteId { get; set; }

    }

}
