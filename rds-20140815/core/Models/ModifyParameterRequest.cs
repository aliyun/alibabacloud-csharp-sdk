// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyParameterRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcefully restart the database after the modification. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: forcefully restarts the database. If any of the modified parameters require a restart to take effect, you must set this parameter to true. Otherwise, the modification does not take effect.</description></item>
        /// <item><description><b>false</b>: does not forcefully restart the database.</description></item>
        /// </list>
        /// <para>Default value: <b>false</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Forcerestart")]
        [Validation(Required=false)]
        public bool? Forcerestart { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The parameter template ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you specify this parameter, you do not need to specify <b>Parameters</b>.</description></item>
        /// <item><description>If applying the parameter template requires a restart of the instance, you must specify <b>Forcerestart</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rpg-****</para>
        /// </summary>
        [NameInMap("ParameterGroupId")]
        [Validation(Required=false)]
        public string ParameterGroupId { get; set; }

        /// <summary>
        /// <para>The JSON string that consists of parameters and their values. All parameter values are of the string type. Format: {&quot;Parameter name 1&quot;:&quot;Parameter value 1&quot;,&quot;Parameter name 2&quot;:&quot;Parameter value 2&quot;...}. You can call the DescribeParameterTemplates operation to query parameter names and values.</para>
        /// <remarks>
        /// <para>If you specify this parameter, you do not need to specify <b>ParameterGroupId</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;delayed_insert_timeout&quot;:&quot;600&quot;,&quot;max_length_for_sort_data&quot;:&quot;2048&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The scheduled time for the modification to take effect. Format: <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
        /// <remarks>
        /// <para>The specified time must be later than the current time when you call this operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-05-06T09:24:00Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// <para>The time at which the modification takes effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b>: default value. The modification takes effect immediately.</description></item>
        /// <item><description><b>MaintainTime</b>: The modification takes effect during the maintenance window of the instance. You can call the ModifyDBInstanceMaintainTime operation to modify the maintenance window.</description></item>
        /// <item><description><b>ScheduleTime</b>: The modification takes effect at a manually specified time. If you set this parameter to ScheduleTime, you must also specify <b>SwitchTime</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ScheduleTime</para>
        /// </summary>
        [NameInMap("SwitchTimeMode")]
        [Validation(Required=false)]
        public string SwitchTimeMode { get; set; }

    }

}
