// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateActivationRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotency of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The <b>ClientToken</b> value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotency</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the activation code. The description must be 1 to 100 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The maximum number of times that the activation code can be used to register managed instances. Valid values: 1 to 1000.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InstanceCount")]
        [Validation(Required=false)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// <para>The default prefix of instance names. The prefix must be 2 to 50 characters in length. It must start with a letter and cannot start with a special character or digit. It can contain only periods (.), underscores (_), hyphens (-), and colons (:) as special characters. It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// <para>Instances registered with the activation code created by calling this operation use this name as a prefix to generate sequential instance names. You can also specify a new instance name to override this default value when you register a managed instance.</para>
        /// <para>When you register a managed instance, if the InstanceName value is specified, instance names in the format of <c>&lt;InstanceName&gt;-001</c> are generated. The number of digits in the sequential number <c>001</c> depends on the number of digits in the InstanceCount value. If the InstanceName value is not specified, the hostname of the host is used as the instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-InstanceName</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The IP addresses of hosts that are allowed to use the activation code. The value can be IPv4 addresses, IPv6 addresses, or CIDR blocks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.0.0.0/0</para>
        /// </summary>
        [NameInMap("IpAddressRange")]
        [Validation(Required=false)]
        public string IpAddressRange { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID. Currently supported regions: China North 1 (Qingdao), China North 2 (Beijing), China North 3 (Zhangjiakou), China North 5 (Hohhot), China North 6 (Ulanqab), China East 1 (Hangzhou), China East 2 (Shanghai), China South 1 (Shenzhen), China South 2 (Heyuan), China South 3 (Guangzhou), China Southwest 1 (Chengdu), China (Hong Kong), Singapore, Japan (Tokyo), US (Silicon Valley), US (Virginia).
        /// You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to view region IDs and other information.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the activation code belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-123******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateActivationRequestTag> Tag { get; set; }
        public class CreateActivationRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of the tag for the managed instance activation code. Valid values of N: 1 to 20. The tag key cannot be an empty string.</para>
            /// <para>If you use a single tag to filter resources, the number of resources that are returned under that tag cannot exceed 1,000. If you use multiple tags to filter resources, the number of resources that are bound with all specified tags cannot exceed 1,000. If the number of resources exceeds 1,000, you must call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation to query the resources.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the tag for the managed instance activation code. Valid values of N: 1 to 20. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The validity period of the activation code. After the validity period expires, the activation code cannot be used to register new instances. Unit: hours. Valid values: 1 to 4.</para>
        /// <para>Default value: 4.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TimeToLiveInHours")]
        [Validation(Required=false)]
        public long? TimeToLiveInHours { get; set; }

    }

}
