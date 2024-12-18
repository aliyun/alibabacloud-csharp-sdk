// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListRemediationTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number. Pages start from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The queried remediation templates.</para>
        /// </summary>
        [NameInMap("RemediationTemplates")]
        [Validation(Required=false)]
        public List<ListRemediationTemplatesResponseBodyRemediationTemplates> RemediationTemplates { get; set; }
        public class ListRemediationTemplatesResponseBodyRemediationTemplates : TeaModel {
            /// <summary>
            /// <para>The type of the remediation template. Valid value: OOS, which indicates Operation Orchestration Service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OOS</para>
            /// </summary>
            [NameInMap("RemediationType")]
            [Validation(Required=false)]
            public string RemediationType { get; set; }

            /// <summary>
            /// <para>The definition of the remediation template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;Parameters&quot;: {
            ///         &quot;bucketName&quot;: {
            ///             &quot;Default&quot;: &quot;{resourceId}&quot;,
            ///             &quot;Description&quot;: {
            ///                 &quot;zh-cn&quot;: &quot;[Required]OSS Bucket Name.&quot;,
            ///                 &quot;en&quot;: &quot;[Required]OSS Bucket Name.&quot;
            ///             },
            ///             &quot;Type&quot;: &quot;String&quot;
            ///         },
            ///         &quot;regionId&quot;: {
            ///             &quot;AssociationProperty&quot;: &quot;RegionId&quot;,
            ///             &quot;Default&quot;: &quot;{regionId}&quot;,
            ///             &quot;Description&quot;: {
            ///                 &quot;zh-cn&quot;: &quot;[Required]The id of target region.&quot;,
            ///                 &quot;en&quot;: &quot;[Required]The id of target region.&quot;
            ///             },
            ///             &quot;Type&quot;: &quot;String&quot;
            ///         },
            ///         &quot;permissionName&quot;: {
            ///             &quot;AllowValues&quot;: &quot;[\&quot;public-read-write\&quot;,\&quot;public-read\&quot;,\&quot;private\&quot;]&quot;,
            ///             &quot;Default&quot;: &quot;private&quot;,
            ///             &quot;Description&quot;: {
            ///                 &quot;zh-cn&quot;: &quot;[Required]ACL Permission Name.&quot;,
            ///                 &quot;en&quot;: &quot;[Required]ACL Permission Name.&quot;
            ///             },
            ///             &quot;Type&quot;: &quot;String&quot;
            ///         }
            ///     }
            /// }</para>
            /// </summary>
            [NameInMap("TemplateDefinition")]
            [Validation(Required=false)]
            public string TemplateDefinition { get; set; }

            /// <summary>
            /// <para>The description of the remediation template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Configure encryption rules for OSSBucket through the PutBucketEncryption interface. Be aware of the risks and exercise caution.</para>
            /// </summary>
            [NameInMap("TemplateDescription")]
            [Validation(Required=false)]
            public string TemplateDescription { get; set; }

            /// <summary>
            /// <para>The ID of the remediation template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACS-OSS-PutBucketAcl</para>
            /// </summary>
            [NameInMap("TemplateIdentifier")]
            [Validation(Required=false)]
            public string TemplateIdentifier { get; set; }

            /// <summary>
            /// <para>The name of the remediation template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Set the ACL of an OSS bucket to private</para>
            /// </summary>
            [NameInMap("TemplateName")]
            [Validation(Required=false)]
            public string TemplateName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FC2C4750-7024-499C-A69F-763543D1CBE3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of remediation templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
