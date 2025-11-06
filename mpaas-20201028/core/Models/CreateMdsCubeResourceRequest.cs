// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class CreateMdsCubeResourceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0.0.0.1</para>
        /// </summary>
        [NameInMap("AndroidMaxVersion")]
        [Validation(Required=false)]
        public string AndroidMaxVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.0.0.1</para>
        /// </summary>
        [NameInMap("AndroidMinVersion")]
        [Validation(Required=false)]
        public string AndroidMinVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ALIPUBE5C3F6D091419</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>url</para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.0.0.1</para>
        /// </summary>
        [NameInMap("IosMaxVersion")]
        [Validation(Required=false)]
        public string IosMaxVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.0.0.1</para>
        /// </summary>
        [NameInMap("IosMinVersion")]
        [Validation(Required=false)]
        public string IosMinVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>url</para>
        /// </summary>
        [NameInMap("MockDataUrl")]
        [Validation(Required=false)]
        public string MockDataUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OnexFlag")]
        [Validation(Required=false)]
        public bool? OnexFlag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Android,iOS</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>url</para>
        /// </summary>
        [NameInMap("PreviewPictureUrl")]
        [Validation(Required=false)]
        public string PreviewPictureUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>tempalte_test</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>resource desc</para>
        /// </summary>
        [NameInMap("TemplateResourceDesc")]
        [Validation(Required=false)]
        public string TemplateResourceDesc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0.0.0.1</para>
        /// </summary>
        [NameInMap("TemplateResourceVersion")]
        [Validation(Required=false)]
        public string TemplateResourceVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>LZFPEFIM-zh_CN</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dev</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
