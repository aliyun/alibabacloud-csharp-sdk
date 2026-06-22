// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateVulsRequest : TeaModel {
        /// <summary>
        /// <para>The method to handle the vulnerability. Set the value to <b>vul_fix</b>, which indicates fixing the vulnerability.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vul_fix</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// <para>The type of vulnerability to fix. Set the value to <b>cve</b>, which indicates a Linux software vulnerability.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cve</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers on which you want to fix the vulnerabilities.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public List<string> Uuids { get; set; }

        /// <summary>
        /// <para>The names of the vulnerabilities to fix.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("VulNames")]
        [Validation(Required=false)]
        public List<string> VulNames { get; set; }

    }

}
