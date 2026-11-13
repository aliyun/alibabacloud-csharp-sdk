// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class CreateDataServiceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the API Gateway group to which the business flow is bound. You can view the ID on the Group Details page in the API Gateway console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000abcd</para>
        /// </summary>
        [NameInMap("ApiGatewayGroupId")]
        [Validation(Required=false)]
        public string ApiGatewayGroupId { get; set; }

        /// <summary>
        /// <para>The gateway version. Valid values: 1: API Gateway. 2: Cloud-native API Gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ApigwVersion")]
        [Validation(Required=false)]
        public int? ApigwVersion { get; set; }

        /// <summary>
        /// <para>The ID of the destination REST API for the cloud-native API gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>api-xxx</para>
        /// </summary>
        [NameInMap("CloudNativeApigwGroupId")]
        [Validation(Required=false)]
        public string CloudNativeApigwGroupId { get; set; }

        /// <summary>
        /// <para>The description of the business flow.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test business flow</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the business flow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Business flow name</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The ID of the workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public long? ProjectId { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> The tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10002</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public long? TenantId { get; set; }

    }

}
