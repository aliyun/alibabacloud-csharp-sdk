// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateVulAutoRepairConfigRequest : TeaModel {
        /// <summary>
        /// <para>The reason why the vulnerability can be automatically fixed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestAutoRepair</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The type of the vulnerability. Valid values: -<b>cve</b>: Linux software vulnerability -<b>sys</b>: Windows system vulnerability</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cve</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The vulnerabilities that can be automatically fixed.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("VulAutoRepairConfigList")]
        [Validation(Required=false)]
        public List<CreateVulAutoRepairConfigRequestVulAutoRepairConfigList> VulAutoRepairConfigList { get; set; }
        public class CreateVulAutoRepairConfigRequestVulAutoRepairConfigList : TeaModel {
            /// <summary>
            /// <para>The alias of the vulnerability.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CVE-2018-25032:zlib 1.2.11 memory corruption</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>The name of the vulnerability.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>anolisos:8.4:ANSA-2022:0001</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
