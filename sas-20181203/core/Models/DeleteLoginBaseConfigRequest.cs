// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteLoginBaseConfigRequest : TeaModel {
        /// <summary>
        /// <para>The content of the logon security settings to delete. The content varies based on the type of the logon security settings. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>login_common_ip</b>: approved logon IP addresses</description></item>
        /// </list>
        /// <para>Example: {&quot;ip&quot;:&quot;10.23.23.23&quot;}.</para>
        /// <list type="bullet">
        /// <item><description><b>login_common_time</b>: approved logon time ranges</description></item>
        /// </list>
        /// <para>Example: {&quot;startTime&quot;:&quot;06:00:00&quot;,&quot;endTime&quot;:&quot;16:00:00&quot;}.</para>
        /// <list type="bullet">
        /// <item><description><b>login_common_account</b>: approved logon accounts</description></item>
        /// </list>
        /// <para>Example: {&quot;account&quot;:&quot;test_account_001&quot;}.</para>
        /// <list type="bullet">
        /// <item><description><b>login_common_location</b>: approved logon locations</description></item>
        /// </list>
        /// <para>Example: {&quot;location&quot;:&quot;Shanghai&quot;}.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;startTime&quot;:&quot;06:00:00&quot;,&quot;endTime&quot;:&quot;16:00:00&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The UUID of the server whose logon security settings you want to delete.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to query the UUIDs of servers.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4fe8e1cd-3c37-4851-b9de-124da32c****</para>
        /// </summary>
        [NameInMap("Target")]
        [Validation(Required=false)]
        public string Target { get; set; }

        /// <summary>
        /// <para>The type of the logon security settings to delete. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>login_common_ip</b>: approved logon IP addresses</description></item>
        /// <item><description><b>login_common_time</b>: approved logon time ranges</description></item>
        /// <item><description><b>login_common_account</b>: approved logon accounts</description></item>
        /// <item><description><b>login_common_location</b>: approved logon locations</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>login_common_time</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
