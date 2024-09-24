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
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to restart the instance for a new parameter value to take effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The system forcefully restarts the instance. If a new parameter value takes effect only after the instance restarts, you must set this parameter to true. Otherwise, the new parameter value cannot take effect.</description></item>
        /// <item><description><b>false</b>: The system does not forcefully restart the instance.</description></item>
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
        /// <item><description>If the parameter template can be applied only after the instance is restarted, you must specify <b>Forcerestart</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rpg-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("ParameterGroupId")]
        [Validation(Required=false)]
        public string ParameterGroupId { get; set; }

        /// <summary>
        /// <para>The JSON strings of parameters and their values. All the parameter values are of the string type. Format: {&quot;Parameter name 1&quot;:&quot;Parameter value 1&quot;,&quot;Parameter name 2&quot;:&quot;Parameter value 2&quot;...}. You can call the DescribeParameterTemplates operation to query parameter names and values.</para>
        /// <remarks>
        /// <para> If you specify this parameter, you do not need to specify <b>ParameterGroupId</b>.</para>
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
        /// <para>The time at which the modification takes effect. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>This time must be later than the time at which you call this operation.</para>
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
        /// <item><description><b>Immediate</b>: immediately modifies the parameter. This is the default value.</description></item>
        /// <item><description><b>MaintainTime</b>: modifies the parameter during the maintenance window of the instance. You can call the ModifyDBInstanceMaintainTime operation to change the maintenance window.</description></item>
        /// <item><description><b>ScheduleTime</b>: modifies the parameter at the point in time that you specify. If you specify this value, you must also specify <b>SwitchTime</b>.</description></item>
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
