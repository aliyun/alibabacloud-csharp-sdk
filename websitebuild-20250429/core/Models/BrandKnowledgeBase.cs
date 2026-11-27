// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class BrandKnowledgeBase : TeaModel {
        /// <summary>
        /// <para>The creation time, represented as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1795658400000</para>
        /// </summary>
        [NameInMap("CreatedAt")]
        [Validation(Required=false)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// <para>The profile of the brand or collection object.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Provides software services to enterprises</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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
        /// <para>The brand name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Example Technology</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The URL of the official brand website.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://example.com/">https://example.com/</a></para>
        /// </summary>
        [NameInMap("OfficialSiteUrl")]
        [Validation(Required=false)]
        public string OfficialSiteUrl { get; set; }

        /// <summary>
        /// <para>The structured brand profile.</para>
        /// </summary>
        [NameInMap("Profile")]
        [Validation(Required=false)]
        public BrandKnowledgeProfile Profile { get; set; }

        /// <summary>
        /// <para>The list of suggested questions for GEO monitoring.</para>
        /// </summary>
        [NameInMap("Questions")]
        [Validation(Required=false)]
        public List<BrandKnowledgeQuestion> Questions { get; set; }

        /// <summary>
        /// <para>The status of the brand knowledge base.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The last update time, represented as a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1795658460000</para>
        /// </summary>
        [NameInMap("UpdatedAt")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

        /// <summary>
        /// <para>The record version number used to detect concurrent modifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Version")]
        [Validation(Required=false)]
        public long? Version { get; set; }

    }

}
