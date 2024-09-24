// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DeleteVulAutoRepairConfigRequest : TeaModel {
        /// <summary>
        /// <para>The alias of the vulnerability.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RHSA-2017:0184-Important: mysql security update</para>
        /// </summary>
        [NameInMap("AliasName")]
        [Validation(Required=false)]
        public string AliasName { get; set; }

        /// <summary>
        /// <para>The IDs of the configurations.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~ListVulAutoRepairConfig~~">ListVulAutoRepairConfig</a> operation to query the IDs.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ConfigIdList")]
        [Validation(Required=false)]
        public List<long?> ConfigIdList { get; set; }

        /// <summary>
        /// <para>The type of the vulnerability. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>cve: Linux software vulnerability</description></item>
        /// <item><description>sys: Windows system vulnerability</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cve</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
