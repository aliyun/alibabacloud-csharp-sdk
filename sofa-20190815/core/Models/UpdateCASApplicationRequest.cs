// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateCASApplicationRequest : TeaModel {
        [NameInMap("AppDomainId")]
        [Validation(Required=false)]
        public string AppDomainId { get; set; }

        [NameInMap("AppExtraInfos")]
        [Validation(Required=false)]
        public List<UpdateCASApplicationRequestAppExtraInfos> AppExtraInfos { get; set; }
        public class UpdateCASApplicationRequestAppExtraInfos : TeaModel {
            [NameInMap("AppExtrainfoId")]
            [Validation(Required=false)]
            public string AppExtrainfoId { get; set; }

            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("TemplateDataId")]
            [Validation(Required=false)]
            public string TemplateDataId { get; set; }

            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }

            [NameInMap("UtcModified")]
            [Validation(Required=false)]
            public string UtcModified { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("AppLevelJsonStr")]
        [Validation(Required=false)]
        public string AppLevelJsonStr { get; set; }

        [NameInMap("AppOwnerJsonStr")]
        [Validation(Required=false)]
        public string AppOwnerJsonStr { get; set; }

        [NameInMap("ArchetypeJsonStr")]
        [Validation(Required=false)]
        public string ArchetypeJsonStr { get; set; }

        [NameInMap("BuildpackVersion")]
        [Validation(Required=false)]
        public string BuildpackVersion { get; set; }

        [NameInMap("ChineseName")]
        [Validation(Required=false)]
        public string ChineseName { get; set; }

        [NameInMap("CodeRepositoryJsonStr")]
        [Validation(Required=false)]
        public string CodeRepositoryJsonStr { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("ExtraParams")]
        [Validation(Required=false)]
        public string ExtraParams { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("IsService")]
        [Validation(Required=false)]
        public bool? IsService { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("StackId")]
        [Validation(Required=false)]
        public string StackId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        [NameInMap("UtcCreate")]
        [Validation(Required=false)]
        public string UtcCreate { get; set; }

        [NameInMap("UtcModified")]
        [Validation(Required=false)]
        public string UtcModified { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
