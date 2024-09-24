// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateAgentClientInstallRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the servers on which you want to install the Security Center agent. Separate multiple IDs with commas (,).</para>
        /// <remarks>
        /// <para>: You must specify at least one of <b>InstanceIds</b> and <b>Uuids</b>. If you specify <b>InstanceIds</b>, you must also specify <b>Region</b> and <b>Os</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>i-uf6j8vq9l4r5ntht****</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The operating system of the servers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>linux</b></description></item>
        /// <item><description><b>windows</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>linux</para>
        /// </summary>
        [NameInMap("Os")]
        [Validation(Required=false)]
        public string Os { get; set; }

        /// <summary>
        /// <para>The region where the servers reside. Valid values include the following regions:</para>
        /// <list type="bullet">
        /// <item><description>cn-hangzhou: China (Hangzhou)</description></item>
        /// <item><description>cn-beijing: China (Beijing)</description></item>
        /// <item><description>cn-shanghai: China (Shanghai)</description></item>
        /// <item><description>cn-zhangjiakou: China (Zhangjiakou)</description></item>
        /// <item><description>cn-shenzhen: China (Shenzhen)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers on which you want to install the Security Center agent. Separate multiple UUIDs with commas (,).</para>
        /// <remarks>
        /// <para>You must specify at least one of the <b>InstanceIds</b> and <b>Uuids</b> parameters before you can call this operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1587bedb-fdb4-48c4-9330-************</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

    }

}
