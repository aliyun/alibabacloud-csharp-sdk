// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class CreateGatewayApiRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApiName")]
        [Validation(Required=false)]
        public string ApiName { get; set; }

        [NameInMap("ApiStatus")]
        [Validation(Required=false)]
        public string ApiStatus { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ApiType")]
        [Validation(Required=false)]
        public string ApiType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AuthRuleName")]
        [Validation(Required=false)]
        public string AuthRuleName { get; set; }

        [NameInMap("CacheRule")]
        [Validation(Required=false)]
        public CreateGatewayApiRequestCacheRule CacheRule { get; set; }
        public class CreateGatewayApiRequestCacheRule : TeaModel {
            [NameInMap("CacheKey")]
            [Validation(Required=false)]
            public string CacheKey { get; set; }

            [NameInMap("NeedCache")]
            [Validation(Required=false)]
            public bool? NeedCache { get; set; }

            [NameInMap("Ttl")]
            [Validation(Required=false)]
            public long? Ttl { get; set; }

        }

        [NameInMap("Charset")]
        [Validation(Required=false)]
        public string Charset { get; set; }

        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        [NameInMap("DefaultLimitRule")]
        [Validation(Required=false)]
        public CreateGatewayApiRequestDefaultLimitRule DefaultLimitRule { get; set; }
        public class CreateGatewayApiRequestDefaultLimitRule : TeaModel {
            [NameInMap("DefaultLimit")]
            [Validation(Required=false)]
            public bool? DefaultLimit { get; set; }

        }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        [NameInMap("HeaderRules")]
        [Validation(Required=false)]
        public List<CreateGatewayApiRequestHeaderRules> HeaderRules { get; set; }
        public class CreateGatewayApiRequestHeaderRules : TeaModel {
            [NameInMap("HeaderKey")]
            [Validation(Required=false)]
            public string HeaderKey { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("InterfaceType")]
        [Validation(Required=false)]
        public string InterfaceType { get; set; }

        [NameInMap("LimitRule")]
        [Validation(Required=false)]
        public CreateGatewayApiRequestLimitRule LimitRule { get; set; }
        public class CreateGatewayApiRequestLimitRule : TeaModel {
            [NameInMap("DefaultResponse")]
            [Validation(Required=false)]
            public string DefaultResponse { get; set; }

            [NameInMap("Limit")]
            [Validation(Required=false)]
            public double? Limit { get; set; }

            [NameInMap("Mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

        }

        [NameInMap("Method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        [NameInMap("MethodName")]
        [Validation(Required=false)]
        public string MethodName { get; set; }

        [NameInMap("MigrateRule")]
        [Validation(Required=false)]
        public CreateGatewayApiRequestMigrateRule MigrateRule { get; set; }
        public class CreateGatewayApiRequestMigrateRule : TeaModel {
            [NameInMap("FlowPercent")]
            [Validation(Required=false)]
            public int? FlowPercent { get; set; }

            [NameInMap("GroupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            [NameInMap("NeedMigrate")]
            [Validation(Required=false)]
            public bool? NeedMigrate { get; set; }

            [NameInMap("NeedSwitchCompletely")]
            [Validation(Required=false)]
            public bool? NeedSwitchCompletely { get; set; }

        }

        [NameInMap("MockRule")]
        [Validation(Required=false)]
        public CreateGatewayApiRequestMockRule MockRule { get; set; }
        public class CreateGatewayApiRequestMockRule : TeaModel {
            [NameInMap("MockData")]
            [Validation(Required=false)]
            public string MockData { get; set; }

            [NameInMap("NeedMock")]
            [Validation(Required=false)]
            public bool? NeedMock { get; set; }

            [NameInMap("Percentage")]
            [Validation(Required=false)]
            public int? Percentage { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("NeedEncrypt")]
        [Validation(Required=false)]
        public bool? NeedEncrypt { get; set; }

        [NameInMap("NeedJsonp")]
        [Validation(Required=false)]
        public bool? NeedJsonp { get; set; }

        [NameInMap("NeedSign")]
        [Validation(Required=false)]
        public bool? NeedSign { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OperationType")]
        [Validation(Required=false)]
        public string OperationType { get; set; }

        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        [NameInMap("RequestBodyModel")]
        [Validation(Required=false)]
        public string RequestBodyModel { get; set; }

        [NameInMap("RequestParams")]
        [Validation(Required=false)]
        public List<CreateGatewayApiRequestRequestParams> RequestParams { get; set; }
        public class CreateGatewayApiRequestRequestParams : TeaModel {
            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("Location")]
            [Validation(Required=false)]
            public string Location { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("RefType")]
            [Validation(Required=false)]
            public string RefType { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("ResponseBodyModel")]
        [Validation(Required=false)]
        public string ResponseBodyModel { get; set; }

        [NameInMap("RpcParameterTypes")]
        [Validation(Required=false)]
        public List<string> RpcParameterTypes { get; set; }

        [NameInMap("Serialization")]
        [Validation(Required=false)]
        public string Serialization { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
