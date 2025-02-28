// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyRCInstanceAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The hostname of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testHost1</para>
        /// </summary>
        [NameInMap("HostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf62br2491p5l****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The new password of the instance.</para>
        /// <list type="bullet">
        /// <item><description>The value must be 8 to 30 characters in length.</description></item>
        /// <item><description>The value must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters include <c>()</c> ~ ! @ # $ % ^ &amp; \* - _ + = \`</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2F9e9@a69c!e18b569c8</para>
        /// </summary>
        [NameInMap("Password")]
        [Validation(Required=false)]
        public string Password { get; set; }

        /// <summary>
        /// <para>Specifies whether to restart the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Reboot")]
        [Validation(Required=false)]
        public bool? Reboot { get; set; }

        /// <summary>
        /// <para>The region ID of the instance. You can call the DescribeRegions operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

    }

}
