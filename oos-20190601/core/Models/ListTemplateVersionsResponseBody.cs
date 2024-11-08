// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListTemplateVersionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NJSNDKLJS-SJKJDO090k30-JSDK232</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E6CD612B-5889-4F1A-823F-8A4029E46</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The versions of the template.</para>
        /// </summary>
        [NameInMap("TemplateVersions")]
        [Validation(Required=false)]
        public List<ListTemplateVersionsResponseBodyTemplateVersions> TemplateVersions { get; set; }
        public class ListTemplateVersionsResponseBodyTemplateVersions : TeaModel {
            /// <summary>
            /// <para>The description of the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Detach the eip from the special instance.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The format of the template content. Valid values: YAML and JSON.</para>
            /// 
            /// <b>Example:</b>
            /// <para>YAML</para>
            /// </summary>
            [NameInMap("TemplateFormat")]
            [Validation(Required=false)]
            public string TemplateFormat { get; set; }

            /// <summary>
            /// <para>The number of the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

            /// <summary>
            /// <para>The user who last updated the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>foo</para>
            /// </summary>
            [NameInMap("UpdatedBy")]
            [Validation(Required=false)]
            public string UpdatedBy { get; set; }

            /// <summary>
            /// <para>The time when the version was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-05-19T06:05:41Z</para>
            /// </summary>
            [NameInMap("UpdatedDate")]
            [Validation(Required=false)]
            public string UpdatedDate { get; set; }

            /// <summary>
            /// <para>The name of the version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>baz</para>
            /// </summary>
            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

        }

    }

}
