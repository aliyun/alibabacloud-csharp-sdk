// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateFlowlogRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID of the Cloud Enterprise Network (CEN).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cen-7qthudw0ll6jmc****</para>
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the flow log.</para>
        /// <para>The description can be empty or 1 to 256 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myFlowlog</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the flow log.</para>
        /// <para>The name can be empty or 1 to 128 characters in length and cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myFlowlog</para>
        /// </summary>
        [NameInMap("FlowLogName")]
        [Validation(Required=false)]
        public string FlowLogName { get; set; }

        /// <summary>
        /// <para>The capture window duration of the flow log. Unit: seconds. Valid values: <b>60</b> and <b>600</b>. Default value: <b>600</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("Interval")]
        [Validation(Required=false)]
        public long? Interval { get; set; }

        /// <summary>
        /// <para>The string that defines custom flow log record fields. </para>
        /// <para>The format is defined as:
        /// <c>${field 1}${field 2}${field 3}...${field n}</c></para>
        /// <list type="bullet">
        /// <item><description>If you leave this parameter empty, all default fields are recorded.</description></item>
        /// <item><description>If you specify this parameter, because <c>${srcaddr}${dstaddr}${bytes}</c> are required fields, the string must start with <c>${srcaddr}${dstaddr}${bytes}</c>. For all supported flow log fields, see <a href="https://help.aliyun.com/document_detail/339822.html">Configure a flow log</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>${srcaddr}${dstaddr}${bytes}</para>
        /// </summary>
        [NameInMap("LogFormatString")]
        [Validation(Required=false)]
        public string LogFormatString { get; set; }

        /// <summary>
        /// <para>The Logstore that stores the caught traffic.</para>
        /// <list type="bullet">
        /// <item><description><para>If you have already created a Logstore in the current region, enter the name of the existing Logstore.</para>
        /// </description></item>
        /// <item><description><para>If you have not created a Logstore in the current region, specify a custom name for the Logstore. The system automatically creates the Logstore.
        ///   The naming rules for the Logstore are as follows:</para>
        /// <list type="bullet">
        /// <item><description>The Logstore name must be unique within the same project.</description></item>
        /// <item><description>The name can contain only lowercase letters, digits, hyphens (-), and underscores (_).</description></item>
        /// <item><description>The name must start and end with a lowercase letter or digit.</description></item>
        /// <item><description>The name must be 3 to 63 characters in length.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>flowlog-logstore</para>
        /// </summary>
        [NameInMap("LogStoreName")]
        [Validation(Required=false)]
        public string LogStoreName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The project that stores the caught traffic.</para>
        /// <list type="bullet">
        /// <item><description><para>If you have already created a project in the current region, enter the name of the existing project.</para>
        /// </description></item>
        /// <item><description><para>If you have not created a project in the current region, specify a custom name for the project. The system automatically creates the project.</para>
        /// <para>  The project name must be globally unique within the Alibaba Cloud region and cannot be modified after creation. The naming rules are as follows:</para>
        /// <list type="bullet">
        /// <item><description>The project name must be globally unique.</description></item>
        /// <item><description>The name can contain only lowercase letters, digits, and hyphens (-).</description></item>
        /// <item><description>The name must start and end with a lowercase letter or digit.</description></item>
        /// <item><description>The name must be 3 to 63 characters in length.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>flowlog-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The region ID of the flow log.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/132080.html">DescribeChildInstanceRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tag information.</para>
        /// <para>You can specify up to 20 tags at a time.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateFlowlogRequestTag> Tag { get; set; }
        public class CreateFlowlogRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// <para>Once specified, the tag key cannot be an empty string. The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify up to 20 tag keys at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
            /// <para>Once specified, the tag value cannot be empty. The tag value can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// <para>Each tag key corresponds to one tag value. You can specify up to 20 tag values at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the VPC connection, VPN connection, VBR connection, ECR connection, or inter-region connection.</para>
        /// <para>Leave this parameter empty if you want to configure a flow log for a transit router instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-attach-r6g0m3epjehw57****</para>
        /// </summary>
        [NameInMap("TransitRouterAttachmentId")]
        [Validation(Required=false)]
        public string TransitRouterAttachmentId { get; set; }

        /// <summary>
        /// <para>The transit routing instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tr-bp1rmwxnk221e3fas****</para>
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

    }

}
