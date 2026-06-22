// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeFrontVulPatchListRequest : TeaModel {
        /// <summary>
        /// <para>The information about the Windows system vulnerability to query. The value is a JSON string that contains the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>name</b>: the vulnerability name.</description></item>
        /// <item><description><b>uuid</b>: the UUID of the server that has the vulnerability.</description></item>
        /// <item><description><b>tag</b>: the vulnerability tag. Set this field to <b>system</b>, which indicates a system vulnerability.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;name&quot;:&quot;5000803&quot;,&quot;uuid&quot;:&quot;026c9296-1234-5678-b937-a7d81f05****&quot;,&quot;tag&quot;:&quot;system&quot;}]</para>
        /// </summary>
        [NameInMap("Info")]
        [Validation(Required=false)]
        public string Info { get; set; }

        /// <summary>
        /// <para>The language of the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The method to handle the vulnerability. Set this parameter to <b>vul_fix</b>, which indicates fixing the vulnerability.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vul_fix</para>
        /// </summary>
        [NameInMap("OperateType")]
        [Validation(Required=false)]
        public string OperateType { get; set; }

        /// <summary>
        /// <para>The type of vulnerability to query. Set this parameter to <b>sys</b>, which indicates a Windows vulnerability.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sys</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
