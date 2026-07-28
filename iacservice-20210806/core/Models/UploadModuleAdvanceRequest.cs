// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class UploadModuleAdvanceRequest : TeaModel {
        /// <summary>
        /// <para>The template content.</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public Dictionary<string, string> Code { get; set; }

        /// <summary>
        /// <para>The module ID. This parameter is valid and required when resourceType is set to Module.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mod-kw1018ogp2m3qp22b3k31d</para>
        /// </summary>
        [NameInMap("moduleId")]
        [Validation(Required=false)]
        public string ModuleId { get; set; }

        /// <summary>
        /// <para>The name of the module. This parameter is valid and required when resourceType is set to RegistryModule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RegistryModule-test0ef88</para>
        /// </summary>
        [NameInMap("moduleName")]
        [Validation(Required=false)]
        public string ModuleName { get; set; }

        /// <summary>
        /// <para>The workspace name. This parameter is valid and required when resourceType is set to RegistryModule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_namespace</para>
        /// </summary>
        [NameInMap("namespaceName")]
        [Validation(Required=false)]
        public string NamespaceName { get; set; }

        /// <summary>
        /// <para>The local zip file to upload. The file size cannot exceed 10 MB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>url</para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public Stream UrlObject { get; set; }

    }

}
