// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class BrandKnowledgeMaterial : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>bkd_example001</para>
        /// </summary>
        [NameInMap("CurrentDocumentId")]
        [Validation(Required=false)]
        public string CurrentDocumentId { get; set; }

        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

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
        /// <para>bkb_example001</para>
        /// </summary>
        [NameInMap("KnowledgeBaseId")]
        [Validation(Required=false)]
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bkm_example001</para>
        /// </summary>
        [NameInMap("MaterialId")]
        [Validation(Required=false)]
        public string MaterialId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>官网产品介绍</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>bkd_example002</para>
        /// </summary>
        [NameInMap("PendingDocumentId")]
        [Validation(Required=false)]
        public string PendingDocumentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WEB</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://example.com/about">https://example.com/about</a></para>
        /// </summary>
        [NameInMap("SourceUrl")]
        [Validation(Required=false)]
        public string SourceUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public long? Version { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>WS20261126000000000001</para>
        /// </summary>
        [NameInMap("WebsiteId")]
        [Validation(Required=false)]
        public string WebsiteId { get; set; }

    }

}
