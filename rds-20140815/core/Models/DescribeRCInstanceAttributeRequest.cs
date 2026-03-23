// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCInstanceAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-dh2jf9n6j4s14926****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The instance name</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-node</para>
        /// </summary>
        [NameInMap("InstanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

        /// <summary>
        /// <para>Set the upper limit for the number of instance disks in the return result. The valid range is 10 to 500.  </para>
        /// <list type="bullet">
        /// <item><description>If no value is set, the default value is 20.  </description></item>
        /// <item><description>If the set value is less than 10, it is fixed to 10.  </description></item>
        /// <item><description>If the set value is greater than or equal to 10 and less than or equal to 500, the set value is used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxDisksResults")]
        [Validation(Required=false)]
        public long? MaxDisksResults { get; set; }

        /// <summary>
        /// <para>The VPC network IP address of the instance, that is, the private IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XXX.XXX</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
