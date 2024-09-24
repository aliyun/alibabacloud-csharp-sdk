// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInstanceRiskLevelsRequest : TeaModel {
        /// <summary>
        /// <para>The information about the instances.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeInstanceRiskLevelsRequestInstances> Instances { get; set; }
        public class DescribeInstanceRiskLevelsRequestInstances : TeaModel {
            /// <summary>
            /// <para>The instance ID of your Cloud Firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vipcloudfw-cn-7mz2fj8nm0u</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The public IP addresses of instances.</para>
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public List<string> InternetIp { get; set; }

            /// <summary>
            /// <para>The private IP address of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.17.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// <para>The UUID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>181ad081-e4f2-4e3e-b925-03b67f648397</para>
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// <para>The language of the content within the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

    }

}
