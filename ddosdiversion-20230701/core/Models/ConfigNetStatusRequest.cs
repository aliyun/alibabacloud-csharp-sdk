// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DdosDiversion20230701.Models
{
    public class ConfigNetStatusRequest : TeaModel {
        /// <summary>
        /// <para>The CIDR block of the anti-DDoS diversion instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX/22</para>
        /// </summary>
        [NameInMap("Net")]
        [Validation(Required=false)]
        public string Net { get; set; }

        /// <summary>
        /// <para>The regions in which the CIDR block needs to be advertised or withdrawn from advertising. If you leave this parameter empty, the CIDR blocks in all regions are configured.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2639086.html">QueryNetList</a> operation to obtain the regions of the CIDR blocks.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public List<string> Regions { get; set; }

        /// <summary>
        /// <para>The ID of the anti-DDoS diversion instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ddos_diversion_public_cn-xxxxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("SaleId")]
        [Validation(Required=false)]
        public string SaleId { get; set; }

        /// <summary>
        /// <para>The status of the CIDR block. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>enable: advertises the CIDR block.</para>
        /// </description></item>
        /// <item><description><para>disable: withdraws the advertising of the CIDR block.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>enable</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The subnet CIDR blocks of the CIDR block.</para>
        /// </summary>
        [NameInMap("SubNets")]
        [Validation(Required=false)]
        public List<string> SubNets { get; set; }

    }

}
