// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateRepositoryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>f0b1e61db5961df5975a93f9129d2513</para>
        /// </summary>
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://tcs-devops.aliyuncs.com/thumbnail/112afcb7a6a35c3f67f1bea827c4/w/100/h/100">https://tcs-devops.aliyuncs.com/thumbnail/112afcb7a6a35c3f67f1bea827c4/w/100/h/100</a></para>
        /// </summary>
        [NameInMap("avatarUrl")]
        [Validation(Required=false)]
        public string AvatarUrl { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Java</para>
        /// </summary>
        [NameInMap("gitignoreType")]
        [Validation(Required=false)]
        public string GitignoreType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>codeup-test</para>
        /// </summary>
        [NameInMap("importAccount")]
        [Validation(Required=false)]
        public string ImportAccount { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("importDemoProject")]
        [Validation(Required=false)]
        public bool? ImportDemoProject { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GIT</para>
        /// </summary>
        [NameInMap("importRepoType")]
        [Validation(Required=false)]
        public string ImportRepoType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxxx</para>
        /// </summary>
        [NameInMap("importToken")]
        [Validation(Required=false)]
        public string ImportToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>text</para>
        /// </summary>
        [NameInMap("importTokenEncrypted")]
        [Validation(Required=false)]
        public string ImportTokenEncrypted { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://github.com/a/b.git">https://github.com/a/b.git</a></para>
        /// </summary>
        [NameInMap("importUrl")]
        [Validation(Required=false)]
        public string ImportUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("initStandardService")]
        [Validation(Required=false)]
        public bool? InitStandardService { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isCryptoEnabled")]
        [Validation(Required=false)]
        public bool? IsCryptoEnabled { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("localImportUrl")]
        [Validation(Required=false)]
        public string LocalImportUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("namespaceId")]
        [Validation(Required=false)]
        public long? NamespaceId { get; set; }

        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>USER_GUIDE</para>
        /// </summary>
        [NameInMap("readmeType")]
        [Validation(Required=false)]
        public string ReadmeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("visibilityLevel")]
        [Validation(Required=false)]
        public int? VisibilityLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("createParentPath")]
        [Validation(Required=false)]
        public bool? CreateParentPath { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60de7a6852743a5162b5f957</para>
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("sync")]
        [Validation(Required=false)]
        public bool? Sync { get; set; }

    }

}
