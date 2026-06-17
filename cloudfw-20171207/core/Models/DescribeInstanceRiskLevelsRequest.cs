// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeInstanceRiskLevelsRequest : TeaModel {
        /// <summary>
        /// <para>The list of instances.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeInstanceRiskLevelsRequestInstances> Instances { get; set; }
        public class DescribeInstanceRiskLevelsRequestInstances : TeaModel {
            /// <summary>
            /// <para>The ID of the Cloud Firewall instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vipcloudfw-cn-7mz2fj8nm0u</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The public IP address of the instance.</para>
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
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
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
