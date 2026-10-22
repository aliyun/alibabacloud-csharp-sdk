// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class ConfigInstanceWhiteListRequest : TeaModel {
        /// <summary>
        /// <para>Instance ID of the Bastionhost instance for which you want to configure the public IP address whitelist.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/153281.html">DescribeInstances</a> operation to query instance ID of the Bastionhost instance.</para>
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
        /// <para>The IP address whitelist to be configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.162.XX.XX</para>
        /// </summary>
        [NameInMap("WhiteList")]
        [Validation(Required=false)]
        public List<string> WhiteList { get; set; }

        /// <summary>
        /// <para>The IP address whitelist to be configured.</para>
        /// </summary>
        [NameInMap("WhiteListPolicies")]
        [Validation(Required=false)]
        public List<ConfigInstanceWhiteListRequestWhiteListPolicies> WhiteListPolicies { get; set; }
        public class ConfigInstanceWhiteListRequestWhiteListPolicies : TeaModel {
            /// <summary>
            /// <para>The remark or description for the whitelist rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The IP address whitelist to be configured. You can configure up to 50 IP addresses. To add multiple IP addresses to the whitelist, separate them with commas (,). The whitelist cannot contain 0.0.0.0/0.</para>
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
