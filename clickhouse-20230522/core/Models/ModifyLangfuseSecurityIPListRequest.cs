// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20230522.Models
{
    public class ModifyLangfuseSecurityIPListRequest : TeaModel {
        /// <summary>
        /// <para>The Langfuse instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lfs-bp1*****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the whitelist group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The modification mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: overwrite</description></item>
        /// <item><description>1: increase</description></item>
        /// <item><description>2: delete</description></item>
        /// </list>
        /// <remarks>
        /// <para>Specify 0 to use the overwrite mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ModifyMode")]
        [Validation(Required=false)]
        public string ModifyMode { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IP addresses to add to the instance whitelist. Separate multiple IP addresses with commas (,). For example, 192.168.0.0/24 indicates that all IP addresses in the 192.168.0.XX range are allowed to access the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.0/24,172.16.0.0/24</para>
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

    }

}
