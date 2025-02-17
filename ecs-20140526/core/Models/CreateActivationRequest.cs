// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateActivationRequest : TeaModel {
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
        /// <para>The maximum number of times that you can use the activation code to register managed instances. Valid values: 1 to 1000.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("InstanceCount")]
        [Validation(Required=false)]
        public int? InstanceCount { get; set; }

        /// <summary>
        /// <para>The default instance name prefix. The prefix must be 2 to 50 characters in length and can contain letters, digits, periods (.), underscores (_), hyphens (-), and colons (:). The prefix must start with a letter and cannot start with a digit, a special character, <c>http://</c>, or <c>https://</c>.</para>
        /// <para>If you use the activation code that is created by calling the CreateActivation operation to register managed instances, the instances are assigned sequential names that include the value of this parameter as a prefix. You can also specify a new instance name to replace the assigned sequential name when you register a managed instance.</para>
        /// <para>If you specify InstanceName when you register a managed instance, an instance name in the <c>&lt;InstanceName&gt;-&lt;Number&gt;</c> format is generated. The number of digits in the \<Number> value varies based on the number of digits in the <c>InstanceCount</c> value. Example: <c>001</c>. If you do not specify InstanceName, the hostname (Hostname) is used as the instance name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-InstanceName</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>The IP addresses of hosts that can use the activation code. The value can be IPv4 addresses, IPv6 addresses, or CIDR blocks.</para>
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
        /// <para>The region ID. Supported regions: China (Qingdao), China (Beijing), China (Zhangjiakou), China (Hohhot), China (Ulanqab), China (Hangzhou), China (Shanghai), China (Shenzhen), China (Heyuan), China (Guangzhou), China (Chengdu), China (Hong Kong), Singapore, Japan (Tokyo), US (Silicon Valley), and US (Virginia). You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which to assign the activation code.</para>
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
        /// <para>The tags to add to the activation code.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateActivationRequestTag> Tag { get; set; }
        public class CreateActivationRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N to add to the activation code. Valid values of N: 1 to 20. The tag key cannot be an empty string.</para>
            /// <para>If a single tag is specified to query resources, up to 1,000 resources that have this tag added can be displayed in the response. If multiple tags are specified to query resources, up to 1,000 resources that have all these tags added can be displayed in the response. To query more than 1,000 resources that have specified tags, call <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a>.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot start with <c>acs:</c> or <c>aliyun</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N to add to the activation code. Valid values of N: 1 to 20. The tag value can be an empty string.</para>
            /// <para>It can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The validity period of the activation code. After the validity period ends, you can no longer use the activation code to register managed instances. Unit: hours.</para>
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
