// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class PAL7ConfigRewriteOp : TeaModel {
        /// <summary>
        /// <para>HTTP header or query parameter name. Required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>X-Test-Param</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>Value to find and replace. Used only for the replace operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>old_value</para>
        /// </summary>
        [NameInMap("OldValue")]
        [Validation(Required=false)]
        public string OldValue { get; set; }

        /// <summary>
        /// <para>Operation type. Required.</para>
        /// <list type="bullet">
        /// <item><description><para><b>add</b>: Add an item.</para>
        /// </description></item>
        /// <item><description><para><b>set</b>: Set a value.</para>
        /// </description></item>
        /// <item><description><para><b>delete</b>: Delete an item.</para>
        /// </description></item>
        /// <item><description><para><b>replace</b>: Replace a value.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>add</para>
        /// </summary>
        [NameInMap("Op")]
        [Validation(Required=false)]
        public string Op { get; set; }

        /// <summary>
        /// <para>Target value as a string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>new_value</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

        /// <summary>
        /// <para>Target value as a string. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>sase_app_name</b>: Application name.</para>
        /// </description></item>
        /// <item><description><para><b>sase_app_id</b>: Application ID.</para>
        /// </description></item>
        /// <item><description><para><b>sase_policy_name</b>: Zero Trust policy name.</para>
        /// </description></item>
        /// <item><description><para><b>sase_user_username</b>: Username.</para>
        /// </description></item>
        /// <item><description><para><b>sase_user_department</b>: User department.</para>
        /// </description></item>
        /// <item><description><para><b>sase_user_group_infos</b>: User organizational structure information.</para>
        /// </description></item>
        /// <item><description><para><b>sase_user_matched_user_groups</b>: User group information.</para>
        /// </description></item>
        /// <item><description><para><b>sase_client_addr</b>: Client address.</para>
        /// </description></item>
        /// <item><description><para><b>sase_client_ip</b>: Client IP address.</para>
        /// </description></item>
        /// <item><description><para><b>sase_client_port</b>: Client port.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sase_app_name</para>
        /// </summary>
        [NameInMap("ValueVariable")]
        [Validation(Required=false)]
        public string ValueVariable { get; set; }

    }

}
