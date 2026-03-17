// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BailianControl20240816.Models
{
    public class GetApiKeyResponseBody : TeaModel {
        [NameInMap("apiKey")]
        [Validation(Required=false)]
        public GetApiKeyResponseBodyApiKey ApiKey { get; set; }
        public class GetApiKeyResponseBodyApiKey : TeaModel {
            [NameInMap("apiKeyValue")]
            [Validation(Required=false)]
            public string ApiKeyValue { get; set; }

            [NameInMap("apikeyId")]
            [Validation(Required=false)]
            public string ApikeyId { get; set; }

            [NameInMap("authSetModel")]
            [Validation(Required=false)]
            public GetApiKeyResponseBodyApiKeyAuthSetModel AuthSetModel { get; set; }
            public class GetApiKeyResponseBodyApiKeyAuthSetModel : TeaModel {
                [NameInMap("accessIps")]
                [Validation(Required=false)]
                public List<string> AccessIps { get; set; }

                [NameInMap("authAppStructure")]
                [Validation(Required=false)]
                public GetApiKeyResponseBodyApiKeyAuthSetModelAuthAppStructure AuthAppStructure { get; set; }
                public class GetApiKeyResponseBodyApiKeyAuthSetModelAuthAppStructure : TeaModel {
                    [NameInMap("agents")]
                    [Validation(Required=false)]
                    public List<string> Agents { get; set; }

                    [NameInMap("highCodeApps")]
                    [Validation(Required=false)]
                    public List<string> HighCodeApps { get; set; }

                    [NameInMap("isAllowAccessAllApps")]
                    [Validation(Required=false)]
                    public bool? IsAllowAccessAllApps { get; set; }

                    [NameInMap("workflows")]
                    [Validation(Required=false)]
                    public List<string> Workflows { get; set; }

                }

                [NameInMap("authModelStructure")]
                [Validation(Required=false)]
                public GetApiKeyResponseBodyApiKeyAuthSetModelAuthModelStructure AuthModelStructure { get; set; }
                public class GetApiKeyResponseBodyApiKeyAuthSetModelAuthModelStructure : TeaModel {
                    [NameInMap("defineModels")]
                    [Validation(Required=false)]
                    public List<string> DefineModels { get; set; }

                    [NameInMap("deployments")]
                    [Validation(Required=false)]
                    public List<string> Deployments { get; set; }

                    [NameInMap("isAllowAccessAllModels")]
                    [Validation(Required=false)]
                    public bool? IsAllowAccessAllModels { get; set; }

                    [NameInMap("models")]
                    [Validation(Required=false)]
                    public List<string> Models { get; set; }

                }

                [NameInMap("authSetMode")]
                [Validation(Required=false)]
                public string AuthSetMode { get; set; }

            }

            [NameInMap("blocked")]
            [Validation(Required=false)]
            public string Blocked { get; set; }

            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("expireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }

            [NameInMap("extData")]
            [Validation(Required=false)]
            public string ExtData { get; set; }

            [NameInMap("parentUid")]
            [Validation(Required=false)]
            public string ParentUid { get; set; }

            [NameInMap("uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
