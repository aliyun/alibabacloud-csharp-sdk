// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class CreateGatewayApiShrinkRequest : TeaModel {
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
        public string CacheRuleShrink { get; set; }

        [NameInMap("Charset")]
        [Validation(Required=false)]
        public string Charset { get; set; }

        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        [NameInMap("DefaultLimitRule")]
        [Validation(Required=false)]
        public string DefaultLimitRuleShrink { get; set; }

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
        public string HeaderRulesShrink { get; set; }

        [NameInMap("InterfaceType")]
        [Validation(Required=false)]
        public string InterfaceType { get; set; }

        [NameInMap("LimitRule")]
        [Validation(Required=false)]
        public string LimitRuleShrink { get; set; }

        [NameInMap("Method")]
        [Validation(Required=false)]
        public string Method { get; set; }

        [NameInMap("MethodName")]
        [Validation(Required=false)]
        public string MethodName { get; set; }

        [NameInMap("MigrateRule")]
        [Validation(Required=false)]
        public string MigrateRuleShrink { get; set; }

        [NameInMap("MockRule")]
        [Validation(Required=false)]
        public string MockRuleShrink { get; set; }

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
        public string RequestParamsShrink { get; set; }

        [NameInMap("ResponseBodyModel")]
        [Validation(Required=false)]
        public string ResponseBodyModel { get; set; }

        [NameInMap("RpcParameterTypes")]
        [Validation(Required=false)]
        public string RpcParameterTypesShrink { get; set; }

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
