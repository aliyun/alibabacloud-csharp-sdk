// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyLoginSwitchConfigRequest : TeaModel {
        /// <summary>
        /// <para>The type of the logon security settings that you want to enable or disable. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>login_common_ip</b>: unapproved logon IP addresses</description></item>
        /// <item><description><b>login_common_time</b>: unapproved logon time ranges</description></item>
        /// <item><description><b>login_common_account</b>: unapproved logon accounts</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>login_common_account</para>
        /// </summary>
        [NameInMap("Item")]
        [Validation(Required=false)]
        public string Item { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the logon security settings. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: no</description></item>
        /// <item><description><b>1</b>: yes</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
