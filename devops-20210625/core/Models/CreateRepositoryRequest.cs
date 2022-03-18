// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateRepositoryRequest : TeaModel {
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// 代码库头像地址
        /// </summary>
        [NameInMap("avatarUrl")]
        [Validation(Required=false)]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// 代码库描述
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// gitignore模板类型
        /// </summary>
        [NameInMap("gitignoreType")]
        [Validation(Required=false)]
        public string GitignoreType { get; set; }

        /// <summary>
        /// 导入时使用的账号
        /// </summary>
        [NameInMap("importAccount")]
        [Validation(Required=false)]
        public string ImportAccount { get; set; }

        /// <summary>
        /// 使用使用demo库内容进行初始化
        /// </summary>
        [NameInMap("importDemoProject")]
        [Validation(Required=false)]
        public bool? ImportDemoProject { get; set; }

        /// <summary>
        /// 导入代码库类型 (GIT: Git库, SVN: SVN库)
        /// </summary>
        [NameInMap("importRepoType")]
        [Validation(Required=false)]
        public string ImportRepoType { get; set; }

        /// <summary>
        /// 导入SVN库的设置
        /// </summary>
        [NameInMap("importSvnRepoConfig")]
        [Validation(Required=false)]
        public CreateRepositoryRequestImportSvnRepoConfig ImportSvnRepoConfig { get; set; }
        public class CreateRepositoryRequestImportSvnRepoConfig : TeaModel {
            [NameInMap("authorMapping")]
            [Validation(Required=false)]
            public string AuthorMapping { get; set; }
            [NameInMap("branchMapping")]
            [Validation(Required=false)]
            public string BranchMapping { get; set; }
            [NameInMap("noBranches")]
            [Validation(Required=false)]
            public bool? NoBranches { get; set; }
            [NameInMap("noTags")]
            [Validation(Required=false)]
            public bool? NoTags { get; set; }
            [NameInMap("password")]
            [Validation(Required=false)]
            public string Password { get; set; }
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }
            [NameInMap("rootIsTrunk")]
            [Validation(Required=false)]
            public bool? RootIsTrunk { get; set; }
            [NameInMap("standardLayout")]
            [Validation(Required=false)]
            public bool? StandardLayout { get; set; }
            [NameInMap("svnImportUrl")]
            [Validation(Required=false)]
            public string SvnImportUrl { get; set; }
            [NameInMap("tagMapping")]
            [Validation(Required=false)]
            public string TagMapping { get; set; }
            [NameInMap("trunkMapping")]
            [Validation(Required=false)]
            public string TrunkMapping { get; set; }
            [NameInMap("username")]
            [Validation(Required=false)]
            public string Username { get; set; }
        };

        /// <summary>
        /// 导入时账号的token
        /// </summary>
        [NameInMap("importToken")]
        [Validation(Required=false)]
        public string ImportToken { get; set; }

        /// <summary>
        /// import_token字段的传输格式，使用明文或rsa加密
        /// </summary>
        [NameInMap("importTokenEncrypted")]
        [Validation(Required=false)]
        public string ImportTokenEncrypted { get; set; }

        /// <summary>
        /// 导入地址（http协议地址）
        /// </summary>
        [NameInMap("importUrl")]
        [Validation(Required=false)]
        public string ImportUrl { get; set; }

        /// <summary>
        /// 初始化标准智能化服务
        /// </summary>
        [NameInMap("initStandardService")]
        [Validation(Required=false)]
        public bool? InitStandardService { get; set; }

        /// <summary>
        /// 是否启用加密
        /// </summary>
        [NameInMap("isCryptoEnabled")]
        [Validation(Required=false)]
        public bool? IsCryptoEnabled { get; set; }

        /// <summary>
        /// 本地导入代码库的远程地址
        /// </summary>
        [NameInMap("localImportUrl")]
        [Validation(Required=false)]
        public string LocalImportUrl { get; set; }

        /// <summary>
        /// 代码库名称
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// 代码库父路径id
        /// </summary>
        [NameInMap("namespaceId")]
        [Validation(Required=false)]
        public long? NamespaceId { get; set; }

        /// <summary>
        /// 代码库路径
        /// </summary>
        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// 自动创建readme类型 (EMPTY: 仅创建README.md, USER_GUIDE: 包含新手引导)
        /// </summary>
        [NameInMap("readmeType")]
        [Validation(Required=false)]
        public string ReadmeType { get; set; }

        [NameInMap("visibilityLevel")]
        [Validation(Required=false)]
        public int? VisibilityLevel { get; set; }

        [NameInMap("createParentPath")]
        [Validation(Required=false)]
        public bool? CreateParentPath { get; set; }

        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        [NameInMap("sync")]
        [Validation(Required=false)]
        public bool? Sync { get; set; }

    }

}
