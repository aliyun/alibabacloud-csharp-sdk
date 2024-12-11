// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListInstancePackageStatesResponseBody : TeaModel {
        /// <summary>
        /// <para>Page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>Token string for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MTRBMDc0NjAtRUJFNy00N0NBLTk3NTctzxxxxxxx</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>List of extensions</para>
        /// </summary>
        [NameInMap("PackageStates")]
        [Validation(Required=false)]
        public List<ListInstancePackageStatesResponseBodyPackageStates> PackageStates { get; set; }
        public class ListInstancePackageStatesResponseBodyPackageStates : TeaModel {
            /// <summary>
            /// <para>Description</para>
            /// 
            /// <b>Example:</b>
            /// <para>template description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Parameters</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Parameters")]
            [Validation(Required=false)]
            public string Parameters { get; set; }

            /// <summary>
            /// <para>Publisher</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud</para>
            /// </summary>
            [NameInMap("Publisher")]
            [Validation(Required=false)]
            public string Publisher { get; set; }

            /// <summary>
            /// <para>Template type</para>
            /// 
            /// <b>Example:</b>
            /// <para>Package</para>
            /// </summary>
            [NameInMap("TemplateCategory")]
            [Validation(Required=false)]
            public string TemplateCategory { get; set; }

            /// <summary>
            /// <para>Template ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>087b1e11072a40259f6fxxxxxxxxx</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>Template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS-ECS-Docker</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

            /// <summary>
            /// <para>Template version number</para>
            /// 
            /// <b>Example:</b>
            /// <para>v3</para>
            /// </summary>
            [NameInMap("TemplateVersion")]
            [Validation(Required=false)]
            public string TemplateVersion { get; set; }

            /// <summary>
            /// <para>Template version name</para>
            /// 
            /// <b>Example:</b>
            /// <para>fix bug</para>
            /// </summary>
            [NameInMap("TemplateVersionName")]
            [Validation(Required=false)]
            public string TemplateVersionName { get; set; }

            /// <summary>
            /// <para>Update time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-05-04T11:17:28</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>ID of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>1306108F-610C-40FD-AAD5-XXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
