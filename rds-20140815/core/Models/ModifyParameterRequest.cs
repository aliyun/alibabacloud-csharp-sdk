// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyParameterRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can use the client to generate the value, and you must ensure that the value is unique across different requests. The value can contain a maximum of 64 ASCII characters and cannot contain non-ASCII characters.</para>
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
        /// <para>Specifies whether to restart the database after the parameters are modified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: forces a restart. If any of the modified parameters require a restart, you must set this parameter to true. Otherwise, the modifications do not take effect.</description></item>
        /// <item><description><b>false</b>: does not force a restart.</description></item>
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
        /// <para>The ID of the parameter template.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you specify this parameter, you do not need to specify the <b>Parameters</b> parameter.</description></item>
        /// <item><description>If the instance must be restarted to apply the parameter template, you must specify the <b>Forcerestart</b> parameter.</description></item>
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
        /// <para>The JSON string of parameters and their values. All parameter values are of the string type. Format: {&quot;ParameterName1&quot;:&quot;ParameterValue1&quot;,&quot;ParameterName2&quot;:&quot;ParameterValue2&quot;...}. You can call the DescribeParameterTemplates operation to query parameter names and values.</para>
        /// <remarks>
        /// <para>If you specify this parameter, you do not need to specify the <b>ParameterGroupId</b> parameter.</para>
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
        /// <para>The time when the parameter modifications take effect. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time must be in UTC.</para>
        /// <remarks>
        /// <para>The specified time must be later than the current time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2022-05-06T09:24:00Z</para>
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

        /// <summary>
        /// <para>The time when the parameter modifications take effect. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Immediate</b>: takes effect immediately. This is the default value.</description></item>
        /// <item><description><b>MaintainTime</b>: takes effect within the maintenance window of the instance. You can call the ModifyDBInstanceMaintainTime operation to modify the maintenance window.</description></item>
        /// <item><description><b>ScheduleTime</b>: takes effect at a specified time. If you set this parameter to ScheduleTime, you must also specify the <b>SwitchTime</b> parameter.</description></item>
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
