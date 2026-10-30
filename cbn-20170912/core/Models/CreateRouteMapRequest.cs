// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateRouteMapRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can generate a parameter value on your client to ensure that the value is unique across different requests. The client token only supports ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the route map.</para>
        /// <para>The description can be empty or 1 to 256 characters in length. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>descname</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The direction of the route map. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Inbound</b>: inbound. The direction in which the instance route table receives routes from the associated network instance. This affects the routes that the current instance can learn from the associated network instance.</description></item>
        /// <item><description><b>Outbound</b>: outbound. The direction in which the instance route table sends routes to the associated network instance. This affects the routes that the current instance advertises to the associated network instance.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Inbound</para>
        /// </summary>
        [NameInMap("Direction")]
        [Validation(Required=false)]
        public string Direction { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on the request, including permission and instance status checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): sends a normal request. After the check is passed, the route map is directly created.</description></item>
        /// <item><description><b>true</b>: sends a dry run request. Only the check is performed, and the route map is not created. Check items include whether required parameters are specified and the request format. If the check fails, the corresponding error is returned. If the check is passed, the error code <c>DryRunOperation</c> is returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The name of the route map.</para>
        /// <para>The name can be empty or 1 to 128 characters in length. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Policy priority of the route map. Valid values: <b>1</b> to <b>100</b>. A smaller value indicates a higher priority.</para>
        /// <remarks>
        /// <para>Policy priority of a route map must be unique within an Alibaba Cloud account. When a route map is executed, the system matches route map rules starting from the route map with the smallest priority value based on policy priority of the route map rules. Therefore, when you specify policy priority of a route map, make sure that policy priority meets your expected matching order.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm3unpnuw****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tag information.</para>
        /// <para>You can specify up to 20 tags at a time.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateRouteMapRequestTag> Tag { get; set; }
        public class CreateRouteMapRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// <para>If you specify this parameter, it cannot be an empty string. The tag key can be up to 64 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify up to 20 tag keys at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagtest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
            /// <para>If you specify this parameter, it cannot be empty. The tag value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>Each tag key corresponds to a tag value. You can specify up to 20 tag values at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagtest</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
