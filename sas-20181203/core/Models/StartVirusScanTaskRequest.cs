// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class StartVirusScanTaskRequest : TeaModel {
        /// <summary>
        /// <para>The asset on which you want to perform a virus scan task. You can select servers or server groups to scan for viruses. The value is a string that consists of JSON arrays. Each element in a JSON array is a JSON struct that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><para><b>type</b>: the type of the asset on which you want to perform a virus scan task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>groupId</b>: server group.</description></item>
        /// <item><description><b>uuid</b>: server.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>name</b>: the name of the server or server group.</para>
        /// </description></item>
        /// <item><description><para><b>target</b>: the asset on which you want to perform a virus scan task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>type</b> to <b>groupId</b>, you must set this field to the ID of the server group. You can call the <a href="~~DescribeAllGroups~~">DescribeAllGroups</a> operation to query the IDs of server groups.</description></item>
        /// <item><description>If you set <b>type</b> to <b>uuid</b>, you must set this field to the UUID of the server. You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to query the UUIDs of servers.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;type&quot;:&quot;uuid&quot;,&quot;name&quot;:&quot;Host001&quot;,&quot;target&quot;:&quot;503201a7-14c6-4280-801b-1169ed42****&quot;}]</para>
        /// </summary>
        [NameInMap("TargetInfo")]
        [Validation(Required=false)]
        public string TargetInfo { get; set; }

    }

}
