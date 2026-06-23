// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ConfigInstanceWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Bastionhost instance to configure.</para>
        /// <remarks>
        /// <para>To obtain the instance ID, call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bastionhost-cn-78v1gh****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The region ID of the Bastionhost instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of IP addresses to add to the whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.162.XX.XX</para>
        /// </summary>
        [NameInMap("WhiteList")]
        [Validation(Required=false)]
        public List<string> WhiteList { get; set; }

        /// <summary>
        /// <para>The policies for the public IP address whitelist.</para>
        /// </summary>
        [NameInMap("WhiteListPolicies")]
        [Validation(Required=false)]
        public List<ConfigInstanceWhiteListRequestWhiteListPolicies> WhiteListPolicies { get; set; }
        public class ConfigInstanceWhiteListRequestWhiteListPolicies : TeaModel {
            /// <summary>
            /// <para>The description of this whitelist rule.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The IP addresses to add to the whitelist. You can specify up to 50 IP addresses, separated by a comma.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.162.XX.XX,192.168.XX.XX</para>
            /// </summary>
            [NameInMap("Entry")]
            [Validation(Required=false)]
            public string Entry { get; set; }

        }

    }

}
