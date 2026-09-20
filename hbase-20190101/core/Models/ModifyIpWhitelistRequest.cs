// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class ModifyIpWhitelistRequest : TeaModel {
        /// <summary>
        /// <para>The ID of target instance. You can call <a href="https://help.aliyun.com/document_detail/144595.html">DescribeInstances</a> to obtain target instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-bp1uoihlf82e8****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The name of the whitelist group for the target instance. You can invoke <a href="https://help.aliyun.com/document_detail/144606.html">DescribeIpWhitelist</a> to obtain the whitelist group name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>group_01</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The IP addresses in the whitelist group after modification. Separate multiple IP addresses with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>42.120.XX.XX</para>
        /// </summary>
        [NameInMap("IpList")]
        [Validation(Required=false)]
        public string IpList { get; set; }

        /// <summary>
        /// <para>The version of the IP address. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>4</b>: IPv4.</description></item>
        /// <item><description><b>6</b>: IPv6.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

    }

}
